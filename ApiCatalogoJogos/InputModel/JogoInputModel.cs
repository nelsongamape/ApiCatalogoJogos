using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome do jogo deve conter entre 2 e 50 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 e 50 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 9999, ErrorMessage = "O preço deve ser de no mínimo 1 real")]
        public double Preco { get; set; }
    }
}
