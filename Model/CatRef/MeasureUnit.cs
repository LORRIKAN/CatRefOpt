namespace Model.CatRef
{
    [Display(Name = "Единицы измерения")]
    public partial class MeasureUnit : Validatable, IDisplayable
    {
        public MeasureUnit()
        {
            MatlabFuncs = new HashSet<MatlabFunc>();
            OptimizationParameters = new HashSet<OptimizationParameter>();
            MaterialsParameters = new HashSet<MaterialParameter>();
            CatalystsParameters = new HashSet<CatalystParameter>();
            ReactorsParameters = new HashSet<ReactorParameter>();
            VariableParameters = new HashSet<VariableParameter>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Обозначение")]
        [Required(ErrorMessage = "Необходимо указать обозначение")]
        [StringLength(30, ErrorMessage = "Длина обозначения не должна превышать 30 символов")]
        public string Designation { get; set; } = null!;

        [Browsable(false)]
        public virtual ICollection<MatlabFunc> MatlabFuncs { get; set; }

        [Browsable(false)]
        public virtual ICollection<OptimizationParameter> OptimizationParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<MaterialParameter> MaterialsParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<CatalystParameter> CatalystsParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<ReactorParameter> ReactorsParameters { get; set; }

        [Browsable(false)]
        public virtual ICollection<VariableParameter> VariableParameters { get; set; }

        public string DisplayName => Designation;

        public override string ToString()
        {
            return Designation;
        }
    }
}
