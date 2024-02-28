using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{

    public class UserInfo{
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad Zorunlu")]
        public  string? Name { get; set; }
        [Required(ErrorMessage ="Telefon Zorunlu")]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email Zorunlu")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım Durum Zorunlu")]
        public bool? WillAttend { get; set; }

    }
}