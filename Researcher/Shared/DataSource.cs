namespace Researcher.Shared
{
    public record struct DataSource(object? dataSource, string displayMember, string valueMember)
    {
        public static implicit operator (object? dataSource, string displayMember, string valueMember)(DataSource value)
        {
            return (value.dataSource, value.displayMember, value.valueMember);
        }

        public static implicit operator DataSource((object? dataSource, string displayMember, string valueMember) value)
        {
            return new DataSource(value.dataSource, value.displayMember, value.valueMember);
        }
    }
}
