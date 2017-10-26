namespace Issues.Model
{
    public sealed class Issue
    {
        public string Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsOpen { get; set; }
    }
}