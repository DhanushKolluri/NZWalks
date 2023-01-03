namespace NZWalks.API.Models.DTO
{
    public class AddWalkRequest
    {
        // public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }
    }
}
