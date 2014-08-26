using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuDinamico
{
    public class N_Reloj
    {

        public String hora()
        {
            String sHora = String.Empty;
            int iHora = DateTime.Now.Hour;
            if (iHora < 10) { sHora = "0" + iHora.ToString(); } else { sHora = iHora.ToString(); }
            return sHora;
        }
        public String min() 
        {
             String sMin = String.Empty;
            int iMin = DateTime.Now.Minute;
            if (iMin < 10) { sMin = "0" + iMin.ToString(); } else { sMin = iMin.ToString(); }
            return sMin;
        }

        public String fecha()
        {
            String sFecha = DateTime.Now.Day + " de " + getMonth(DateTime.Now.Month) + " de " + DateTime.Now.Year;
            return sFecha;
        }

        public String DiaSemana() 
        {
            String sDiaSemana = String.Empty;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday: sDiaSemana = "Lunes";break;
                case DayOfWeek.Tuesday: sDiaSemana = "Martes";break;
                case DayOfWeek.Wednesday: sDiaSemana = "Miercoles";break;    
                case DayOfWeek.Thursday: sDiaSemana = "Jueves";break;   
                case DayOfWeek.Friday: sDiaSemana = "Viernes";break;    
                case DayOfWeek.Saturday: sDiaSemana = "Sabado";break;
                case DayOfWeek.Sunday: sDiaSemana = "Domingo"; break;
            }
            return sDiaSemana; 
        }

        protected String getMonth(int Mes)
        {
            String sMes = "None";
            switch (Mes) 
            {
                case 0: sMes = "Enero";     break;
                case 1: sMes = "Febrero";   break;
                case 2: sMes = "Marzo";     break;
                case 3: sMes = "Abril";     break;
                case 4: sMes = "Mayo";      break;
                case 5: sMes = "Junio";     break;
                case 6: sMes = "Julio";     break;
                case 7: sMes = "Agosto";    break;
                case 8: sMes = "Septiembre";break;
                case 9: sMes = "Octubre";   break;
                case 10: sMes = "Noviembre"; break;
                case 11: sMes = "Diciembre"; break; 
            }
            return sMes;
        }

    }
}
