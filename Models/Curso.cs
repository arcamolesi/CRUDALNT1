using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDALNT1.Models
{
    [Table("curso")]
    public class Curso
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Display(Name = "Descrição: ")]
        [StringLength(25, ErrorMessage = "Tamanho 25 caracteres")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string descricao { get; set; }


        [Display(Name = "Área: ")]
        [StringLength(15, ErrorMessage = "Tamanho 15 caracteres")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string area { get; set; }

        [Display(Name = "Sigla: ")]
        [StringLength(3, ErrorMessage = "Tamanho 3 caracteres")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string sigla { get; set; }

    }

}