using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Participante
    {
        private string nick;
        private string idetificador;
        private Raza razajugador;
        public Participante() 
        {
            nick = "golozo124";
            idetificador = "4444444";
            razajugador = new Raza();
        }
        public Participante(string nick, string identificado, Raza razajugador) 
        {
            this.nick = nick;
            this.idetificador = identificado;
            this.razajugador = razajugador;
        }
        public Raza getRazaPar() {return razajugador; }
        public void leer() 
        {
            Console.Write("Ingrese el nick del participante:");
            nick = Console.ReadLine();
            Console.Write("Ingrese el idetificador:");
            idetificador = Console.ReadLine();
            Raza aleactoria = new Raza();
            razajugador=aleactoria.EscogerRazaAleactoria();
        }
        public void mostrar() 
        {
            Console.WriteLine("Nick:"+nick);
            Console.WriteLine("Identificador:"+idetificador);
            Console.WriteLine("Raza:"+razajugador);
        }
        public string getnick() 
        {
            return nick;
        }
        public string getidentificador() { return idetificador; }
        
        public void setRaza(Raza a) { razajugador =a; }
        
    }
}
