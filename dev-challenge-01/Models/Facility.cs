using dev_challenge_01.Utils.Enums;

namespace dev_challenge_01.Models;

public class Facility
{
    public int LocationId { get; set; }
    public string Applicant { get; set; }

    //NOTE: Now it works like IsTruck? -> true or falce
    //TODO: change to FacilityTypeEnum
    public bool? FacilityType { get; set; }

    public int Cnn { get; set; }
    public string? LocationDescription { get; set; }
    public string Address { get; set; }
    public string? BlockLot { get; set; }
    public string? Block { get; set; }
    public string? Lot { get; set; }
    public string Permit { get; set; }
    public FacilityStatusEnum? Status { get; set; }
    public string? FoodItems { get; set; }
    public double? X { get; set; }
    public double? Y { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Schedule { get; set; }
    public string? DaysHours { get; set; } //TODO: TimeSpan-> Day, Time
    public string? NOISent { get; set; }
    public DateTime? Approved { get; set; } //TODO: DateTime
    public int Received { get; set; }
    public bool PriorPermit { get; set; }
    public string? ExpirationDate { get; set; }
    public string Location { get; set; }
}
