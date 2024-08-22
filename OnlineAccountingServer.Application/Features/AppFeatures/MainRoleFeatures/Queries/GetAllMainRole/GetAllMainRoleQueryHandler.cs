using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.MainRoleFeaatures.Queries.GetAllMainRole
{
    public sealed class GetAllMainRoleQueryHandler : IQueryHandler<GetAllMainRoleQuery, GetAllMainRoleQueryResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public GetAllMainRoleQueryHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<GetAllMainRoleQueryResponse> Handle(GetAllMainRoleQuery request, CancellationToken cancellationToken)
        {
            return new(await _mainRoleService.GetAll().ToListAsync());
        }
    }
}
