using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecta.Core.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public string ProposalNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ProposalStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        // Foreign Keys
        public int CustomerId { get; set; }

        // Navigation properties for the relationships.
        public Customer Customer { get; set; }
        public ICollection<LineItem> LineItems { get; set; }
    }
}
