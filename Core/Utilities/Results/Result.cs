namespace Core.Utilities.Results;

public class Result:IResult
{
    public string Message { get; }
    public bool Success { get; }

    public Result(bool success, string message):this(success)
    {
        Message = message;
    }

    public Result(bool success)
    {
        Success = success;
    }
}