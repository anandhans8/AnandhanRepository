namespace AnandhanRepository.Core.DomainObjecs
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    } 
}
