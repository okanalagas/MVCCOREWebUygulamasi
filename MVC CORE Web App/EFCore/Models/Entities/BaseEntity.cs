using EFCore.Models.Enums;

namespace EFCore.Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public BaseEntity()
        {
            Status= DataStatus.Inserted;
            CreatedDate=DateTime.Now;
        }
    }
}
