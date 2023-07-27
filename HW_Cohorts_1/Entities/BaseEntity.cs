using System.ComponentModel.DataAnnotations;

namespace HW_Cohorts_1.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
