using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hey_url_challenge_code_dotnet.Models
{
    [Table("urls")]
    public class UrlModel
    {
        [Key]
        [Required]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("ShortUrl")]
        [MaxLength(5, ErrorMessage = "Maximum length exceeded")]
        public string ShortUrl { get; set; }
        [Column("Count")]
        public int Count { get; set; }
    }
}
