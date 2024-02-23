using Core.Entities.Abstract;

namespace Core.Entities.Concrete;

public abstract class BaseEntity<TId> : IEntity
{
	public TId Id { get; set; }
}
