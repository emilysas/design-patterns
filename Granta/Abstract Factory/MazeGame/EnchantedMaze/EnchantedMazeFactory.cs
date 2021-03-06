﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame.EnchantedMaze
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }

        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}
