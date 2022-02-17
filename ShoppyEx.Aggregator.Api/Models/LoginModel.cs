
namespace ShoppyEx.Aggregator.Api.Models
{
    public record class LoginModel 
    {
        public string Email { get; init; }
        public string Password { get; init; }      
    }
}
