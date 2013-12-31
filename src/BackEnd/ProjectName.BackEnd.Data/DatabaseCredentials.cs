namespace ProjectName.BackEnd.Data
{
    public record DatabaseCredentials
    {
        public string? Host { get; init; }
        public string? Port { get; init; }
        public string? User { get; init; }
        public string? Password { get; init; }
        public string? Database { get; init; }

        public string GetDbConnectionString()
        {
            return $"Server={Host};Port={Port};Database={Database};Uid={User};password={Password};";
        }
    }
}
