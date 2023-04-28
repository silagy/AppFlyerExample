namespace AppFlyerExample.Models;

public class Content
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<ContentAnswer> ContentAnswers { get; set; }
}