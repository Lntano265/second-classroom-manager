namespace SecondClassroomManager.Models;

public class StudentSummary
{
    public const double TargetCredits = 4.0;
    public const double NearTargetCredits = 3.0;

    public int StudentId { get; set; }
    public string StudentNo { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string College { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public int TotalRecords { get; set; }
    public int PendingRecords { get; set; }
    public int ApprovedRecords { get; set; }
    public double TotalCredits { get; set; }

    public double RemainingCredits => Math.Max(0, TargetCredits - TotalCredits);

    public string CreditStatus
    {
        get
        {
            if (TotalCredits >= TargetCredits)
            {
                return "已达标";
            }

            return TotalCredits >= NearTargetCredits ? "接近达标" : "未达标";
        }
    }

    public string CreditStatusClass
    {
        get
        {
            return CreditStatus switch
            {
                "已达标" => "approved",
                "接近达标" => string.Empty,
                _ => "rejected"
            };
        }
    }
}
