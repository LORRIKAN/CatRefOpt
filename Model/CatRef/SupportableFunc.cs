namespace Model.CatRef
{
    [Display(Name = "Поддерживаемые методами нелинейного программирования функции MATLAB")]
    public partial class SupportableFunc : Validatable
    {
        [Display(Name = "Функция MATLAB")]
        [Required(ErrorMessage = "Необходимо указать функцию MATLAB")]
        public short FuncId { get; set; }

        [Display(Name = "Метод оптимизации MATLAB")]
        [Required(ErrorMessage = "Необходимо указать метод оптимизации MATLAB")]
        public short OptimizationMethodId { get; set; }

        [Browsable(false)]
        public virtual MatlabFunc Func { get; set; } = null!;

        [Browsable(false)]
        public virtual MatlabOptimizationMethod OptimizationMethod { get; set; } = null!;
    }
}
