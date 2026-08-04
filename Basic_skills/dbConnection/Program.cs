using DotNetEnv;

Env.TraversePath().Load();

string? dbHost = Environment.GetEnvironmentVariable("DB_Host");
string? dbPort = Environment.GetEnvironmentVariable("DB_Port");
string? dbName = Environment.GetEnvironmentVariable("DB_Name");
string? dbUsername = Environment.GetEnvironmentVariable("DB_Username");
string? dbPassword = Environment.GetEnvironmentVariable("DB_Password");

if (
    string.IsNullOrWhiteSpace(dbHost) ||
    string.IsNullOrWhiteSpace(dbPort) ||
    string.IsNullOrWhiteSpace(dbName) ||
    string.IsNullOrWhiteSpace(dbUsername) ||
    string.IsNullOrWhiteSpace(dbPassword)
)
{
    Console.WriteLine("One or more database environment variables are missing");
    return;
}

string connectionString = 
    $"Host={dbHost};" +
    $"Port={dbPort};" +
    $"Database={dbPort};" +
    $"Username={dbUsername};" +
    $"Password={dbPassword}";

Console.WriteLine("Database configuration loaded successfully.");