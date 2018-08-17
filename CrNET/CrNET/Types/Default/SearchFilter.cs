namespace CrNET.Types.Default
{
    public class SearchFilter
    {
        public string Name { get; set; }
        public int LocationId { get; set; }
        public int MinMembers { get; set; }
        public int MaxMembers { get; set; }
        public int MinScore { get; set; }
        public int Limit { get; set; }
        public int After { get; set; }
        public int Before { get; set; }
    }
}
