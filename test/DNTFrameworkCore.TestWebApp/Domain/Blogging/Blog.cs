using DNTFrameworkCore.Domain.Entities;
using DNTFrameworkCore.Domain.Entities.Tracking;

namespace DNTFrameworkCore.TestWebApp.Domain.Blogging
{
    public class Blog : TrackableEntity<int>, IAggregateRoot
    {
        public const int MaxTitleLength = 50;
        public const int MaxUrlLength = 50;
        public string Title { get; set; }
        public string NormalizedTitle { get; set; }
        public string Url { get; set; }
        public byte[] RowVersion { get; set; }
    }
}