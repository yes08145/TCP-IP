﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TCPSocketCl
{
    public partial class Form1 : Form
    {
        private static string reconnIP = string.Empty;
        private static int reconnPORT = 5000;
        //private static bool reconn = false;
        private static Mutex mutex = new Mutex();
        private void SocketConnect(string in_IP, int in_PORT)
        {

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(in_IP), in_PORT);
            Log("======="+in_IP+":"+in_PORT+ " Connect 시도중=======");
            try
            {
                try
                {
                    Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.ReceiveTimeout = 300000;
                    sock.Connect(ep);
                    socketInfo.Add(new SocketInfo(sock, in_IP, in_PORT, true,socketInfo.Count)); // 0부터 시작 인덱스
                    Log2(in_IP + ":" + in_PORT); // 1이 시작 인덱스
                    Log("========= IP: " + in_IP + ", PORT: " + in_PORT + " Connect 완료 =========");
                }
                catch
                {
                    Log("=======Connect Fail=======");
                    MessageBox.Show("서버에 연결할 수 없습니다.");
                }

            }
            catch (Exception e)
            {
                if (e.Message == "이미 연결되어있음")
                {
                    MessageBox.Show(e.Message);
                }
                return;
            }
        }
        private void SocketDisconnect()
        {
            try
            {
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.index == dataGridView1.SelectedRows[0].Index)
                    {
                        SocketDisconnect(usedSockInfo);
                        return;
                    }
                }
                MessageBox.Show("Connect중인 서버가 없습니다.");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Disconnect할 서버를 선택해주십시오.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Disconnect할 서버를 선택해주십시오.");
            }
        }
        private void SocketDisconnect(object obj)
        {
            try
            {
                if (obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Send(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    SocketInfo throwSockInfo = (SocketInfo)obj;
                    if (throwSockInfo.conn)
                    {
                        throwSockInfo.conn = false;
                        throwSockInfo.sock.Shutdown(SocketShutdown.Both);
                        throwSockInfo.sock.Close();
                        ipList.RemoveAt(throwSockInfo.index);
                        socketInfo.RemoveAt(throwSockInfo.index);
                        int i = 0;
                        foreach(SocketInfo list in socketInfo)
                        {

                            //string listBox_text = listBox_quick.Items[i].ToString().Split(')')[1];
                            list.index = i;

                            //listBox_quick.Items[i] = (list.index+1)+")"+listBox_text;
                            i++;
                        }
                        dataGridView1.DataSource = ipList.Select(ip => new { Value = ip }).ToList();
                        Log("======= Connect 종료 =======");
                        ListboxFocus();
                    }
                }
            }
            catch(Exception e)

            {
                
            }
        }
        private void StartThread(SocketInfo socketInfo, SocketDelegate socketDelegate, string str)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(socketDelegate));
            if (str == "recv") thread.Priority = ThreadPriority.Highest;
            else if(str == "send") thread.Priority = ThreadPriority.Lowest;
            thread.Start(socketInfo);
        }
        public void Send(object obj)
        {
            try
            {
                if(obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Send(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    byte[] sendBuff = MakeMsg((SocketInfo)obj);
                    SocketInfo socketInfo = (SocketInfo)obj;
                    socketInfo.sock.Send(sendBuff);
                    strHex = BitConverter.ToString(sendBuff);
                    ResultSet result = SplitAndCksum(sendBuff);
                    string hex_cksum = result.hex_cksum;
                    string log_result = JudgeAction(strHex, hex_cksum);
                    //# D I/O 추가에 따라 기존 log 텍스트 불러오는 공식이 깨짐
                    //# 이를 해결하기 위한 배열 위치조정
                    //# 이로인한 sensorID 손상 인지요망
                    if (sendBuff[3] == 4)
                    {
                        //Thread.Sleep(100);
                    }

                    if (!InvokeRequired)
                    {
                        Log(log_result);
                        Log(strHex);
                        ListboxFocus();
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            if (s_log_text) Log(log_result);
                            if (s_log_sendBuff) Log("SendBuffer   : " + strHex);
                        }
                        ));
                        //this.Invoke(new LogDelegate(Log), log_result);
                        //this.Invoke(new LogDelegate(Log), strHex);
                        this.Invoke(new FocusDelegate(ListboxFocus));
                    }

                }
                
            }
            //catch(FormatException ee)
            //{
            //    MessageBox.Show("채널 또는 값을 선택해주세요");
            //    //throw ee;
            //}
            catch(Exception e)
            {
                //MessageBox.Show("Function Send Exception Check");
            }
        }
        public void Recv(object obj)
        {
            try
            {
                if (obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Recv(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    SocketInfo socketInfo = (SocketInfo)obj;
                    while (socketInfo.conn)
                    {
                        byte[] receiverBuff = new byte[16];
                        int n = socketInfo.sock.Receive(receiverBuff);
                        // Splitcksum return을 int resultSet 에서 
                        // (strHexSplit, hex_cksum, resultSet)을 가지는 class ResultSet 으로 바꿈
                        // 전역변수 지역변수화
                        string hex_cksum = string.Empty;
                        string strHexSplit = string.Empty;
                        string log_result = string.Empty;
                        int resultSet = 0;
                        try
                        {
                            ResultSet result = SplitAndCksum(receiverBuff);
                            if (result.strHexSplit == string.Empty) continue; //값을 빠른속도로 받아올 때 오류발생해서 추가(10-22)
                            strHexSplit = result.strHexSplit;
                            hex_cksum = result.hex_cksum;
                            resultSet = result.resultSet;
                            // 테스트 결과 send가 recv log앞에 있어서 출력창에 recv-send순으로 log가 뜨지않고
                            // send-recv순으로 뜸
                            // 따라서 JudgeAction 순서 앞으로 변경
                            log_result = JudgeAction(strHexSplit, hex_cksum);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            resultSet = 5; // resultSet은 SensorID의 값이기 때문에 아래 if문에 걸리지 않게만 즉, resultSet을 0,3이 아닌 다른값으로 지정하면 됨
                            log_result = "Index 오류 발생";
                        }
                        if (resultSet == 0) continue;
                        else if (resultSet == 3)
                        {
                            if (socketInfo.conn)
                            {
                                    socketInfo.r_Buff = receiverBuff;
                                // sensorID가 3에서 4로 변하면서 cksum이 1증가함
                                //hex_cksum = (Convert.ToInt32(hex_cksum) + 1).ToString();
                                    
                                    StartThread(socketInfo, Send, "send");
                                    
                                //recv log에 띄울 cksum으로 다시 되돌림
                                //hex_cksum = (Convert.ToInt32(hex_cksum) - 1).ToString();
                            }
                        }

                        if (!InvokeRequired)
                        {
                            Log(log_result);
                            Log(strHexSplit);
                            ListboxFocus();
                        }
                        else
                        {
                            this.Invoke(new Action(() =>
                            {
                                if (r_log_text) Log(log_result);
                                if (r_log_realBuff) Log("ReceiveBuff : " + BitConverter.ToString(receiverBuff));
                                if (r_log_splitBuff) Log("SplitReceive : " + strHexSplit);
                            }
                            ));
                            this.Invoke(new FocusDelegate(ListboxFocus));
                        }
                        Thread.Sleep(1000);
                    }
                }

            }
            catch (Exception e)
            {
                if (e.Message == "Recv(object obj): obj 타입이 SocketInfo가 아님")
                {

                }
                else if (e.GetType().Name == "SocketException")
                {
                    SocketInfo disconnectedSocketInfo = (SocketInfo)obj;
                    //뮤텍스: 공유자원 reconnIP-재접속할 IP, reconnPORT-재접속할 PORT
                    //Lock
                    mutex.WaitOne();
                    reconnIP = disconnectedSocketInfo.IP;
                    reconnPORT = disconnectedSocketInfo.PORT;
                    if (disconnectedSocketInfo.conn)
                    {
                        this.Invoke(new SocketDelegate(SocketDisconnect), disconnectedSocketInfo);
                        this.Invoke(new Action(() =>
                        {
                            if (MessageBox.Show(this, "서버와의 연결이 끊겼습니다.\n다시 접속하시겠습니까?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                //reconn = true;
                                int socketCount = socketInfo.Count;
                                SocketConnect(reconnIP,reconnPORT);
                                //ListboxFocus();
                                if (socketCount < socketInfo.Count)
                                {
                                    StartThread(socketInfo[socketInfo.Count - 1], Recv, "recv");
                                }
                            }
                            else
                            {
                                //reconn = false;
                                reconnIP = string.Empty;
                                reconnPORT = 0;
                            }
                        }
                        ));
                    }
                    //Unlock
                    mutex.ReleaseMutex();
                    
                }

            }
        }

        public byte[] MakeMsg(SocketInfo sendSocketInfo)
        {
            byte[] msg;
            RTUP rtup = new RTUP();
            byte[] receiverBuff = sendSocketInfo.r_Buff;
            if (receiverBuff != null)
            {
                string r_strHex = BitConverter.ToString(receiverBuff);
                rtup.usys_device_ID = Convert.ToByte(Convert.ToInt32("0x"+r_strHex.Split('-')[1],16));
                rtup.length = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[2],16));
                rtup.sensor_ID = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[3],16));
                rtup.ch_setting = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[4],16));
                rtup.data = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[5], 16));
                rtup.check_sum[0] = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[6], 16));
                rtup.check_sum[1] = Convert.ToByte(Convert.ToInt32(r_strHex.Split('-')[7], 16));
                sendSocketInfo.r_Buff = null;
            }
            else
            {
                rtup.usys_device_ID = 0x74;
                rtup.sensor_ID = (byte)sensorID;
            }
            //0 or 1 장비 선택
            
            try
            {
                if (rtup.sensor_ID == 1)
                {
                    //if(data == 404 || aout_ch == 404) throw new FormatException("채널 또는 data가 올바르지 않습니다.");
                    // 4~20mA
                    rtup.ch_setting = (byte)aout_ch;
                    rtup.data = (byte)data;
                    rtup.length = 0x09;
                    //checksum
                    int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting + rtup.data;

                    rtup.check_sum[0] = (byte)(checkSum / 256);
                    rtup.check_sum[1] = (byte)(checkSum % 256);

                    msg = new byte[9];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = rtup.sensor_ID;
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.data;
                    msg[6] = rtup.check_sum[0];
                    msg[7] = rtup.check_sum[1];
                    msg[8] = rtup.eof;
                }
                else if (rtup.sensor_ID == 2)
                {
                    rtup.ch_setting = (byte)ain_ch;
                    rtup.length = 0x08;
                    int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting;
                    rtup.check_sum[0] = (byte)(checkSum / 256);
                    rtup.check_sum[1] = (byte)(checkSum % 256);

                    msg = new byte[8];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = rtup.sensor_ID;
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.check_sum[0];
                    msg[6] = rtup.check_sum[1];
                    msg[7] = rtup.eof;
                }
                else if (rtup.sensor_ID == 3)
                {
                    int checkSum = rtup.check_sum[0] * 256 + rtup.check_sum[1]+1;
                    rtup.check_sum[0] = (byte)(checkSum / 256);
                    rtup.check_sum[1] = (byte)(checkSum % 256);
                    msg = new byte[9];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = Convert.ToByte(rtup.sensor_ID+1);
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.data;
                    msg[6] = rtup.check_sum[0];
                    msg[7] = rtup.check_sum[1];
                    msg[8] = rtup.eof;
                }
                else if(rtup.sensor_ID == 4)
                {
                    // digit 0/1
                    rtup.ch_setting = (byte)dout_ch;
                    if(data != 0 && data != 1)
                    {
                        throw new FormatException("보내고자하는 Digital Output\t"+data+"은 잘못된 값입니다.");
                    }
                    rtup.data = (byte)data;
                    rtup.length = 0x09;
                    //checksum
                    int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting + rtup.data;
                    rtup.check_sum[0] = (byte)(checkSum / 256);
                    rtup.check_sum[1] = (byte)(checkSum % 256);

                    msg = new byte[9];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = rtup.sensor_ID;
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.data;
                    msg[6] = rtup.check_sum[0];
                    msg[7] = rtup.check_sum[1];
                    msg[8] = rtup.eof;
                }
                else
                {
                    throw new NullReferenceException("잘못된 요청명령");
                }
            }
            catch (FormatException ee)
            {
                MessageBox.Show("Digitial Output data는 잘못된값입니다.");
                throw ee;
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("채널 또는 data가 올바르지 않습니다.");
                throw e;
            }
            return msg;
        }

        public string JudgeAction(string txt, string hex_cksum)
        {
            RTUP rtup = new RTUP();
            string log = string.Empty;
            rtup.usys_device_ID = Convert.ToByte(Convert.ToInt32("0x"+txt.Split('-')[1], 16));
            rtup.length = Convert.ToByte(Convert.ToInt32(txt.Split('-')[2], 16));
            rtup.sensor_ID = Convert.ToByte(txt.Split('-')[3]);
            rtup.response_channel = Convert.ToByte(txt.Split('-')[4]);
            rtup.data = Convert.ToByte(Convert.ToInt32(txt.Split('-')[5],16)); // 나중에 data값으로 문제가 생기면 if안의 지역으로 위치수정
            string start_cksum = string.Empty;
            string last_cksum = string.Empty;
            int device_num = 0;
            if (rtup.usys_device_ID == 0x74) device_num = 1;
            else
            {
                log = device_judge[device_num];
                return log;
            }
            if (hex_cksum.Length >= 3)
            {
                start_cksum = hex_cksum.Substring(0, hex_cksum.Length - 2);
                last_cksum = hex_cksum.Substring(hex_cksum.Length - 2);
                if (start_cksum.Length == 1)
                {
                    start_cksum = "0" + start_cksum;
                }
            }
            else
            {
                start_cksum = "00";
                last_cksum = hex_cksum;
                if (last_cksum.Length == 1)
                {
                    last_cksum = "0" + last_cksum;
                }
            }
            if (start_cksum != txt.Split('-')[rtup.length - 3] || last_cksum != txt.Split('-')[rtup.length - 2])
            {
                log = "CheckSum 오류";
                return log;
            }
            //로그를 띄워주자 (체크섬 오류)

            if (rtup.sensor_ID == 1)
            {
                if (rtup.response_channel == 0 || rtup.response_channel == 1)
                {
                    if (rtup.length == 8) log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널에서 " + logMsg[rtup.sensor_ID + 2];
                    else log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널로 " + logMsg[rtup.sensor_ID - 1];
                }
                else log = "Format 오류";
            }
            else if (rtup.sensor_ID == 2)
            {
                if ((rtup.response_channel == 0 || rtup.response_channel == 1)&& (rtup.data>=4 && rtup.data<=20))
                {
                    if (rtup.length == 9) log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널에서 '" + rtup.data + "mA'의 " + logMsg[rtup.sensor_ID + 2];
                    else log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널로 " + logMsg[rtup.sensor_ID - 1];
                }
                else log = "Format 오류";
            }
            else if (rtup.sensor_ID == 3)
            {
                if((rtup.response_channel == 0 || rtup.response_channel == 1 || rtup.response_channel == 2 || rtup.response_channel == 3) && rtup.data <2)
                log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널에서 시그널'" + rtup.data + "'  " + logMsg[rtup.sensor_ID + 2];
                else log = "Format 오류";
            }
            else if (rtup.sensor_ID == 4)
            {
                if (rtup.response_channel == 0 || rtup.response_channel == 1 || rtup.response_channel == 2 || rtup.response_channel == 3)
                log = "Device " + device_judge[device_num] + "의 " + rtup.response_channel + "채널로 시그널'" + rtup.data + "'  " + logMsg[rtup.sensor_ID - 2];
                else log = "Format 오류";
            }
            else log = "SensorID 오류";

            return log;
        }

        private ResultSet SplitAndCksum(byte[] receiverBuff)
        {
            int resultSet = 0;
            int dec_cksum = 0;
            string strHexSplit = string.Empty;
            string hex_cksum = string.Empty;
            string r_strHex = BitConverter.ToString(receiverBuff);
            int p_length = Convert.ToInt32(r_strHex.Split('-')[2], 16);
            if (r_strHex.Split('-')[0] == "02" && r_strHex.Split('-')[p_length - 1] == "03")
            {
                strHexSplit = r_strHex.Substring(0, (p_length * 2) + (p_length - 1));
                resultSet = Convert.ToInt32(r_strHex.Split('-')[3], 16);
            }
            //cksum 계산
            if (p_length == 8)
            {
                dec_cksum = receiverBuff[0] + receiverBuff[1] + receiverBuff[2] + receiverBuff[3] + receiverBuff[4];
            }
            else if (p_length == 9)// (r_strHex.Split('-')[3] == "2"
            {
                dec_cksum = receiverBuff[0] + receiverBuff[1] + receiverBuff[2] + receiverBuff[3] + receiverBuff[4] + receiverBuff[5];
            }
            hex_cksum = String.Format("{0:x2}", dec_cksum).ToUpper();
            
            return new ResultSet(strHexSplit, hex_cksum, resultSet);
        }

    }
}
