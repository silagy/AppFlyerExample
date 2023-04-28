namespace AppFlyerExample.Models;

public class Question
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<QuestionAnswer> QuestionAnswers { get; set; }
}