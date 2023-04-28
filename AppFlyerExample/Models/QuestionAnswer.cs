namespace AppFlyerExample.Models;

public class QuestionAnswer
{
    public int Id { get; set; }
    public int AnswerId { get; set; }
    public Answer Answer { get; set; } = null!;
    public int QuestionId { get; set; }
    public Question Type { get; set; } = null!;
}