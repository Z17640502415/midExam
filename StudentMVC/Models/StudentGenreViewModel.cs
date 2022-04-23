using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentMVC.Models
{
    public class StudentGenreViewModel
    {
        public List<Students>? students { get; set; }
        public SelectList? Sex { get; set; }
        public string? StudentGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
