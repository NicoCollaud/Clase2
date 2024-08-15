using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Guardia
    {
        public Policia OficialAsignado { get; set; }       
        public int HoraDesde {  get; set; }
        public int MinutosDesde {  get; set; }
        public int HoraHasta {get {
                int minutos = HoraDesde * 60 + MinutoDesde + CantidadMinutos;
                return minutos / 60;
            } }
            
        public int MinutoDesde {  get; set; }
        public int CantidadMinutos {  get; set; }

        public Guardia() 
        { 
          
        }

        public void AsignarPolicia(Policia poli,int hora,int minuto,int cantidadMinutos)
        {
            OficialAsignado = poli;
            HoraDesde = hora;
            MinutoDesde = minuto;
            CantidadMinutos = cantidadMinutos;


        }

    }
}
