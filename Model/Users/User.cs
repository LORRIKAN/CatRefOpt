namespace Model.Users
{
    [Display(Name = "Пользователи")]
    public partial class User : Validatable
    {
        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public long UserId { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string Name { get; set; } = null!;

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Укажите пароль пользователя")]
        public string Password { get; set; } = null!;

        [Display(Name = "Роль")]
        [Required(ErrorMessage = "Укажите роль пользователя")]
        public long RoleId { get; set; }

        [Browsable(false)]
        public virtual Role Role { get; set; } = null!;
    }
}
