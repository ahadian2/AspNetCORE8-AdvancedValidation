using System.ComponentModel.DataAnnotations;

namespace AdvancedValidation.Models
{
    public class UserModel
    {
        [Display(Name = "شماره یکتا")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد")]
        public string? Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد")]
        [EmailAddress(ErrorMessage = "قالب {0} اشتباه است")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Display(Name = "سن")]
        [Range(18, 70, ErrorMessage = "فیلد {0} باید عددی بین {1} و {2} باشد")]
        public int Age { get; set; }
        [Display(Name = "شماره تلفن")]
        [RegularExpression("^0[0-9]{2,}[0-9]{7,}$", ErrorMessage = "قالب {0} اشتباه است")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "شماره موبایل")]
        [RegularExpression("09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "قالب {0} اشتباه است")]
        public string? MobileNumber { get; set; }
        [Display(Name = "توضیحات")]
        //[StringLength(6, MinimumLength = 3, ErrorMessage = "تعداد کاراکتر فیلد {0} باید بین {1} و {2} باشد")]
        [MaxLength(5, ErrorMessage = "{0} can have a max of {1} characters")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [Display(Name = "رمزعبور")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "تکرار رمز عبور صحیح نمیباشد.")]
        public string? RePassword { get; set; }

        
    }
}
