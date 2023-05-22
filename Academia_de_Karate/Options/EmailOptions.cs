namespace Academia_de_Karate.Options
{
    public class EmailOptions
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string SmtpClient { get; set; } = string.Empty;
        public int Port { get; set; }
    }
}