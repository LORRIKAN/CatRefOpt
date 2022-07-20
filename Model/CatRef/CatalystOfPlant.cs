namespace Model.CatRef
{
    [Display(Name = "Катализаторы установок риформинга")]
    public partial class CatalystOfPlant : Validatable
    {
        [Display(Name = "Катализатор")]
        [Required(ErrorMessage = "Необходимо указать катализатор")]
        public short CatalystId { get; set; }

        [Display(Name = "Установка риформинга")]
        [Required(ErrorMessage = "Необходимо указать установку риформинга")]
        public short PlantId { get; set; }

        [Browsable(false)]
        public virtual Catalyst Catalyst { get; set; } = null!;

        [Browsable(false)]
        public virtual Plant Plant { get; set; } = null!;
    }
}
