using System.Text.Json;

namespace dev_challenge_01.Utils.Responses;

public class ErrorDetailsResponse
{
    public string Message { get; }
    public List<object> Errors { get; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }

    public ErrorDetailsResponse(string message, List<Tuple<string, string>> errors)
    {
        Message = message;
        Errors = new List<object>(errors);
    }

    public ErrorDetailsResponse(string message, List<Tuple<string, string, string>> errors)
    {
        Message = message;
        Errors = new List<object>(errors);
    }

    public ErrorDetailsResponse(string message, List<int> errors)
    {
        Message = message;
        Errors = errors.ConvertAll(x => (object)x).ToList();
    }

    public ErrorDetailsResponse(string message, List<string> errors)
    {
        Message = message;
        Errors = new List<object>(errors);
    }

    public ErrorDetailsResponse(string message, params string[] errors)
    {
        Message = message;
        Errors = new List<object>(errors.ToList());
    }
}
