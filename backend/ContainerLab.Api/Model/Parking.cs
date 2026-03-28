namespace ContainerLab.Api.Model
{
    public record Parking
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Spots { get; init; }
    }
}