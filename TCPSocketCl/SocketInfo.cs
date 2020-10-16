﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPSocketCl
{
    public class SocketInfo
    {
        public Socket sock;
        public string IP;
        public int PORT;
        public bool conn;
        public byte[] r_Buff;
        public SocketInfo(Socket sock,string IP,int PORT,bool conn)
        {
            this.sock = sock;
            this.IP = IP;
            this.PORT = PORT;
            this.conn = conn;
        }
    }
}
