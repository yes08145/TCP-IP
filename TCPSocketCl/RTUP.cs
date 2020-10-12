using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPSocketCl
{
    class RTUP
    {
        public byte sof = 0x02;
        public byte usys_device_ID = 0x74;
        public byte length = 0x09;
        public byte sensor_ID;
        public byte ch_setting;
        public byte data;
        public byte check_sum;
        public byte eof = 0x03;
        public byte response_channel;
    }
}
