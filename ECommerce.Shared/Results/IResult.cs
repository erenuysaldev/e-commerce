namespace ECommerce.Shared.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
} 