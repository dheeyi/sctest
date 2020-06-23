using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Raza
    {
        private int RecursosTotalesDeMineral = 20000;
        private int RecursosTotalesGasVespeno = 10000;
        private String NomRaz;
        private int ne;
        private String EstruPrin;
        private String EstrucTerr;
        private String EstrucArea;
        private int RecursosIni;
        private int RecursosFin;
        private Unidades Unidades;
       
        //Constructores
        public Raza(string nomRaz, int ne, string estruPrin, string estrucTerr, string estrucArea, int RecursosIni, int RecursosFin, Unidades[] Unidad)
        {
            this.NomRaz = nomRaz;
            this.ne = ne;
            this.EstruPrin = estruPrin;
            this.EstrucTerr = estrucTerr;
            this.EstrucArea = estrucArea;
            this.RecursosIni = RecursosIni;
            this.RecursosFin = RecursosFin;
            Unidades = new Unidades();
        }      
        public Raza() //Terran
        {
            NomRaz = "Terran";
            ne = 1;
            EstruPrin = "Depot";
            EstrucTerr = "Barracks";
            EstrucArea = "Starport";
            RecursosIni = 1000;
            RecursosFin = 0;
            Unidades = new Unidades();
        }
        public Raza(string raza)//Zerg
        {
            NomRaz = "Zerg";
            ne = 1;
            EstruPrin = "hive";
            EstrucTerr = "Hive";
            EstrucArea = "Hive";
            RecursosIni = 1000;
            RecursosFin = 0;
            Unidades = new Unidades("Zerg");
        }
        public Raza(int i)//Protos
        {
            NomRaz = "Protos";
            ne = i;
            EstruPrin = "Pylow";
            EstrucTerr = "Gateway";
            EstrucArea = "StarGate";
            RecursosIni = 1000;
            RecursosFin = 0;
            Unidades = new Unidades(5);
        }
        
        public void AumRec()
        {
            Console.WriteLine("Cuantos recursos quiere recolectar");
            int recursos = int.Parse(Console.ReadLine());
            RecursosIni = RecursosIni + recursos;
            RecursosTotalesDeMineral -= recursos;
            RecursosTotalesGasVespeno -= recursos;
        }
        public void mostrar()
        {
            Console.WriteLine("Raza: " + NomRaz + "\nEstructura Principal:" + EstruPrin + "\nEstructuras principales construidas:" + ne + "\nEstructura Terrestres:" +  //n
                EstrucTerr + "\nEstructuras Aereas:" + EstrucArea + "\nRecursosIni:" + RecursosIni + "\nRecursosFin:" + RecursosFin
                + "\nRecursos totales a recolectar de Minerales:" + RecursosTotalesDeMineral + "\nRecursos totales a recolectar de Gas Vespeno:" + RecursosTotalesGasVespeno
                );
            Unidades.MostrarTodasLasTropas();
        }
        
        
        public static Raza operator ++(Raza d)
        {
            if (d.Unidades.getnr() % 11 == 0 && d.ne < d.Unidades.getnr() / 11)
            {
                Console.WriteLine("!!!No puedes construir mas unidades--->Necesitas mas estructuras Principales");
            }
            else 
            {
                Console.WriteLine("!!! Puedes construir mas unidades");
            }
            return d;
        }
        public void AunEstPri(int x)
        {
            ne = ne + x;
            for (int i = 1; i <= x; i++)
            {
                RecursosIni = RecursosIni - 500;

                RecursosFin = RecursosFin + 500;
                
                RecursosTotalesDeMineral -= 500;
            }

        }

        public Raza EscogerRazaAleactoria() 
        {
            Raza[] razas = new Raza[] { new Raza(),new Raza("Zerg"),new Raza(1)};
            Random r1 = new Random();
            int numeroaleactorio = r1.Next(0,3);
            Raza razaelegida = razas[numeroaleactorio];
            Console.WriteLine("Jugara con la raza:" + razaelegida.getNomRai()+"\n");
            return razaelegida;
        }
        public void MosRecIni()
        {
            Console.WriteLine("Recursos Iniciales:" + RecursosIni);
            Console.WriteLine("Recursos Finales:" + RecursosFin);
        }

        public void MosUni(Raza a, Raza b)
        {
            int c = a.GetU().getnr();
            int d = b.GetU().getnr();
            int e = this.GetU().getnr();
            int[] numeros = new int[] { c, d, e };
            int max = c;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }
            }
            if (max == c)
            {
                Console.WriteLine("la raza que tiene mas tropas es:" + a.getNomRai());
            }
            else if (max == d)
            {
                Console.WriteLine("la raza que tiene mas tropas es:" + b.getNomRai());
            }
            else
            {
                Console.WriteLine("la raza que tiene mas tropas es:" + this.getNomRai());
            }
        }
        public Unidades GetU() { return Unidades; }
        public void setUnidades(Unidades u) { Unidades = u; }
        public int getReToMi() { return RecursosTotalesDeMineral; }
        public int getToGaVe() { return RecursosTotalesGasVespeno; }
        public string getNomRai() { return NomRaz; }
        public int getNe() { return ne; }
        public int getRecIni() { return RecursosIni; }
        public void setRecIni(int i) { RecursosIni = i; }
        public void setRecFin(int i) { RecursosFin = i; }
        public int getRecFin() { return RecursosFin; }

    }
       
        




















}
