using Domain.Common;

namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public string? Language { get; set; }
        public string? UrlImage { get; set; }
        public string? UrlImageThumbnail { get; set; }
        public int? Pages { get; set; }
        public DateOnly PublicationDate { get; set; }
    }
}
