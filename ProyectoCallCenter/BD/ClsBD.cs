using System;
using System.Collections.Generic;
using System.Text;
using ProyectoCallCenter.Bean;

namespace ProyectoCallCenter.BD
{
    class ClsBD
    {
        internal List<Usuario> getUsuarios()
        {
            List<Usuario> lstUsuarios = new List<Usuario>();

            lstUsuarios.Add(new Usuario(1,"jeremy", "123456"));
            lstUsuarios.Add(new Usuario(2,"admin", "admin"));
            lstUsuarios.Add(new Usuario(3,"root", "root"));

            return lstUsuarios;
        }

    }
}
