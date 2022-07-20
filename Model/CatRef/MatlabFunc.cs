namespace Model.CatRef
{
    [Display(Name = "Функции MATLAB")]
    public partial class MatlabFunc : Validatable, IDisplayable
    {
        public MatlabFunc()
        {
            EmpiricalCoefficients = new HashSet<EmpiricalCoefficient>();
            MatlabMathModelOctaneNumberFuncs = new HashSet<MatlabMathModel>();
            MatlabMathModelSelectionFuncs = new HashSet<MatlabMathModel>();
            SupportableFuncs = new HashSet<SupportableFunc>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование функции")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Browsable(false)]
        public string MatlabFuncText { get; set; } = null!;

        [Display(Name = "Единица измерения")]
        public short? MeasureUnitIdOfOutput { get; set; }

        [Browsable(false)]
        public virtual MeasureUnit? MeasureUnit { get; set; }

        [Browsable(false)]
        public virtual ICollection<EmpiricalCoefficient> EmpiricalCoefficients { get; set; }

        [Browsable(false)]
        public virtual ICollection<MatlabMathModel> MatlabMathModelOctaneNumberFuncs { get; set; }

        [Browsable(false)]
        public virtual ICollection<MatlabMathModel> MatlabMathModelSelectionFuncs { get; set; }

        [Browsable(false)]
        public virtual ICollection<SupportableFunc> SupportableFuncs { get; set; }

        public string DisplayName => Name;
    }
}
