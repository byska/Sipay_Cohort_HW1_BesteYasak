using System.ComponentModel.DataAnnotations;

namespace HW_Cohorts_1.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual List<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }
    }
}
