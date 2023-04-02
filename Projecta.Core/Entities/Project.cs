using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        // Foreign Keys
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        // Navigation properties for the relationships.
        public Customer Customer { get; set; }
        public User User { get; set; }
    }
}
