using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBiblioteca.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Autor!")]
        public string Autor {  get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a editora!")]
        public string Editora {  get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a data!")]
        [Display(Name ="Ano de publicação")]
        public int AnoPublicacao { get; set; }
        public int Paginas { get; set; }

        public Categoria Categoria { get; set; }
    }
    public enum Categoria
    {
        [Display(Name ="Ficção Científica")]
        FicçãoCientifica,
        Romance,
        História,
        Biografia,
        Educação,
        Autoajuda
    }
}
