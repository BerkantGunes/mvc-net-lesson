using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fabrika.Data.Model
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
    }
}