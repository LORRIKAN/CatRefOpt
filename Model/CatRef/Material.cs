namespace Model.CatRef
{
    [Display(Name = "Сырьё")]
    public partial class Material : Validatable, IDisplayable
    {
        public Material()
        {
            MaterialsOfPlants = new HashSet<MaterialOfPlant>();
            MaterialParameters = new HashSet<MaterialParameter>();
        }
        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<MaterialOfPlant> MaterialsOfPlants { get; set; }

        [Browsable(false)]
        public virtual ICollection<MaterialParameter> MaterialParameters { get; set; }

        public string DisplayName => Name;
    }
}
