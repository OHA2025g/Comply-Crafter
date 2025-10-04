namespace ComplyCrafter_API.Models
{
    public class AuthModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string? Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Email)) return "Please provide email";
            if (string.IsNullOrWhiteSpace(this.Password)) return "Please provide password";
            return null;
        }
    }

    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
