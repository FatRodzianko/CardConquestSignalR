using System;
using System.Collections.Generic;
using System.Text;
using CardConquestSignalR.Shared;

namespace CardConquestSignalR.Shared
{
    public class Rooms
    {
        public string RoomName { get; set; }
        public ICollection<Player> Players { get; set; }

        public Rooms(string roomname, List<Player> players)
        {
            RoomName = roomname;
            Players = players;
        }
    }
}
