namespace Lista_Semana_1__M3__DotNet_DevInHouse.Entities
{
    public interface IEntity<TModel>
    {
        int Add(TModel model);
        bool Update(TModel model);
        bool Delete(int id);
        IList<TModel> GetAll();
    }
}
