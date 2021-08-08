using System;
using System.Collections.Generic;
using System.Text;
using ProyectoCallCenter.BD;
using ProyectoCallCenter.Bean;

namespace ProyectoCallCenter.Dao
{
    class daoUsuario
    {
        ClsBD clsBD = new ClsBD();
        int identity;
        List<Usuario> lstUsuarios;
        public daoUsuario()
        {
            lstUsuarios = clsBD.getUsuarios();
            identity = lstUsuarios.Count;
        }

        internal void ValidaLogin(Usuario Usuario)
        {
            foreach (Usuario usuario in lstUsuarios)
                if (usuario.User == Usuario.User && usuario.Password == Usuario.Password)
                {
                    Usuario.id = usuario.id;
                    Usuario.User = usuario.User;
                    Usuario.Password = usuario.Password;
                    Usuario.Valido = true;
                    return;
                }
        }
        internal List<Usuario> getUsuarios()
        {
            return lstUsuarios;
        }
    }
}
