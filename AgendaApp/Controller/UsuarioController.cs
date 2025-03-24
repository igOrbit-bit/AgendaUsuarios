using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Model;




namespace AgendaApp.Controller
{
    internal class UsuarioController
    {
        private UsuarioModel model = new UsuarioModel();
        
        public string AdicionarUsuario(string nome, string whatsapp, string email)
        {

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(whatsapp) || string.IsNullOrEmpty(email))
            {
                return "Preencha todos os campos";
            }
                
            if (!long.TryParse(whatsapp, out long whatsappValidado))
            {
                return "Numero invalido";
            }

            Usuario usuario = new Usuario(nome, whatsappValidado, email);
            model.addUsuario(usuario);
            return "Usuario adicionado com sucesso";
        }
        public List<Usuario> GetUsuarios()
        {
            return model.getUsuarios();
        }


    }
    }

