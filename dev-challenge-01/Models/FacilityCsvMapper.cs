using System.Globalization;
using dev_challenge_01.Utils.Enums;
using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

namespace dev_challenge_01.Models;

public class FacilityCsvMapper : CsvMapping<Facility>
{
    public FacilityCsvMapper()
        : base()
    {
        MapProperty(0, x => x.LocationId);
        MapProperty(1, x => x.Applicant);

        //NOTE: Now it works like IsTruck? -> true or false
        MapProperty(2, x => x.IsTruck, new NullableBoolConverter("Truck", "Push Cart", StringComparison.InvariantCulture));
        //TODO: change to FacilityTypeEnum
        // MapProperty(2, x => x.FacilityType, new NullableEnumConverter<FacilityTypeEnum>(true));

        MapProperty(3, x => x.Cnn);
        MapProperty(4, x => x.LocationDescription);
        MapProperty(5, x => x.Address);
        MapProperty(6, x => x.BlockLot);
        MapProperty(7, x => x.Block);
        MapProperty(8, x => x.Lot);
        MapProperty(9, x => x.Permit);
        MapProperty(10, x => x.Status, new NullableEnumConverter<FacilityStatusEnum>(true));
        MapProperty(11, x => x.FoodItems);
        MapProperty(12, x => x.X, new NullableDoubleConverter(CultureInfo.InvariantCulture, NumberStyles.Float));
        MapProperty(13, x => x.Y, new NullableDoubleConverter(CultureInfo.InvariantCulture, NumberStyles.Float));
        MapProperty(14, x => x.Latitude);
        MapProperty(15, x => x.Longitude);
        MapProperty(16, x => x.Schedule);
        MapProperty(17, x => x.DaysHours);
        MapProperty(18, x => x.NOISent);
        MapProperty(19, x => x.Approved, new NullableDateTimeConverter("MM/dd/yyyy h:mm:ss tt"));
        MapProperty(20, x => x.Received);
        MapProperty(21, x => x.PriorPermit, new BoolConverter("1", "0", StringComparison.InvariantCulture));
        MapProperty(22, x => x.ExpirationDate);
        MapProperty(23, x => x.Location);
    }

}
