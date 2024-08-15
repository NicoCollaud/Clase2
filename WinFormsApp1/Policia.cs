using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Policia
    {
        public int Dni {  get; private set; }
        public string Nombre {  get; private set; }
        public int NumeroPlaca {  get; private set; }   

        public Policia(int dni, string nombre, int numeroPlaca)
        {
            Dni = dni;
            Nombre = nombre;
            NumeroPlaca = numeroPlaca;
        }

        public string VerDatos()
        {
            return Dni+" "+Nombre+ " "+ NumeroPlaca.ToString();
        }
    }
}
