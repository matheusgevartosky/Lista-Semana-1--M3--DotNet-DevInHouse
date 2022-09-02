using Lista_Semana_1__M3__DotNet_DevInHouse.DTO;
using Lista_Semana_1__M3__DotNet_DevInHouse.Entities;
using Lista_Semana_1__M3__DotNet_DevInHouse.Models;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Services
{
    public class BandService : IBandService
    {

        private readonly IBandRepository<BandModel> _bandRepository;

        public BandService(IBandRepository<BandModel> bandRepository)
        {
            _bandRepository = bandRepository;
        }

        public int Add(BandPostDTO bandPostDTO)
        {
            var model = new BandModel
            {
                Descricao = bandPostDTO.Descricao,
                Genre = bandPostDTO.Genre,
                Solo = bandPostDTO.Solo
            };
            _bandRepository.Add(model);

            return model.Id;
        }

        public IList<BandGetDTO> GetAll()
        {
            var bandModel = _bandRepository.GetAll();
            List<BandGetDTO> list = new(bandModel.Select(x => (BandGetDTO)x));
            return list;
        }

        public bool Update(BandPutDTO bandPutDTO)
        {
            var model = new BandModel
            {
                Id = bandPutDTO.Id,
                Descricao = bandPutDTO.Description,
                Solo = bandPutDTO.Solo,
                Genre = bandPutDTO.Genre
            };
            return _bandRepository.Update(model);
        }

        public bool Delete(int id)
        {
            return _bandRepository.Delete(id);
        }

    }

}
