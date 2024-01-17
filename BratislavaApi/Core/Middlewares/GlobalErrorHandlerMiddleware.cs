using BratislavaApi.Core.Exceptions;
using BratislavaApi.Core.Responses;

namespace BratislavaApi.Core.Middlewares
{
    public class GlobalErrorHandlerMiddleware(RequestDelegate next)
    {
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                var response = context.Response;
                var responseApi = new ApiResponse();

                if (exception is MainException ex)
                {
                    responseApi.StatusCode = ex.StatusCode;
                    responseApi.Result = ex.Message;
                }

                await response.WriteAsJsonAsync(responseApi);
            }
        }
    }
}