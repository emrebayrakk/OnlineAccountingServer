using OnlineAccountingServer.Domain.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingServer.Domain.AppEntities
{
    public sealed class MainRole : Entity
    {
        public string Title { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company? Company { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }
    }
}
