using HW_Cohorts_1.Enums;

namespace HW_Cohorts_1.Entities
{
    public class Order : BaseEntity
    {
        public Status status { get; set; } = 0;
        public virtual User user { get; set; }
        public int UserId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string Description { get; set; }
    }
}
