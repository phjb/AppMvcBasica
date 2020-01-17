using System;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200,ErrorMessage="O campo {0} precisa ter entre {2} e {1} caracteres",MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
         [StringLength(1000,ErrorMessage="O campo {0} precisa ter entre {2} e {1} caracteres",MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
         [StringLength(200,ErrorMessage="O campo {0} precisa ter entre {2} e {1} caracteres",MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }

        /* Relação 1:1 um produto possui um fornecedor */
        public Fornecedor Fornecedor { get; set; }
    }
}