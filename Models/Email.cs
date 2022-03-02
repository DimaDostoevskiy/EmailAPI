using System.ComponentModel.DataAnnotations;

namespace EmailAPI.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string CreateTime { get; set; }
        public string Result { get; set; } = string.Empty;
        public string? FailedMessage  { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string[]? Recipients { get; set; }
    }
}