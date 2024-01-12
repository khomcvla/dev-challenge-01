namespace dev_challenge_01.Utils.Responses;

public class ServiceResponse
{
    public int StatusCode { get; }
    public object? Value { get; }

    public ServiceResponse(int statusCode, object? value = null)
    {
        StatusCode = statusCode;
        Value = value;
    }
}
