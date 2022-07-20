using Repository;
using System.ComponentModel;

namespace Admin.Shared
{
    public record struct EntityInfo
    {
        public string Name { get; init; }

        public Type DataType { get; init; }
    }
}