using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    class product
    {
        
        public string Nome;
        public string Email;

        
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public product(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public override string ToString()
        {
            return Nome + " , " + Email;
               
        }
    }
}
