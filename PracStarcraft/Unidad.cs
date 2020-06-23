using System;
using System.Collections.Generic;
using System.Text;

namespace PracStarcraft
{
    class Unidad
    {
        private String _nombre;
        private int _DañoEspecifico;
        private int _vida;
        private int _costodeproduccionmineral;
        private int _costedeproduccionGasVEspeno;
        private String _tipodedaño;

 
        public Unidad() 
        {
            _nombre = "marine";
            _DañoEspecifico = 55;
            _vida = 100;
            _costodeproduccionmineral = 300;
            _costedeproduccionGasVEspeno = 10;
            _tipodedaño = "terrestre";
        }
        public Unidad(string nombre,int dañoespecifico,int vida,int costodeproduccionmineral,int costedeproducciongasvespeno,string tipodedaño) 
        {
            _nombre = nombre;
            _DañoEspecifico =dañoespecifico;
            _vida =vida;
            _costodeproduccionmineral = costodeproduccionmineral;
            _costedeproduccionGasVEspeno = costedeproducciongasvespeno;
            _tipodedaño = tipodedaño;
        }
        public void leer() 
        {
            Console.WriteLine("Ingrese el nombre de la unidad");
            _nombre = Console.ReadLine();
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int DañoEspecifico { get => _DañoEspecifico; set => _DañoEspecifico = value; }
        public int Vida { get => _vida; set => _vida = value; }
        public string Tipodedaño { get => _tipodedaño; set => _tipodedaño = value; }
        public int Costodeproduccionmineral { get => _costodeproduccionmineral; set => _costodeproduccionmineral = value; }
        public int CostedeproduccionGasVEspeno { get => _costedeproduccionGasVEspeno; set => _costedeproduccionGasVEspeno = value; }

        public void CambiaVida(int i) { Vida=i; }

        public int getDaño() { return _DañoEspecifico; }
        public string getTipoDeDaño() { return _tipodedaño; }




    }
}
