namespace Model.CatRef
{
    [Display(Name = "Режимные параметры процесса")]
    public partial class VariableParameter : Validatable
    {
        public short Id { get; set; }

        [Display(Name = "Установка риформинга")]
        [Required(ErrorMessage = "Необходимо указать установку риформинга")]
        public short PlantId { get; set; }

        [Display(Name = "Математическая модель")]
        [Required(ErrorMessage = "Необходимо указать математическую модель")]
        public short MathModelId { get; set; }

        [Display(Name = "Имя параметра")]
        [Required(ErrorMessage = "Необходимо указать имя параметра")]
        public string Name { get; set; } = null!;

        [Display(Name = "Нижння граница")]
        [Required(ErrorMessage = "Необходимо указать нижнюю границу")]
        public double LowerBound { get; set; }

        [Display(Name = "Верхняя граница")]
        [Required(ErrorMessage = "Необходимо указать верхнюю границу")]
        public double UpperBound { get; set; }

        [Display(Name = "Обозначение")]
        [Required(ErrorMessage = "Необходимо указать обозначение")]
        [StringLength(30, ErrorMessage = "Длина обозначения не должна превышать 30 символов")]
        public string Designation { get; set; } = null!;

        [Display(Name = "Единица измерения")]
        public short? MeasureUnitId { get; set; }

        [Browsable(false)]
        public virtual MeasureUnit? MeasureUnit { get; set; } = null!;

        [Browsable(false)]
        public virtual Plant Plant { get; set; } = null!;

        [Browsable(false)]
        public virtual MatlabMathModel MathModel { get; set; } = null!;
    }
}
