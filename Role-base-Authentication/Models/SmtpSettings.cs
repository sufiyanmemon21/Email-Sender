namespace Role_base_Authentication.Models
{
    public class SmtpSettings
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public bool EnablesSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
    }

}
