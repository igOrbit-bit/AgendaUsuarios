using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Model
{
    public class UsuarioModel
    {
        private static List<Usuario> usuarios = new List<Usuario>();
    
        public void addUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
           
        }
        public List<Usuario> getUsuarios()
        {
            return usuarios;
            
        }
    }
}
