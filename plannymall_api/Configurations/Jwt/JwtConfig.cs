namespace plannymall_api.Configurations.Jwt
{
    public class JwtConfig
    {
        public string SecretToken { get; set; }

        public TimeSpan ExpireTimeFrame { get; set; }
    }
}
