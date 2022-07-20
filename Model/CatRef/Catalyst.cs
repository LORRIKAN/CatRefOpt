namespace Model.CatRef
{
    [Display(Name = "Катализаторы")]
    public partial class Catalyst : Validatable, IDisplayable
    {
        public Catalyst()
        {
            CatalystsOfPlants = new HashSet<CatalystOfPlant>();
            CatalystParameters = new HashSet<CatalystParameter>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<CatalystOfPlant> CatalystsOfPlants { get; set; }

        [Browsable(false)]
        public virtual ICollection<CatalystParameter> CatalystParameters { get; set; }

        public string DisplayName => Name;
    }
}
