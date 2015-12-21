namespace BookIt.Server.DataTransferModels.Account.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterBindingModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Username")]
        [StringLength(35, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [MaxLength(30)]
        [StringLength(35, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [StringLength(35, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Pass the roles as array of strings.Possible roles:
        /// Admin
        /// Creator
        /// Employee
        /// Owner
        /// Manager
        /// Supervisor
        /// Worker
        /// They are in BookIt.Data.Common.ConstantRoles.cs
        /// </summary>
        [Required]
        [Display(Name = "Roles")]
        public string[] Roles { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}