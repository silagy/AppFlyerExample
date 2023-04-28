namespace AppFlyerExample.Models;

public class ContentAnswer
{
    public int Id { get; set; }
    public int AnswerId { get; set; }
    public Answer Type { get; set; } = null!;
    public int ContentId { get; set; }
    public Content Content { get; set; } = null!;
}