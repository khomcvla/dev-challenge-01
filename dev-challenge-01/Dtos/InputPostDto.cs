using System.ComponentModel.DataAnnotations;

namespace dev_challenge_01.Dtos;

public class InputPostDto
{
    [Required(ErrorMessage = "Latitude is required!")]
    public double Latitude { get; set; }

    [Required(ErrorMessage = "Longitude is required!")]
    public double Longitude { get; set; }

    public int? AmountOfResults { get; set; }
    public string? PreferredFood { get; set; }
}
