namespace BratislavaApi.Core.Responses
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            StatusCode = 500;
            Result = "Internal server error";
        }

        public ApiResponse(int statusCode, string result)
        {
            StatusCode = statusCode;
            Result = result;
        }

        public int StatusCode { get; set; }
        public string Result { get; set; }
    }
}
