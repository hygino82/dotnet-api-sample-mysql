using System.ComponentModel.DataAnnotations;

namespace MySqlAPI.Model
{
    public class Estado
    {
        [Key]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo sigla é obrigatório")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório"!)]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }
    }
}
