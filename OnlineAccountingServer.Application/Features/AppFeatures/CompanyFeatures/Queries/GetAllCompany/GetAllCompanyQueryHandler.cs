﻿using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;

namespace OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany
{
    public sealed class GetAllCompanyQueryHandler : IQueryHandler<GetAllCompanyQuery,
        GetAllCompanyQueryResponse>
    {
        private readonly ICompanyService _companyService;

        public GetAllCompanyQueryHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            var result = _companyService.GetAll();
            return new GetAllCompanyQueryResponse(await result.ToListAsync());
        }
    }
}
