using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCallCenter.Bean
{
    class Usuario
    {
        #region Constructor
        public Usuario() { }

        public Usuario(int id, string usuario, string password)
        {
            this.id = id;
            User = usuario;
            Password = password;
        }
        #endregion

        #region Propiedades
        public int id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }


        public bool Valido { get; set; }
        #endregion


        #region Métodos

        #endregion

    }
}
