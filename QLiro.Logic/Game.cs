using System;
using System.Collections.Generic;
using System.Linq;

namespace QLiro.Logic
{
    public class Game
    {
        public enum ItemType
        {
            Goat,
            Car
        }

        public ItemType ItemBehindDoor1 { get; set; }
        public ItemType ItemBehindDoor2 { get; set; }
        public ItemType ItemBehindDoor3 { get; set; }


        public Game()
        {
            AssignItemsBehindDoorsRandomly();
        }

        private void AssignItemsBehindDoorsRandomly()
        {
            var rnd = new Random();
            var itemsToBePlacedBehindDoors = new List<ItemType>() {ItemType.Car, ItemType.Goat, ItemType.Goat}
                .OrderBy(item => rnd.Next()).ToList();
            ItemBehindDoor1 = itemsToBePlacedBehindDoors.ElementAt(0);
            ItemBehindDoor2 = itemsToBePlacedBehindDoors.ElementAt(1);
            ItemBehindDoor3 = itemsToBePlacedBehindDoors.ElementAt(2);
        }
    }
}
