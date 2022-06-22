using System.ComponentModel.DataAnnotations;

namespace WebMVCComDDD.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        [MaxLength(30, ErrorMessage = "Tamanho máximo de 30 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo Marca é obrigatório")]
        [Display(Name = "Marca")]
        [MaxLength(20, ErrorMessage = "Tamanho máximo de 20 caracteres")]
        public string Marca { get; set; }
    }
}
