namespace Console_Spielerei;

public class Group
{
    public string Name { get; set; } = string.Empty;
    public string TotalPath { get; set; } = string.Empty;

    public bool Expanded { get; set; } = false;

    public bool Selected { get; set; } = false;
    public List<Group> Children { get; set; } = new();
}
