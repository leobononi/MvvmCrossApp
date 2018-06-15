namespace MvvmApp.Core
{
    [System.AttributeUsage(System.AttributeTargets.All)]
    class PreserveAttribute : System.Attribute
    {
        public PreserveAttribute() { }
        public bool AllMembers { get; set; }
        public bool Conditional { get; set; }
    }
}
