namespace SampleCodeFirst
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class EmployeeContext : DbContext
    {
       
        public EmployeeContext()
            : base("EmployeeContextConnectionString")
        {
        }

        public virtual DbSet<employee> employees { get; set; }
    }
    public class employee
    {
        [Key]
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string Employee_FirstName { get; set; }
        [Required]
        public string Employee_LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Employee_Email { get; set; }
        [Required]
        [Phone]
        public string Employee_Phone { get; set; }
    }
}