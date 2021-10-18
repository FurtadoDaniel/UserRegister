using System;
using System.Collections.Generic;

namespace UserRegister.Models
{
    public class User
    {
        //HASH
        public int ID { get; set; }

        //Nome do Usuário
        public string FullName { get; set; }

        //Email do usuário
        public string Mail { get; set; }

        //Número de telefone
        public string Phone { get; set; }

        //Senha criptografada
        public string Password { get; set; }
    }
}