namespace BratislavaApi.Core.Exceptions
{
    public class NotFoundException : MainException
    {
        public NotFoundException(string message) : base(message)
        {
            StatusCode = 404;
        }

        public NotFoundException() : base("Resource Not Found")
        {
            StatusCode = 404;
        }
    }
}
