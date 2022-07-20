namespace Model.CatRef
{
    [Display(Name = "Параметры методов нелинейного программирования")]
    public partial class ParameterOfOptimizationMethod : Validatable
    {
        [Display(Name = "Параметр")]
        [Required(ErrorMessage = "Необходимо указать параметр")]
        public short ParameterId { get; set; }

        [Display(Name = "Метод оптимизации")]
        [Required(ErrorMessage = "Необходимо указать метод оптимизации")]
        public short OptimizationMethodId { get; set; }

        [Display(Name = "Обозначение")]
        [Required(ErrorMessage = "Необходимо указать обозначение")]
        [StringLength(30, ErrorMessage = "Длина обозначения не должна превышать 30 символов")]
        public string Designation { get; set; } = null!;

        [Display(Name = "Обязателен к заполнению исследователем")]
        [Required(ErrorMessage = "Необходимо указать обязательность к заполнению исследователем")]
        public bool IsNecessary { get; set; }

        [Display(Name = "Нижняя граница")]
        [Required(ErrorMessage = "Необходимо указать нижнюю границу")]
        public double LowerBound { get; set; }

        [Display(Name = "Верхняя граница")]
        [Required(ErrorMessage = "Необходимо указать верхнюю границу")]
        public double UpperBound { get; set; }

        [Display(Name = "Является целочисленным")]
        [Required(ErrorMessage = "Необходимо указать является ли параметр целочисленным")]
        public bool IsInt { get; set; }

        [Browsable(false)]
        public virtual MatlabOptimizationMethod OptimizationMethod { get; set; } = null!;

        [Browsable(false)]
        public virtual OptimizationParameter ParameterInfo { get; set; } = null!;
    }
}
