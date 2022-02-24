using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUD.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("Status")]
        [Display(Name = "Status Ativo")]
        public bool Status { get; set; }

        [Column("Dt_cad")]
        [Display(Name = "Data de Cadastramento")]
        public DateTime Dt_cad { get; set; }
    }
}
