namespace ENAE202309011AutenticacionJWTMinimalAPI.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string name);
    }
}
