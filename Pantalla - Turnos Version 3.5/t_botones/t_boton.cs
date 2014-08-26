using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_botones
{
    public class t_boton
    {
   
        private String id_area;
        private String nom_area;
        private byte[] byte_Image; 

        public t_boton()
        {
            this.id_area  = String.Empty;
            this.nom_area = String.Empty;
            this.byte_Image = null;
        }

        public String area
        {
            get {return id_area;}
            set {id_area = value;}
        }

        public String nombre_area 
        {
            get {return nom_area;}
            set { nom_area = value;}
        }

        public byte[] foto_area
        {
            get { return byte_Image; }
            set { byte_Image = value;}
        }

    }
}

