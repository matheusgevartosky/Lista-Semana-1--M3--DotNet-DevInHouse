using Lista_Semana_1__M3__DotNet_DevInHouse.DTO;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Entities
{
    public interface IBandService
    {
        int Add(BandPostDTO bandPostDTO);
        bool Update(BandPutDTO bandPutDTO);
        bool Delete(int id);
        IList<BandGetDTO> GetAll();
    }

}
