using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserRegister.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        //Nome do Usuário
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome obrigatório.", AllowEmptyStrings = false)]
        public string FullName { get; set; }

        //Email do usuário
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email obrigatório.", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Email Inválido.")]
        public string Mail { get; set; }

        //Número de telefone
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\d{2,3}\s\d{8,9}", ErrorMessage = "Número Inválido.")]
        public string Phone { get; set; }

        //Senha criptografada
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha obrigatória.", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "A senha precisa conter ao menos 6 caracteres.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}