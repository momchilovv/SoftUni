#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TextSplitterApp.Models
{
    public class TextViewModel
    {
        [Required(ErrorMessage = "The text field is required!")]
        [StringLength(30, MinimumLength = 2,
            ErrorMessage = "The text field must be a string with a minimum length of 2 and maximum length of 30.")]
        
        public string Text { get; set; }

        public string SplitText { get; set; }
    }
}