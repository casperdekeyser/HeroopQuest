﻿using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType {Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobbelsteen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Tovenaar:
                    AanvalDobbelsteen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
            
        }

        public string Naam { get;  set; }
        public string Beschrijving { get; private set; }
        public int MaxIntelligentie { get; private set; }
        public int HuidigIntelligentie { get; set; }
        public int MaxLichaam { get; private set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }

        public int AanvalDobbelsteen { get; private set; } = 2;
        public int VerdedigingDobbelsteen { get; private set; } = 2;
        public int LoopDobbelsteen { get; private set; } = 2;


    }
}
