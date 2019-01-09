using System.ComponentModel.DataAnnotations;


namespace Kursach.Models
{
    public class ContentViewModel
    {
        [Required(ErrorMessage = "Введите тип спорта")]
        public byte[] ImagePath { get; set; }
        [Required(ErrorMessage = "Введите детали о вашей статье")]
        public string SportDetail { get; set; }

        [Required(ErrorMessage = "Введите вашу статью")]
        public string FullDetail { get; set; }

        [Required(ErrorMessage = "Введите заглавие статьи")]
        public string Title { get; set; }

        public int IdSport { get; set; }
        public TypeSportViewModel TypeSport { get; set; }
    }
}