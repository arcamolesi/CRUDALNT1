using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDALNT1.Models
{
    [Table("curso")]
    public class Curso {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Descrição: ")]
        [StringLength(25, ErrorMessage ="campo tem no máximo 25 caracteres")]
        [Required(ErrorMessage ="Campo obrigatório...")]
        public string descricao { get; set; }   

        [Display(Name = "Área: ")]
        [StringLength(15, ErrorMessage ="campo tem no máximo 15 caracteres")]
        [Required(ErrorMessage ="Campo obrigatório...")]
        public string area { get; set; }   

        [Display(Name = "Sigla: ")] 
        [StringLength(3, ErrorMessage ="campo tem no máximo 3 caracteres")]
        [Required(ErrorMessage ="Campo obrigatório...")]        
        public string sigla { get; set; }
        
    }

}