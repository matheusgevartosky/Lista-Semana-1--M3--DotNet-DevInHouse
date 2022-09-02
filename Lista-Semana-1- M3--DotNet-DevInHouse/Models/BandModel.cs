using Lista_Semana_1__M3__DotNet_DevInHouse.DTO;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Models
{
    public class BandModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Genre { get; set; }
        public bool Solo { get; set; }

        public static explicit operator BandGetDTO(BandModel model)
        {
            return new BandGetDTO
            {
                Id = model.Id,
                Descricao = model.Descricao,
                Genero = model.Genre,
                Solo = model.Solo,
            };
        }
    }


}

