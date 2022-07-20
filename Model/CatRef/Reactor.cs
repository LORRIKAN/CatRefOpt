namespace Model.CatRef
{
    [Display(Name = "Реакторы")]
    public partial class Reactor : Validatable, IDisplayable
    {
        public Reactor()
        {
            ReactorParameters = new HashSet<ReactorParameter>();
        }
        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Display(Name = "Установка риформинга")]
        [Required(ErrorMessage = "Необходимо указать установку риформинга")]
        public short PlantId { get; set; }

        [Browsable(false)]
        public virtual Plant Plant { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<ReactorParameter> ReactorParameters { get; set; }

        public string DisplayName => Name;
    }
}
