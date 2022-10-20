namespace Console_Spielerei;

public class Group
{
    public string Name { get; set; }
    public string TotalPath { get; set; }

    public bool Expanded { get; set; }

    public bool Selected { get; set; }
    public List<Group> Children { get; set; } = new();
}
