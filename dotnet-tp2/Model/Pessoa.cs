using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_tp2.Model
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A idade é obrigatória.")]
        [Range(0, 150, ErrorMessage = "A idade deve estar entre 0 e 150.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato inválido de CPF.")]
        public string CPF { get; set; }

        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
    }


}

