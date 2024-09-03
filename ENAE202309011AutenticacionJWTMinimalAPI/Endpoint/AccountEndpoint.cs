using ENAE202309011AutenticacionJWTMinimalAPI.Auth;

namespace ENAE202309011AutenticacionJWTMinimalAPI.Endpoint
{
    public static class AccountEndpoint
    {
        public static void AddAccountEndpoint(this WebApplication app) {
            app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authService) =>
            {
                if(login=="Admin"&& password == "12345678")
                {
                    var token = authService.Authenticate(login);

                    return Results.Ok(token);
                }
                else
                {
                    return Results.Unauthorized();
                }
            });
        }
    }
}
