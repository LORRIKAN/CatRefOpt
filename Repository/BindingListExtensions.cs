using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Repository
{
    public static class BindingListExtensions
    {
        public static Type GetDataType(this IBindingList data)
        {
            return data
                    .GetType().GenericTypeArguments.First();
        }

        public static string GetName(this IBindingList bindingList)
        {
            return bindingList.GetDataType().GetCustomAttributes(false)
                .OfType<DisplayAttribute>().FirstOrDefault()?.Name ?? bindingList.ToString() ?? string.Empty;
        }
    }
}
