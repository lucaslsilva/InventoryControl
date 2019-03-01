using System.ComponentModel.DataAnnotations;

namespace InventoryControl.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}