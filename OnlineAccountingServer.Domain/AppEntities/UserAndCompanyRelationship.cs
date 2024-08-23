using OnlineAccountingServer.Domain.Abstraction;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingServer.Domain.AppEntities
{
    public sealed class UserAndCompanyRelationship : Entity
    {
        public UserAndCompanyRelationship()
        {
            
        }
        public UserAndCompanyRelationship(string id, string appUserId, string companyId)
            : base(id)
        {
            AppUserId = appUserId;
            CompanyId = companyId;
        }
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
