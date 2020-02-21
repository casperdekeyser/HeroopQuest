using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeroType {Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public string Name { get;  set; }
        public string Description { get; private set; }
        public int MaxIntelligence { get; private set; }
        public int CurrentIntelligence { get; set; }
        public int MaxBody { get; private set; }
        public int CurrentBody { get; set; }
        public HeroType HeroType { get; private set; }

        public int AttackValue { get; private set; } = 2;
        public int DefenseVallue { get; private set; } = 2;
        public int RunValue { get; private set; } = 2;
    }
}
