using System;
using System.ComponentModel.DataAnnotations;

namespace PracStarcraft
{
    class Batalla 
    {
        private string Fecha;
        
        //variables
        
        static int x=5;
        static int y=5;
        static int z=2000;
        public Batalla()
        {}
        public Raza Peleen(Raza a, Raza b)
        { 
            Raza g1 = a;
            Raza g2 = b;
            Fecha=x+"/"+""+y+"/"+""+z+"";
            x++;
            int dañota = 0; int dañotb = 0;  //daño1 daño2
            int uniae1 = 0; int uniae2 = 0;      //ca1 ca2
            int dañoae1 = 0; int dañoae2 = 0;         //cca1 cca2
            int vidaa = 0; int vidab = 0;     //vidaa vidab

            for (int i = 1; i <= a.GetU().getnr(); i++)
            {
                
                if (a.GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                {
                    uniae1 = uniae1 + 1;
                    dañoae1 = dañoae1 + a.GetU().getunidad(i).DañoEspecifico;
                }
                dañota += a.GetU().getunidad(i).DañoEspecifico;
                vidaa += a.GetU().getunidad(i).Vida;
            }
            for (int i = 1; i <= b.GetU().getnr(); i++)
            {
                if (b.GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                {
                    uniae2 = uniae2 + 1;
                    dañoae2 = dañoae2 + b.GetU().getunidad(i).DañoEspecifico;
                }
                dañotb += b.GetU().getunidad(i).DañoEspecifico;
                vidab += b.GetU().getunidad(i).Vida;
            }
            Console.WriteLine("\n");
            if (dañoae1 == dañoae2)
            {
                if (dañota > dañotb)
                {
                    for (int i = 1; i <= a.GetU().getnr(); i++)
                    {
                        if (dañotb > a.GetU().getunidad(i).Vida)
                        {
                            dañotb -= a.GetU().getunidad(i).Vida;
                            a.GetU().EliminarUnidad(a.GetU().getunidad(i));
                        }
                        else
                        {
                            a.GetU().getunidad(i).CambiaVida(a.GetU().getunidad(i).Vida - dañotb);
                        }

                    }
                    Console.WriteLine("\nGana la raza:" + a.getNomRai());
                    Console.WriteLine("\nTropas Sobrevivientes\n");
                    a.GetU().MostrarTodasLasTropas();
                    return g1;
                }
                else if (dañotb > dañota)
                {
                    Console.WriteLine(dañota);
                    Console.WriteLine(dañotb);
                    Console.WriteLine();
                    for (int i = 1; i <= b.GetU().getnr(); i++)
                    {
                        if (dañota > b.GetU().getunidad(i).Vida)
                        {
                            dañota -= b.GetU().getunidad(i).Vida;
                            b.GetU().EliminarUnidad(b.GetU().getunidad(i));
                        }
                        else
                        {
                            b.GetU().getunidad(i).CambiaVida(b.GetU().getunidad(i).Vida - dañota);
                        }

                    }
                    Console.WriteLine("\nGana la raza:" + b.getNomRai());
                    Console.WriteLine("\nTropas Sobrevivientes:\n");
                    b.GetU().MostrarTodasLasTropas();
                    return g2;
                }
                else
                {
                    Raza[] razas = new Raza[] { new Raza(),new Raza(), new Raza("Zerg"),new Raza(1) };
                    int u, p;
                    Random r1 = new Random();
                    do
                    {
                        u = r1.Next(1,4);
                        p = r1.Next(1,4);
                    } while (u==p);
                    Console.WriteLine("Las razas son iguales cada jugador cambiaran de raza");
                    Console.WriteLine("Jugador 1 jugara con :"+razas[u].getNomRai());
                    Console.WriteLine("Jugador 2 jugara con :"+razas[p].getNomRai());
                    Raza ganadora=Peleen(razas[u], razas[p]);
                    return ganadora;
                }
            }
            else if (dañoae1 > dañoae2)
            {
                int dañotropterre = dañota - dañoae1;
                for (int i = 1; i <= a.GetU().getnr(); i++)
                {
                    if (a.GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                    {
                        if (dañoae1 > a.GetU().getunidad(i).Vida)
                        {
                            dañoae1 -= a.GetU().getunidad(i).Vida;
                            a.GetU().EliminarUnidad(a.GetU().getunidad(i));
                        }
                        else 
                        {
                            a.GetU().getunidad(i).CambiaVida(a.GetU().getunidad(i).Vida-dañoae1);
                        }
                    }
                    else
                    {
                        if (dañotropterre > a.GetU().getunidad(i).Vida)
                        {
                            dañotropterre -= a.GetU().getunidad(i).Vida;
                            a.GetU().EliminarUnidad(a.GetU().getunidad(i));
                        }
                        else 
                        {
                            a.GetU().getunidad(i).CambiaVida(a.GetU().getunidad(i).Vida - dañotropterre);
                        }

                    }

                }
                Console.WriteLine("\nGana la raza:" + a.getNomRai());
                Console.WriteLine("\nTropas Sobrevivientes:\n");
                a.GetU().MostrarTodasLasTropas();
                return g1;
            }
            else
            {
                int dañotropterre = dañotb - dañoae2;
                for (int i = 1; i <= b.GetU().getnr(); i++)
                {
                    if (b.GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                    {
                        if (dañoae2 > b.GetU().getunidad(i).Vida)
                        {
                            dañoae2 -= b.GetU().getunidad(i).Vida;
                            b.GetU().EliminarUnidad(b.GetU().getunidad(i));
                        }
                        else
                        {
                            a.GetU().getunidad(i).CambiaVida(a.GetU().getunidad(i).Vida - dañoae2);
                        }
                    }
                    else
                    {
                        if (dañotropterre > b.GetU().getunidad(i).Vida)
                        {
                            dañotropterre -= b.GetU().getunidad(i).Vida;
                            b.GetU().EliminarUnidad(b.GetU().getunidad(i));
                        }
                        else
                        {
                            b.GetU().getunidad(i).CambiaVida(b.GetU().getunidad(i).Vida - dañotropterre);
                        }

                    }

                }
                Console.WriteLine("\nGana la raza:" + b.getNomRai());
                Console.WriteLine("\nTropas Sobrevivientes:\n");
                b.GetU().MostrarTodasLasTropas();
                return g2;
            }
        }
        public void MostrarLucha(Raza a,Raza b,string fecha) 
        {
            if (this.getfecha().Equals(fecha))
            {

                Console.WriteLine("Se enfrento la raza:" + a.getNomRai());
                Console.WriteLine("Contra la raza:" + b.getNomRai());

            }
            else 
            {
                Console.WriteLine("No se encontro ninguna batalla en esa fecha");
            }
        }
        public void mostrarTropas(Raza a) 
        {
            a.GetU().MostrarTodasLasTropas();
        }
        public string getfecha() {return Fecha; }
    }
}
