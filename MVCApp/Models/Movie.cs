using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [StringLength (60,MinimumLength =3)] //Validaciones
        [Required]
        public string? Title { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength (30)]
        public string? Gender { get; set; }
        [Column(TypeName = "decimal(18,2)")] //Precio con dos decimales

        [Range(1,100)]
        [Required]
        [StringLength (5)]

        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]

        public string? Rating { get; set; }


    }
}
