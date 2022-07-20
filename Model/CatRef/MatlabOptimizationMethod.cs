namespace Model.CatRef
{
    [Display(Name = "Методы нелинейного программирования MATLAB")]
    public partial class MatlabOptimizationMethod : Validatable, IDisplayable
    {
        public MatlabOptimizationMethod()
        {
            ParameterOfOptimizationMethods = new HashSet<ParameterOfOptimizationMethod>();
            SupportableFuncs = new HashSet<SupportableFunc>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Browsable(false)]
        public string? Description { get; set; }

        [Browsable(false)]
        public string MatlabText { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<ParameterOfOptimizationMethod> ParameterOfOptimizationMethods { get; set; }

        [Browsable(false)]
        public virtual ICollection<SupportableFunc> SupportableFuncs { get; set; }

        public string DisplayName => Name;
    }
}
