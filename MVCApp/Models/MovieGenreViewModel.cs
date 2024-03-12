using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace MVCApp.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; } //variables de tipo lista de la clase movie a la vista se le llama Movies
        public SelectList? Genders { get; set; } //variabkes de tipo lista se genera en nombre plural
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
