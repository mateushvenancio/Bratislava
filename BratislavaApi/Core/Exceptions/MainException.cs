namespace BratislavaApi.Core.Exceptions
{
    public abstract class MainException(string message) : Exception(message)
    {
        public int StatusCode { get; set; }
    }
}
