namespace Model.CatRef
{
    [Display(Name = "Эмпирические коэффициенты")]
    public partial class EmpiricalCoefficient : Validatable
    {
        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Функция MATLAB")]
        [Required(ErrorMessage = "Необходимо указать функцию MATLAB")]
        public short FuncId { get; set; }

        [Display(Name = "Обозначение")]
        [Required(ErrorMessage = "Необходимо указать обозначение")]
        [StringLength(30, ErrorMessage = "Длина обозначения не должна превышать 30 символов")]
        public string Designation { get; set; } = null!;

        [Display(Name = "Значение")]
        [Required(ErrorMessage = "Необходимо указать значение эмпирического коэффициента")]
        public double Value { get; set; }

        [Browsable(false)]
        public virtual MatlabFunc Func { get; set; } = null!;
    }
}
