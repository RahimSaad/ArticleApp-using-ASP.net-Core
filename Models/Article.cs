using System.ComponentModel.DataAnnotations;

namespace ArticlesApp.Models
{
    public class Article
    {
        [Key]
        public int articleId { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string body { get; set; }
    }
}
