using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 100")]
        [MinLength(2, ErrorMessage = "O valor mínimo é 2")]
        public string Nome { get; set; }

        [Range(10, 1000)]
        [Required(ErrorMessage = "Preencha o valor")]
        public decimal Valor { get; set; }

        public bool Gratuito { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MaxLength(500, ErrorMessage = "O valor máximo é 1000")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public Evento()
        {
            IdEvento = Guid.NewGuid();
        }

    }
}
