using System;

namespace PracStarcraft
{
    class Program
    {
        static void Main(string[] args)
        {
            // a) PRIMERA PARTE:CREACION DE LAS RAZAS
            
            //instanciacion de las clases
            
            Raza Terran = new Raza();
            Raza Zerg = new Raza("Zerg");
            Raza Protos = new Raza(1);
            
            //mostrar estructuras y unidades
            
            Terran.mostrar();
            Zerg.mostrar();
            Protos.mostrar();

            Console.WriteLine("\n\n");
            //Mostrar recursos iniciales y posteriores de cada raza
            /*
            Terran.MosRecIni();
            Zerg.MosRecIni();
            Protos.MosRecIni();
            Console.WriteLine("\n\n");
            Terran.GetU().crearUnidad(Terran);
            Terran.GetU().crearUnidad(Terran);
            Zerg.GetU().crearUnidad(Zerg);
            Protos.GetU().crearUnidad(Protos);
            Console.WriteLine("\n\n");
            Terran.MosRecIni();
            Zerg.MosRecIni();
            Protos.MosRecIni();

            //mostrar que raza tiene mas unidades
            
            Terran.MosUni(Zerg,Protos);
            Console.WriteLine("\n\n");

            //mostrar metodo que agrege unidades
            Unidad marine = new Unidad("marine", 10, 100, 50, 75, "terrestre");
            Unidad Zerling = new Unidad("zerling", 10, 100, 50, 75, "terrestre");
            Unidad Zealot = new Unidad("zealot", 10, 100, 50, 75, "terrestre");
            Terran.GetU().AñadirUnidad(marine);
            Zerg.GetU().AñadirUnidad(Zerling);
            Protos.GetU().AñadirUnidad(Zealot);

            //mostrar metodo proporcional
            Terran++;
            Zerg++;
            Protos++;*/


            //b)SEGUNDA PARTE BATALLAS


            Batalla b1 = new Batalla();
            Raza Ganadora=b1.Peleen(Terran,Zerg);
            Raza Ganadora2=b1.Peleen(Protos,Zerg);
            Raza Ganadora3=b1.Peleen(Terran,Terran);

            //mostrar las razas que se enfentraron en la fecha

            b1.MostrarLucha(Terran, Terran,"07/05/2000");

            //mostrar las razas que ganaron

            Console.WriteLine("Gano la batalla:"+Ganadora.getNomRai());
            Console.WriteLine("Gano la batalla:"+Ganadora2.getNomRai());
            //Console.WriteLine("Gano la batalla:"+Ganadora3.getNomRai());

            //mostrar unidades

            b1.mostrarTropas(Terran);
            b1.mostrarTropas(Zerg);
            b1.mostrarTropas(Protos);

            //b1.Peleen(Terran,Zerg);
            //b1.Peleen(Zerg, Zerg);


            //c)TORNEOS


            Torneo Elimininatorias = new Torneo(4);
            
            Elimininatorias.leerTorneo();
            
            //mostrando nick de participantes
            
            Elimininatorias.mostrarParticipantes();
            
            //mostrando ganadores

            Participante p1 = Elimininatorias.IniciaTorneo(Elimininatorias.getparticipantes(1), Elimininatorias.getparticipantes(2));
            Elimininatorias.mostrandoganador(p1);
            Participante p2 = Elimininatorias.IniciaTorneo(Elimininatorias.getparticipantes(3), Elimininatorias.getparticipantes(4));
            Elimininatorias.mostrandoganador(p2);
            Participante p3=Elimininatorias.IniciaTorneo(p1,p2);
            Elimininatorias.mostrandoganador(p3);

            //invalidando participante

            Elimininatorias.eliminarCompetidor(p1,p2,p3);
            
            //sobrecargando ==

            if (Elimininatorias == Elimininatorias.getparticipantes(1)) ;
            if (Elimininatorias == Elimininatorias.getparticipantes(2)) ;
            if (Elimininatorias != p1) ;
            if (Elimininatorias == Elimininatorias.getparticipantes(3)) ;
            if (Elimininatorias == Elimininatorias.getparticipantes(4)) ;
            if (Elimininatorias != p2) ;
            Console.WriteLine("El ganador de la ronda final es:");
            if (Elimininatorias != p3) ;

           
            Console.ReadLine();
        }
    }
}
