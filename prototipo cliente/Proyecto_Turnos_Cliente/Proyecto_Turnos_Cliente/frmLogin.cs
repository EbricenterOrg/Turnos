/*Autor: "Jaime Muñoz"
 *Fecha " 31 Julio 2014"
 *Comentario: "Este form maneja el login"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 7 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Turnos_Cliente
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //If que vadila si los textbox estan vacios
            if (txtNombre.Text.Equals("") || txtContrasena.Text.Equals(""))
            {
                //Agrega texto a un lbl el cual da un error al estar vacios
                lblError.Text = "Error Ingrese Nombre y contraseña";
            }
            else//Se procede a entrar
                {
                    
                    lblError.Text = "";
                    frmPrincipal frmPrin2 = new frmPrincipal("prueba");
                    frmPrin2.Show();
                   
                    /*switch (lblNombre.Text)
                        { 
                        case "administrador":
                                        frmPrincipal frmPrin = new frmPrincipal();
                                        frmPrin.Show();
                                            break;
                        case "reparacion":
                                        frmPrincipal frmPrin1 = new frmPrincipal();
                                        frmPrin1.Show();
                                            break;
                        case "cliente":
                                        frmPrincipal frmPrin2 = new frmPrincipal();
                                        frmPrin2.Show();
                                            break;                    
                        }*/
                }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
