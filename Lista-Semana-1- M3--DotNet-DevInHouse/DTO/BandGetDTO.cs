using System.ComponentModel.DataAnnotations;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.DTO
{
    public record BandGetDTO
    {
        public int Id { get; init; }
        public string Descricao { get; init; } ="";
        public int Genero { get; init; }
        public bool Solo { get; init; }
    }
}
