﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zmq;

namespace NetMQ
{
    public class PushSocket : BaseSocket
    {
        public PushSocket(SocketBase socketHandle)
            : base(socketHandle)
        {
        }
    }
}
