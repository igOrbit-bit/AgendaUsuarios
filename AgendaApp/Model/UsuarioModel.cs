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
        //1️⃣ Armazena os produtos em uma lista(products).
        public void addUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
            //2️⃣ Permite adicionar novos produtos com addProduct().
        }
        public List<Usuario> getUsuarios()
        {
            return usuarios;
            //3️⃣ Permite recuperar a lista de produtos com getProducts().
        }
    }
}
