using System;
using System.Collections.Generic;
using System.Text;

namespace BuBTT.Shared
{
    public class Collectible
    {
        public int ItemId { get; set; }
        public int CollectionId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool Painted { get; set; }
    }

    public class Collection 
    {
        public int CollectionId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
    }
}
