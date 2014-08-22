using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;
using dllConnection;
using t_botones;

namespace MenuDinamico.Resources
{
    public class Crear_boton
    {
        private System.Windows.Forms.Button[] btnVirtuales = new System.Windows.Forms.Button[9];
        private ArrayList arAreas;

        public void ActualizarTabla()
        {
            arAreas = new D_GetObtons().Obtener_areas();
            if (arAreas == null) MessageBox.Show("Error Array Nulo");
            for (int cont = 0; cont < arAreas.Count; cont++)
            {
                foreach (t_boton dato in arAreas)
                {
                    Nuevo_boton(dato.area, dato.nombre_area, cont);
                }

            }
        }
        public System.Windows.Forms.Button[] Nuevo_boton(String sArea, String sNomArea, int cont = 0)
        {
            btnVirtuales[cont] = new Button();
            btnVirtuales[cont].Name = sArea;
            btnVirtuales[cont].Text = sArea + " - " + sNomArea;
            btnVirtuales[cont].Location = new System.Drawing.Point(50, 180 + cont * 205);
            btnVirtuales[cont].Height = 200;
            btnVirtuales[cont].Width = 400;
            btnVirtuales[cont].BackColor = Color.FromArgb(75, 0, 130);
            btnVirtuales[cont].FlatStyle = FlatStyle.Flat;
            btnVirtuales[cont].FlatAppearance.BorderColor =
            btnVirtuales[cont].FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 104, 238);
            btnVirtuales[cont].Font = new Font("Arial", 18);
            btnVirtuales[cont].ForeColor = Color.FromArgb(255, 255, 255);
            return btnVirtuales;
        }
    }
}
