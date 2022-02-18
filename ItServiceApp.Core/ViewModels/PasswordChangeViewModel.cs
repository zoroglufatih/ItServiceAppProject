using System.ComponentModel.DataAnnotations;

namespace ItServiceApp.Core.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Required(ErrorMessage = "Eski Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Eski Şifre")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Yeni Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Yeni Şifre")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir.")]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni Şifre tekrar")]
        [Compare(nameof(NewPassword), ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
