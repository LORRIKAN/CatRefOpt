namespace Model.CatRef
{
    [Display(Name = "Сырьё установок риформинга")]
    public partial class MaterialOfPlant : Validatable
    {
        [Display(Name = "Сырьё")]
        [Required(ErrorMessage = "Необходимо указать сырьё")]
        public short MaterialId { get; set; }

        [Display(Name = "Установка риформинга")]
        [Required(ErrorMessage = "Необходимо указать установку риформинга")]
        public short PlantId { get; set; }

        [Browsable(false)]
        public virtual Material Material { get; set; } = null!;

        [Browsable(false)]
        public virtual Plant Plant { get; set; } = null!;
    }
}
