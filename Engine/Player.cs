﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingThing
    {
        public int CurrentGold { get; set; }
        public int XP { get; set; }
        public int Lvl { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentGold, int xp, int lvl, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            CurrentGold = currentGold; XP = xp; Lvl = lvl; CurrentHP = currentHP; MaxHP = maxHP;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }

}
