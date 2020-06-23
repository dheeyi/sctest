using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Unidades
    {
        private int nr;
        private Unidad[] unidades = new Unidad[100];
        public Unidades()//terran
        {
            nr = 5;
            Unidad marine = new Unidad("marine", 10, 100, 50, 75, "terrestre");
            Unidad firebat = new Unidad("firebat", 25, 150, 75, 100, "terrestre");
            Unidad vulture = new Unidad("vulture", 50, 200, 100, 125, "aereo");
            Unidad batlecrusier = new Unidad("batlecrusier", 75, 250, 125, 150, "aereo");
            Unidad valkirye = new Unidad("valkirie", 100, 300, 150, 175, "aereo");
            unidades[1] = marine;
            unidades[2] = firebat;
            unidades[3] = vulture;
            unidades[4] = batlecrusier;
            unidades[5] = valkirye;

        }
        public Unidades(string raza) //Zerg
        {
            nr = 5;
            Unidad Zerling = new Unidad("zerling", 10, 100, 50, 75, "terrestre");
            Unidad Hydralisk = new Unidad("hydralisk", 25, 150, 75, 100, "aereo");
            Unidad Ultralisk = new Unidad("ultralisk", 50, 200, 100, 125, "aereo");
            Unidad Mutalisk = new Unidad("mutalisk", 75, 250, 125, 150, "aereo");
            Unidad Queen = new Unidad("queen", 100, 300, 150, 175, "terrestre");
            unidades[1] = Zerling;
            unidades[2] = Hydralisk;
            unidades[3] = Ultralisk;
            unidades[4] = Mutalisk;
            unidades[5] = Queen;
        }
        public Unidades(int i) //Protos
        {
            nr = i;
            Unidad Zealot = new Unidad("zealot", 10, 100, 50, 75, "terrestre");
            Unidad Corsair = new Unidad("coirsar", 25, 150, 75, 100, "aereo");
            Unidad Dragon = new Unidad("dragon", 50, 200, 100, 125, "aereo");
            Unidad Carrier = new Unidad("carrier", 75, 250, 125, 150, "terrestre");
            Unidad Reaver = new Unidad("reaver", 100, 300, 150, 175, "aereo");
            unidades[1] = Zealot;
            unidades[2] = Corsair;
            unidades[3] = Dragon;
            unidades[4] = Carrier;
            unidades[5] = Reaver;
        }
        

        public void AñadirUnidad(Unidad u)
        {
            nr += 1;
            unidades[nr] = u;
        }
        public void EliminarUnidad(Unidad u)
        { 
            for (int i=1;i<=nr;i++) 
            {
                if (unidades[i].Nombre.Equals(u.Nombre)) 
                {
                    for (int j=i+1;j<=nr;j++) 
                    {
                        unidades[j - 1] = unidades[j];
                    }
                    nr--;
                }
            }
        }
        public void MostrarTodasLasTropas()
        {
            for (int i = 1; i <= nr; i++)
            {
                Console.WriteLine("Nombre de unidad:" + unidades[i].Nombre + "\nVida:" + unidades[i].Vida + "\nTipo de daño:" + unidades[i].Tipodedaño + "\nDaño Especifico:" + unidades[i].DañoEspecifico + "\nCoste de gas:" + unidades[i].CostedeproduccionGasVEspeno + "\nCoste de mineral:" +
                    unidades[i].Costodeproduccionmineral);
            }
        }
       

        public void crearUnidad(Raza a) 
        {
            Console.WriteLine("Cuantas unidades quieres crear:");
            int unidades = int.Parse(Console.ReadLine());
            if (a.getNomRai().Equals("Protos"))
            {
                Console.WriteLine("Unidades Disponibles\n" + "zealot " + " dragon " + " coirsar " + " carrier " + " reaver ");
            }
            else if (a.getNomRai().Equals("Zerg"))
            {
                Console.WriteLine("Unidades Disponibles\n" + "zerling " + " hydralisk " + " ultralisk " + " mutalisk " + " queen ");
            }
            else
            {
                Console.WriteLine("Unidades Disponibles:\n" + "marine " + " firebat " + " vulture " + " batlecruiser " + " valkyrie ");
            }
            Muestrario muestrario = new Muestrario();
            for (int i = 1; i <= unidades; i++)
            {
                Unidad u1 = new Unidad();
                u1.leer();
                bool encontrado = false;
                for (int j = 1; j <= muestrario.getnt() && !encontrado; j++)
                {
                    if (muestrario.GetMostrarUni(j).Nombre.Equals(u1.Nombre))
                    {
                        u1 = muestrario.GetMostrarUni(j);

                        if (a.getRecIni() - (u1.Costodeproduccionmineral + u1.CostedeproduccionGasVEspeno) < 0)
                        {
                            a.AumRec();
                            Console.WriteLine("Recursos totales minerales para recolectar:" + a.getReToMi());
                            Console.WriteLine("Recursos totales Gas Vespeno para recolectar:" +a.getToGaVe());
                        }
                        AñadirUnidad(u1);

                        a.setRecFin(a.getRecIni() - u1.Costodeproduccionmineral);
                        a.setRecFin(a.getRecIni() - u1.CostedeproduccionGasVEspeno);

                        encontrado = true;
                    }
                }
                if (nr % 11 == 0 && a.getNe() <= nr/11)
                {
                    Console.WriteLine("Necesitas costruir mas estructuras principales\nEstructuras principales:"+a.getNe());
                    Console.Write("Cuantas estructuras principales construiras:");
                    int estructuras = int.Parse(Console.ReadLine());
                    a.AunEstPri(estructuras);
                }
            }
            if (a.getRecIni()<0) 
            {
                Console.WriteLine(a.getRecIni());
                Console.WriteLine("Necesitas mas recursos");
                a.AumRec();
            }
        }
        public int getnr() { return nr; }
        public Unidad getunidad(int i) { return unidades[i]; }
    }

    



}

