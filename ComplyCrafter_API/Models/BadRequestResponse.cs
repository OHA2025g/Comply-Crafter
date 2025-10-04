namespace ComplyCrafter_API.Models
{
    public class CustomErrorResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public CustomErrorResponse(string error)
        {
            Status = !string.IsNullOrEmpty(error) ? false : true;
            Message = error;
        }
    }
}
