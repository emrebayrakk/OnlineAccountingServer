﻿using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.UoWs;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.UoWs
{
    public sealed class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly AppDbContext _context;

        public AppUnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken =default)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
