using OnlineAccountingServer.Domain.Abstraction;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAccountingServer.Domain.AppEntities
{
    public sealed class MainRoleAndRoleRelationship : Entity
    {
        public MainRoleAndRoleRelationship()
        {
            
        }
        public MainRoleAndRoleRelationship(string id,string roleId, string mainRoleId)
            : base(id)
        {
            RoleId = roleId;
            MainRoleId = mainRoleId;
        }
        [ForeignKey("AppRole")]
        public string RoleId { get; set; }
        public AppRole AppRole { get; set; }

        [ForeignKey("MainRole")]
        public string MainRoleId { get; set; }
        public MainRole MainRole { get; set; }
    }
}
