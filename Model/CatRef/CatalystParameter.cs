using System;
using System.Collections.Generic;

namespace Model.CatRef
{
    [Display(Name = "Характеристики катализаторов")]
    public partial class CatalystParameter
    {
        public short Id { get; set; }

        [Display(Name = "Математическая модель")]
        [Required(ErrorMessage = "Укажите математическую модель")]
        public short MathModelId { get; set; }

        [Display(Name = "Катализатор")]
        [Required(ErrorMessage = "Укажите катализатор")]
        public short CatalystId { get; set; }

        [Display(Name = "Имя параметра")]
        [Required(ErrorMessage = "Необходимо указать имя параметра")]
        public string Name { get; set; } = null!;

        [Display(Name = "Значение параметра")]
        [Required(ErrorMessage = "Укажите значение параметра")]
        public double Value { get; set; }

        [Display(Name = "Обозначение параметра в модели")]
        [Required(ErrorMessage = "Укажите обозначение параметра в модели")]
        public string Designation { get; set; } = null!;

        [Display(Name = "Единица измерения")]
        public short? MeasureUnitId { get; set; }

        [Browsable(false)]
        public virtual MeasureUnit? MeasureUnit { get; set; } = null!;

        [Browsable(false)]
        public virtual Catalyst Catalyst { get; set; } = null!;

        [Browsable(false)]
        public virtual MatlabMathModel MathModel { get; set; } = null!;
    }
}
