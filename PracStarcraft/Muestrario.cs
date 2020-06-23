using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Muestrario
    {
        private Unidad[] muestrario = new Unidad[16];
        private int nt;
        public Muestrario()
        {
            nt = 15;
            Unidad Zealot = new Unidad("zealot", 10, 100, 50, 75, "terrestre");
            Unidad Corsair = new Unidad("coirsar", 25, 150, 75, 100, "aereo");
            Unidad Dragon = new Unidad("dragon", 50, 200, 100, 125, "aereo");
            Unidad Carrier = new Unidad("carrier", 75, 250, 125, 150, "terrestre");
            Unidad Reaver = new Unidad("reaver", 100, 300, 150, 175, "aereo");

            //Unidad Zerg

            Unidad Zerling = new Unidad("zerling", 10, 100, 50, 75, "terrestre");
            Unidad Hydralisk = new Unidad("hydralisk", 25, 150, 75, 100, "aereo");
            Unidad Ultralisk = new Unidad("ultralisk", 50, 200, 100, 125, "aereo");
            Unidad Mutalisk = new Unidad("mutalisk", 75, 250, 125, 150, "aereo");
            Unidad Queen = new Unidad("queen", 100, 300, 150, 175, "terrestre");

            //Unidades Terran

            Unidad marine = new Unidad("marine", 10, 100, 50, 75, "terrestre");
            Unidad firebat = new Unidad("firebat", 25, 150, 75, 100, "terrestre");
            Unidad vulture = new Unidad("vulture", 50, 200, 100, 125, "aereo");
            Unidad batlecrusier = new Unidad("batlecrusier", 75, 250, 125, 150, "aereo");
            Unidad valkirye = new Unidad("valkirie", 100, 300, 150, 175, "aereo");

            muestrario[1] = Zealot;
            muestrario[2] = Corsair;
            muestrario[3] = Dragon;
            muestrario[4] = Carrier;
            muestrario[5] = Reaver;
            muestrario[6] = Zerling;
            muestrario[7] = Hydralisk;
            muestrario[8] = Ultralisk;
            muestrario[9] = Mutalisk;
            muestrario[10] = marine;
            muestrario[11] = Queen;
            muestrario[12] = firebat;
            muestrario[13] = vulture;
            muestrario[14] = batlecrusier;
            muestrario[15] = valkirye;
        }
        public Unidad GetMostrarUni(int i)
        {
            return muestrario[i];

        }
        public int getnt() 
        {
            return nt;
        }
    }
}
