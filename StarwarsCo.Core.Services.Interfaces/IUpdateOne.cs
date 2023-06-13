namespace StarwarsCo.Core.Services.Interfaces
{
    public interface IUpdateOne<T> where T : class
    {
        void UpdateOne(T entity);
    }
}
