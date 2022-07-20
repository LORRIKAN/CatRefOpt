namespace Model.Users
{
    [Display(Name = "Роли")]
    public partial class Role : Validatable, IDisplayable
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public long RoleId { get; set; }

        [Display(Name = "Наименование")]
        [Required (ErrorMessage = "Укажите наименование роли")]
        public string Name { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<User> Users { get; set; }

        public string DisplayName => Name;
    }
}
