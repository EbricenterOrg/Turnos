using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using csNotificaciones;
using t_botones;

namespace MenuDinamico
{
    public class D_Boton:dllConnection.dllConnectionRemote
    {
        private String sQuery = "SELECT id_area,area_nom, foto FROM tabm_area";

        public D_Boton() : base()
        {

        }

        public ArrayList Obtener_areas()
        {
            ArrayList arrayNombre_Areas = new ArrayList();

            try
            {
                Connection.Open();
                MySqlCommand SQLcmd = new MySqlCommand(sQuery,Connection);
                MySqlDataReader dataReader = SQLcmd.ExecuteReader();
                
                while(dataReader.Read())
                {
                    t_boton rowBotones = new t_boton();
                    rowBotones.area = dataReader["id_area"] + "";
                    rowBotones.nombre_area = dataReader["area_nom"] + "";
                    rowBotones.foto_area = (byte[])dataReader["foto"];
                    arrayNombre_Areas.Add(rowBotones);
                }  
                dataReader.Close();
            }  catch (Exception ei)
            {
                Console.WriteLine(ei.Message);
                Notificacion.mostrarVentana("", ei.ToString(), Notificacion.Imagen.Advertencia, 15);
            }

            this.CloseConnection();
            return arrayNombre_Areas;

        }

    }
}
