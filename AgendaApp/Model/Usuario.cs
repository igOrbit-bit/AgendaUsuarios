using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Model
{
    public class Usuario
    {
        public string Nome { get; set; } 
        public long Whatsapp { get; set; }
        public string Email { get; set; }

        public Usuario(string nome, long whatsapp, string email)
        {
            Nome = nome;
            Whatsapp = whatsapp;
            Email = email;
        }
    }
}
