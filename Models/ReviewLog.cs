namespace SecondClassroomManager.Models;

public class ReviewLog
{
    public int Id { get; set; }
    public int ActivityRecordId { get; set; }
    public string OldStatus { get; set; } = string.Empty;
    public string NewStatus { get; set; } = string.Empty;
    public double OldCredits { get; set; }
    public double NewCredits { get; set; }
    public string ReviewOpinion { get; set; } = string.Empty;
    public DateTime ReviewedAt { get; set; }
}
