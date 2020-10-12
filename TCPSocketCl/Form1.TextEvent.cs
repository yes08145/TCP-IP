using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSocketCl
{
    public partial class Form1 : Form
    {
        private void TboxValue()
        {
            IP1 = Convert.ToInt32(textBox_IP1.Text);
            IP2 = Convert.ToInt32(textBox_IP2.Text);
            IP3 = Convert.ToInt32(textBox_IP3.Text);
            IP4 = Convert.ToInt32(textBox_IP4.Text);
            PORT = Convert.ToInt32(textBox_Port.Text);
        }
        private void TboxClear()
        {
            textBox_IP1.Clear();
            textBox_IP2.Clear();
            textBox_IP3.Clear();
            textBox_IP4.Clear();
            textBox_Port.Clear();
        }
        private void ReceiveText()
        {
            Log(strHex);
        }

        //숫자키만 입력가능
        private void textBox_IP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void TextBox_Aoutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        //text Clear
        private void btn_textClear_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
        }

        private void listBox_quick_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_quick.SelectedItem != null)
            {
                q_ip1 = listBox_quick.SelectedItem.ToString().Split('.')[0];
                q_ip2 = listBox_quick.SelectedItem.ToString().Split('.')[1];
                q_ip3 = listBox_quick.SelectedItem.ToString().Split('.')[2];
                q_ip4 = listBox_quick.SelectedItem.ToString().Split('.')[3].Split(':')[0];
                q_port = listBox_quick.SelectedItem.ToString().Split(':')[1];
            }
        }

        private void btn_quick_Click(object sender, EventArgs e)
        {
            if (listBox_quick.SelectedItem != null)
            {
                textBox_IP1.Text = q_ip1;
                textBox_IP2.Text = q_ip2;
                textBox_IP3.Text = q_ip3;
                textBox_IP4.Text = q_ip4;
                textBox_Port.Text = q_port;
                listBox_quick.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("선택된 IP가 없습니다.");
                //MessageBox.Show(filePath);
            }
        }
    }
}
