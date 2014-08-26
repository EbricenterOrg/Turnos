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
using System.IO;

namespace MenuDinamico
{
    class N_Boton
    {

        private System.Windows.Forms.Button[] btnVirtuales = new System.Windows.Forms.Button[9];
        private ArrayList arAreas;

        public System.Windows.Forms.Button[] ActualizarTabla()
        {
            arAreas = new D_Boton().Obtener_areas();
            if (arAreas == null) MessageBox.Show("Error Array Nulo");
            int cont = 0;
                foreach (t_boton dato in arAreas)
                {
                    Nuevo_boton(dato.area, dato.nombre_area,dato.foto_area, cont);
                    cont++;
                }
            
            return btnVirtuales;
        }

        public void Nuevo_boton(String sArea, String sNomArea,byte[] imagen, int cont = 0)
        {
            btnVirtuales[cont] = new Button();
            btnVirtuales[cont].Name = sArea;
            btnVirtuales[cont].Text = "     "+sArea + " - " + sNomArea;
            btnVirtuales[cont].Location = new System.Drawing.Point(get_pos_x(cont), 170 + get_pos_y(cont) * 180);
            btnVirtuales[cont].Height = 170;
            btnVirtuales[cont].Width = 250;
            btnVirtuales[cont].BackColor = put_color(cont);
            btnVirtuales[cont].FlatStyle = FlatStyle.Flat;
            btnVirtuales[cont].FlatAppearance.BorderColor = put_color(cont);
            btnVirtuales[cont].Font = new Font("Arial", 12);
            btnVirtuales[cont].ForeColor = Color.FromArgb(255, 255, 255);
            Carga_Imagen(imagen,cont);
            btnVirtuales[cont].TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVirtuales[cont].TextAlign = ContentAlignment.MiddleRight;
          
        }

        protected void Carga_Imagen(byte[] imagen, int cont) 
        {
            if (imagen != null)
            {
                MemoryStream MemoryStream = new MemoryStream(imagen);
                Bitmap BitImage = new Bitmap(MemoryStream);
                btnVirtuales[cont].Image = BitImage;  
            }

        }

        protected Color put_color(int cont =0)
        {
            Color ColorBoton = Color.FromArgb(75, 0, 130 ); 
            switch (cont)
            {
                case 0: ColorBoton = Color.FromArgb(0, 153, 255); break; //Color Celeste
                case 1: ColorBoton = Color.FromArgb(75, 0, 130); break;  //Color Purpura    
                case 2: ColorBoton = Color.FromArgb(255, 102,0); break;  //Color Naranja
                case 3: ColorBoton = Color.FromArgb(0,119,0); break;     //Color Verde Oscuro
                case 4: ColorBoton = Color.FromArgb(0, 153, 255); break; //Color Celeste
                case 5: ColorBoton = Color.FromArgb(204, 0, 0); break;   //Color Rojo Carnesi
                case 6: ColorBoton = Color.FromArgb(255, 102, 0); break; //Color Naranja
                case 7: ColorBoton = Color.FromArgb(0, 221, 0); break;   //Color Verde Claro
                case 8: ColorBoton = Color.FromArgb(255, 0, 153); break; //Color Purpura
            }
            return ColorBoton;
        }

 

        protected int get_pos_x(int cont=0)
        {
            int iPos_x = 0;
            if (cont < 3){ iPos_x = 100;}
            else
            {
                if (cont < 6) { iPos_x = 360; }
                else
                {
                    iPos_x = 620;
                }
            }
            return iPos_x;
        }

        protected int get_pos_y(int cont = 0)
        {
            int iPos_y = 0;
            switch (cont)
            {
                case 0: iPos_y = 0; break;
                case 1: iPos_y = 1; break;
                case 2: iPos_y = 2; break;
                case 3: iPos_y = 0; break;
                case 4: iPos_y = 1; break;
                case 5: iPos_y = 2; break;
                case 6: iPos_y = 0; break;
                case 7: iPos_y = 1; break;
                case 8: iPos_y = 2; break;
            }
            return iPos_y;
        }
    }
}
