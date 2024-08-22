using OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    internal class RemoveByIdMainRoleAndRoleRLCommandHandler 
        : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand, RemoveByIdMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            await _roleRelationshipService.RemoveById(request.Id);
            return new();
        }
    }
}
