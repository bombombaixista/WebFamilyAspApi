namespace WebFamilyAspApi.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<GroupMember> Members { get; set; } = new();
    }
}
