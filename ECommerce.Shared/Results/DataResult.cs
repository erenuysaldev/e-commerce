namespace ECommerce.Shared.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool success, string message = null) 
            : base(success, message)
        {
            Data = data;
        }
    }
} 