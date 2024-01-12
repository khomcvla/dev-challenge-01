using TinyCsvParser.Mapping;

namespace dev_challenge_01.Data.Models;

public class FacilityCsvMapper : CsvMapping<Facility>
{
    public FacilityCsvMapper()
        : base()
    {
        MapProperty(0, x => x.LocationId);
        MapProperty(1, x => x.Applicant);
        MapProperty(2, x => x.FacilityType);
        MapProperty(3, x => x.Cnn);
        MapProperty(4, x => x.LocationDescription);
        MapProperty(5, x => x.Address);
        MapProperty(6, x => x.BlockLot);
        MapProperty(7, x => x.Block);
        MapProperty(8, x => x.Lot);
        MapProperty(9, x => x.Permit);
        MapProperty(10, x => x.Status);
        MapProperty(11, x => x.FoodItems);
        MapProperty(12, x => x.X);
        MapProperty(13, x => x.Y);
        MapProperty(14, x => x.Latitude);
        MapProperty(15, x => x.Longitude);
        MapProperty(16, x => x.Schedule);
        MapProperty(17, x => x.DaysHours);
        MapProperty(18, x => x.NOISent);
        MapProperty(19, x => x.Approved);
        MapProperty(20, x => x.Received);
        MapProperty(21, x => x.PriorPermit);
        MapProperty(22, x => x.ExpirationDate);
        MapProperty(23, x => x.Location);
    }
}
