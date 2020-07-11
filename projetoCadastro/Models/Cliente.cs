using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoCadastro.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(70)")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(11)")]
        [Display(Name = "C.P.F.")]
        public string CPF { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column(TypeName = "varchar(120)")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
