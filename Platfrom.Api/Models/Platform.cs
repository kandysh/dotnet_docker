namespace Platfrom.Api.Models
{
    public sealed record Platform
    {
        public int Id { get; set; }
        public string? PlatformName { get; set; }
        public string? Publisher { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
