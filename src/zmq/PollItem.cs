/*
    Copyright (c) 2009-2011 250bpm s.r.o.
    Copyright (c) 2007-2009 iMatix Corporation
    Copyright (c) 2007-2011 Other contributors as noted in the AUTHORS file

    This file is part of 0MQ.

    0MQ is free software; you can redistribute it and/or modify it under
    the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation; either version 3 of the License, or
    (at your option) any later version.

    0MQ is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Net.Sockets;

namespace zmq
{
	public class PollItem
	{
        public PollItem(SocketBase socket, PollEvents events)
        {
            Socket = socket;
            Events = events;
            FileDescriptor = null;
        }

        public PollItem(Socket fileDescriptor, PollEvents events)
        {
            Socket = null;
            Events = events;
            FileDescriptor = fileDescriptor;
        }
		
		public SocketBase Socket
		{
			get;
			private set;
		}

		public Socket FileDescriptor { get; private set; }

		public PollEvents Events { get; private set; }


		public PollEvents ResultEvent { get; set; }


	}
}
