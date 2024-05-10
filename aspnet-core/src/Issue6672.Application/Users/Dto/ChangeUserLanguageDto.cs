using System.ComponentModel.DataAnnotations;

namespace Issue6672.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}