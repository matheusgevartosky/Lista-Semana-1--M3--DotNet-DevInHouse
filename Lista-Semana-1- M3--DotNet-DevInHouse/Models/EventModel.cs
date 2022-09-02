using System.ComponentModel.DataAnnotations.Schema;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public decimal MaxCapacity { get; set; }
        public DateTime EventDate { get; set; }
        public int EventType { get; set; }

        [ForeignKey("Banda")]
        public int BandId { get; set; }


    }
}
/*
      - Id (Guid)
     - Descrição (string)
     - Quantidade Pessoas que local suporta (decimal)
     - Data do Evento (datetime)
     - Tipo Evento (int)
     - Id da Banda (Guid) [foreign key]
 */