using Domain.Entities;

namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid IdCreatedBy { get; set; }

        public virtual User? CreatedBy { get; set; }
    }
}
