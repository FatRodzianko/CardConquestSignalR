using System;
using System.Collections.Generic;
using System.Text;
using CardConquestSignalR.Shared;

namespace CardConquestSignalR.Shared
{
    public class Rooms
    {
        public string RoomName { get; set; }
        public List<Player> Players { get; set; }

        public Rooms(string roomname, List<Player> players)
        {
            RoomName = roomname;
            Players = players;
        }
    }
}
