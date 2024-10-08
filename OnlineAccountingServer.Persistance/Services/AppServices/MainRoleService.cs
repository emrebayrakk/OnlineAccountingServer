﻿using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using OnlineAccountingServer.Domain.UoWs;

namespace OnlineAccountingServer.Persistance.Services.AppServices
{
    public class MainRoleService : IMainRoleService
    {
        private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
        private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleService(IMainRoleQueryRepository mainRoleQueryRepository,
            IMainRoleCommandRepository mainRoleCommandRepository, IAppUnitOfWork unitOfWork)
        {
            _mainRoleQueryRepository = mainRoleQueryRepository;
            _mainRoleCommandRepository = mainRoleCommandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddRangeAsync(newMainRoles, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<MainRole> GetAll()
        {
            return _mainRoleQueryRepository.GetAll();
        }

        public async Task<MainRole> GetByIdAsync(string id)
        {
            return await _mainRoleQueryRepository.GetById(id);
        }

        public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken)
        {
            //if(companyId == null) return await _mainRoleQueryRepository.GetFirstByExpiression(p=> p.Title == title,cancellationToken, false);

            return await _mainRoleQueryRepository.GetFirstByExpression(p => p.Title == title && p.CompanyId == companyId, cancellationToken, false);
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _mainRoleCommandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(MainRole mainRole)
        {
            _mainRoleCommandRepository.Update(mainRole);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
