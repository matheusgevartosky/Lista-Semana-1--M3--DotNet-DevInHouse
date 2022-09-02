namespace Lista_Semana_1__M3__DotNet_DevInHouse.DTO
{
    public record BandPutDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int Genre { get; set; }

        public bool Solo { get; set; }
    }
}
