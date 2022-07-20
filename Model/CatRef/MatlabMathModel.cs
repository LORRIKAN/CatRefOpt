namespace Model.CatRef
{
    [Display(Name = "Математические модели")]
    public partial class MatlabMathModel : Validatable, IDisplayable
    {
        public MatlabMathModel()
        {
            ModelsOfPlants = new HashSet<ModelOfPlant>();
            VariableParameters = new HashSet<VariableParameter>();
            CatalystParameters = new HashSet<CatalystParameter>();
            MaterialParameters = new HashSet<MaterialParameter>();
            ReactorParameters = new HashSet<ReactorParameter>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Display(Name = "Функция отбора риформинг-бензина")]
        [Required(ErrorMessage = "Необходимо указать функцию отбора риформинг-бензина")]
        public short SelectionFuncId { get; set; }

        [Display(Name = "Функция октанового числа риформинг-бензина")]
        [Required(ErrorMessage = "Необходимо указать функцию октанового числа риформинг-бензина")]
        public short OctaneNumberFuncId { get; set; }

        [Browsable(false)]
        public string? Description { get; set; }

        [Browsable(false)]
        public virtual MatlabFunc OctaneNumberFunc { get; set; } = null!;

        [Browsable(false)]
        public virtual MatlabFunc SelectionFunc { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<ModelOfPlant> ModelsOfPlants { get; set; }

        [Browsable(false)]
        public virtual ICollection<CatalystParameter> CatalystParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<MaterialParameter> MaterialParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<ReactorParameter> ReactorParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<VariableParameter> VariableParameters { get; set; }

        public string DisplayName => Name;
    }
}
