namespace Model.CatRef
{
    [Display(Name = "Установки риформинга")]
    public partial class Plant : Validatable, IDisplayable
    {
        public Plant()
        {
            CatalystsOfPlants = new HashSet<CatalystOfPlant>();
            MaterialsOfPlants = new HashSet<MaterialOfPlant>();
            ModelsOfPlants = new HashSet<ModelOfPlant>();
            Reactors = new HashSet<Reactor>();
            VariableParameters = new HashSet<VariableParameter>();
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
        public virtual ICollection<MaterialOfPlant> MaterialsOfPlants { get; set; }

        [Browsable(false)]
        public virtual ICollection<ModelOfPlant> ModelsOfPlants { get; set; }

        [Browsable(false)]
        public virtual ICollection<Reactor> Reactors { get; set; }

        [Browsable(false)]
        public virtual ICollection<VariableParameter> VariableParameters { get; set; }

        public string DisplayName => Name;
    }
}
