using System;
using System.Collections.Generic;

namespace Model.CatRef
{
    [Display(Name = "Справочник параметров методов нелинейного программирования")]
    public partial class OptimizationParameter : Validatable, IDisplayable
    {
        public OptimizationParameter()
        {
            ParametersOfOptimizationMethods = new HashSet<ParameterOfOptimizationMethod>();
        }

        [Display(Name = "Идентификатор")]
        [ReadOnly(true)]
        public short Id { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Необходимо указать наименование")]
        [StringLength(255, ErrorMessage = "Длина наименования не должна превышать 255 символов")]
        public string Name { get; set; } = null!;

        [Display(Name = "Единица измерения")]
        public short? MeasureUnitId { get; set; }

        [Browsable(false)]
        public virtual MeasureUnit? MeasureUnit { get; set; }

        [Browsable(false)]
        public virtual ICollection<ParameterOfOptimizationMethod> ParametersOfOptimizationMethods { get; set; }
        public string DisplayName => Name;
    }
}
