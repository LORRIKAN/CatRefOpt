namespace Model.CatRef
{
    [Display(Name = "Математические модели установок риформинга")]
    public partial class ModelOfPlant : Validatable
    {
        [Display(Name = "Установка риформинга")]
        [Required(ErrorMessage = "Необходимо указать установку риформинга")]
        public short PlantId { get; set; }

        [Display(Name = "Математическая модель")]
        [Required(ErrorMessage = "Необходимо указать математическую модель")]
        public short MathModelId { get; set; }

        [Browsable(false)]
        public virtual Plant Plant { get; set; } = null!;

        [Browsable(false)]
        public virtual MatlabMathModel MathModel { get; set; } = null!;
    }
}
