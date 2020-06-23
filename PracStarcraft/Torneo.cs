using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Torneo
    {
        private int np;
        private string Fecha;
        private Participante[] participantes = new Participante[5];
        static int x = 5;
        static int y = 5;
        static int t = 5;
        static int z = 2000;
        static int i = 1;

        public Torneo()
        {
            np = 4;
            participantes[1] = new Participante();
            participantes[2] = new Participante("maton24", "1111111", new Raza("Zerg"));
            participantes[3] = new Participante("morboson21", "222222", new Raza("Zerg"));
            participantes[4] = new Participante("nosexd", "888888", new Raza(1));
            Batalla Eliminatoria1 = new Batalla();
            Batalla Eliminatoria2 = new Batalla();
            Batalla Final = new Batalla();

            Console.WriteLine("Eliminatorias\n\n");
            Console.WriteLine("Resultados eliminatoria1:\n\n");
            Raza g1 = Eliminatoria1.Peleen(participantes[1].getRazaPar(), participantes[2].getRazaPar());
            Console.WriteLine("\n\n");
            Console.WriteLine("Resultados eliminatorias2:\n\n");
            Raza g2 = Eliminatoria2.Peleen(participantes[3].getRazaPar(), participantes[4].getRazaPar());
            Console.WriteLine("\n\n");
            Console.WriteLine("Batalla Final\n\n");
            Raza g3 = Final.Peleen(g1, g2);
            Fecha = "5/5/2002";

        }

        public Torneo(int i)
        {
            np = i;
            participantes[1] = new Participante();
            participantes[2] = new Participante();
            participantes[3] = new Participante();
            participantes[4] = new Participante();
        }
        public void leerTorneo()
        {
            Console.WriteLine("Un torneo se realiza con 4 participantes,!!!inscribalos\n");
            for (int i = 1; i <= 4; i++)
            {
                participantes[i].leer();
            }
            np = 4;
        }
        public void eliminarParticipante(Participante p)
        {
            for (int i = 1; i <= np; i++)
            {
                if (participantes[i].getnick().Equals(p.getnick()))
                {
                    for (int j = i + 1; j <= np; j++)
                    {
                        participantes[j - 1] = participantes[j];
                    }
                    np--;
                }
            }
        }
        public Participante IniciaTorneo(Participante a, Participante b)
        { 
            Fecha = x + "/" + "" + y + "/" + "" + z + "";
            x++;
            
            Participante pganador1 = a;
            Participante pganador2 = b;

            int dañota = 0; int dañotb = 0;
            int uniae1 = 0; int uniae2 = 0;
            int dañoae1 = 0; int dañoae2 = 0;
            int vidaa = 0; int vidab = 0;

            for (int i = 1; i <= a.getRazaPar().GetU().getnr(); i++)
            {

                if (a.getRazaPar().GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                {
                    uniae1 = uniae1 + 1;
                    dañoae1 = dañoae1 + a.getRazaPar().GetU().getunidad(i).DañoEspecifico;
                }
                dañota += a.getRazaPar().GetU().getunidad(i).DañoEspecifico;
                vidaa += a.getRazaPar().GetU().getunidad(i).Vida;
            }
            for (int i = 1; i <= b.getRazaPar().GetU().getnr(); i++)
            {
                if (b.getRazaPar().GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                {
                    uniae2 = uniae2 + 1;
                    dañoae2 = dañoae2 + b.getRazaPar().GetU().getunidad(i).DañoEspecifico;
                }
                dañotb += b.getRazaPar().GetU().getunidad(i).DañoEspecifico;
                vidab += b.getRazaPar().GetU().getunidad(i).Vida;
            }

            if (dañoae1 == dañoae2)
            {
                if (dañota > dañotb)
                {
                    for (int i = 1; i <= a.getRazaPar().GetU().getnr(); i++)
                    {
                        if (dañotb > a.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañotb -= a.getRazaPar().GetU().getunidad(i).Vida;
                            a.getRazaPar().GetU().EliminarUnidad(a.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            a.getRazaPar().GetU().getunidad(i).CambiaVida(a.getRazaPar().GetU().getunidad(i).Vida - dañotb);
                        }

                    }
                    Console.WriteLine("\nGana el jugador:" + a.getnick());
                    Console.WriteLine("\nGana la raza:" + a.getRazaPar().getNomRai());
                    Console.WriteLine("\nTropas Sobrevivientes:\n");
                    a.getRazaPar().GetU().MostrarTodasLasTropas();
                    return pganador1;
                }
                else if (dañotb > dañota)
                {
                    for (int i = 1; i <= b.getRazaPar().GetU().getnr(); i++)
                    {
                        if (dañota > b.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañota -= b.getRazaPar().GetU().getunidad(i).Vida;
                            b.getRazaPar().GetU().EliminarUnidad(b.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            b.getRazaPar().GetU().getunidad(i).CambiaVida(b.getRazaPar().GetU().getunidad(i).Vida - dañota);
                        }

                    }
                    Console.WriteLine("\nGana el jugador:" + b.getnick());
                    Console.WriteLine("\nGana la raza:" + b.getRazaPar().getNomRai());
                    Console.WriteLine("\nTropas Sobrevivientes:\n");
                    b.getRazaPar().GetU().MostrarTodasLasTropas();
                    return pganador2;

                }
                else
                { 
                    Raza[] razas = new Raza[] { new Raza(), new Raza(), new Raza("Zerg"), new Raza(1) };
                    int u, p;
                    Random r1 = new Random();
                    do
                    {
                        u = r1.Next(1, 4);
                        p = r1.Next(1, 4);
                    } while (u == p);
                    Console.WriteLine("Las razas son iguales cada jugador cambiaran de raza");
                    Console.WriteLine("Jugador:"+a.getnick()+ " jugara con :" + razas[u].getNomRai());
                    Console.WriteLine("Jugador:"+b.getnick()+" jugara con :" + razas[p].getNomRai());
                    a.setRaza(razas[u]);
                    b.setRaza(razas[p]);
                    Participante ganadora = IniciaTorneo(a, b);
                    return ganadora;
                }
            }
            else if (dañoae1 > dañoae2)
            {
                int dañotropterre = dañota - dañoae1;
                for (int i = 1; i <= a.getRazaPar().GetU().getnr(); i++)
                {
                    if (a.getRazaPar().GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                    {
                        if (dañoae1 > a.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañoae1 -= a.getRazaPar().GetU().getunidad(i).Vida;
                            a.getRazaPar().GetU().EliminarUnidad(a.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            a.getRazaPar().GetU().getunidad(i).CambiaVida(a.getRazaPar().GetU().getunidad(i).Vida - dañoae1);
                        }
                    }
                    else
                    {
                        if (dañotropterre > a.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañotropterre -= a.getRazaPar().GetU().getunidad(i).Vida;
                            a.getRazaPar().GetU().EliminarUnidad(a.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            a.getRazaPar().GetU().getunidad(i).CambiaVida(a.getRazaPar().GetU().getunidad(i).Vida - dañotropterre);
                        }

                    }

                }
                Console.WriteLine("\nGana el jugador:" + a.getnick());
                Console.WriteLine("\nGana la raza:" + a.getRazaPar().getNomRai());
                Console.WriteLine("\nTropas Sobrevivientes:\n");
                a.getRazaPar().GetU().MostrarTodasLasTropas();
                return pganador1;
            }
            else
            {
                int dañotropterre = dañotb - dañoae2;
                for (int i = 1; i <= b.getRazaPar().GetU().getnr(); i++)
                {
                    if (b.getRazaPar().GetU().getunidad(i).Tipodedaño.Equals("aereo"))
                    {
                        if (dañoae2 > b.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañoae2 -= b.getRazaPar().GetU().getunidad(i).Vida;
                            b.getRazaPar().GetU().EliminarUnidad(b.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            b.getRazaPar().GetU().getunidad(i).CambiaVida(b.getRazaPar().GetU().getunidad(i).Vida - dañoae2);
                        }
                    }
                    else
                    {
                        if (dañotropterre > b.getRazaPar().GetU().getunidad(i).Vida)
                        {
                            dañotropterre -= b.getRazaPar().GetU().getunidad(i).Vida;
                            b.getRazaPar().GetU().EliminarUnidad(b.getRazaPar().GetU().getunidad(i));
                        }
                        else
                        {
                            b.getRazaPar().GetU().getunidad(i).CambiaVida(b.getRazaPar().GetU().getunidad(i).Vida - dañotropterre);
                        }

                    }

                }
                Console.WriteLine("\nGana el jugador:" + b.getnick());
                Console.WriteLine("\nGana la raza:" + b.getRazaPar().getNomRai());
                Console.WriteLine("\nTropas Sobrevivientes:\n");
                b.getRazaPar().GetU().MostrarTodasLasTropas();
                return pganador2;
            }
        }
        public int getnp()
        {
            return np;
        }
        public Participante getparticipantes(int i)
        {
            return participantes[i];
        }
        public string GetFecha() { return Fecha; }
        public Torneo(string nombre) { }
        public void eliminarCompetidor(Participante a, Participante b,Participante c)
        {
            if (a.getnick().Equals(c.getnick()))
            {
                Console.WriteLine("El participante:" + a.getnick() + " hizo trampa por lo que el participante:" + b.getnick() + " es el ganador");  
            }
            else 
            {
                Console.WriteLine("El participante:" + b.getnick() + " hizo trampa por lo que el participante:" + a.getnick() + " es el ganador");
            }
        }
        
        
        public static bool operator == (Torneo a, Participante b)
        {
            Console.WriteLine("Participante :"+i);
            i++;
            Console.WriteLine("El nick del jugador es:"+b.getnick());
            Console.WriteLine("El identificador del jugador:"+b.getidentificador());
            a.GetFecha();
            return true;
        }
        public static bool operator !=(Torneo a, Participante b)
        {

            Console.WriteLine("El ganador de la ronda es:" + b.getnick());
            Console.WriteLine("El nick del ganador de la ronda es:" + b.getidentificador());
            a.GetFecha();
            return true;
        }
        public void mostrandoganador(Participante a) 
        {
            Console.WriteLine("El ganador de la ronda es:"+a.getnick());
        }
        public void mostrarParticipantes() 
        {
            for (int i=1;i<=getnp();i++) 
            {
                Console.WriteLine("Mostrando participante:"+i);
                Console.WriteLine(getparticipantes(i).getnick());
                Console.WriteLine(getparticipantes(i).getidentificador()+"\n");
            }
        }
        
        public void obtenerFecha() 
        {
            Console.WriteLine("Fecha:"+t + "/" + "" + y + "/" + "" + z + "");
            t++;
        }




    }   
}
