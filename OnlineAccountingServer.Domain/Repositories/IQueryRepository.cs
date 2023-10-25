﻿using OnlineAccountingServer.Domain.Abstraction;
using System.Linq.Expressions;

namespace OnlineAccountingServer.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expression);
        Task<T> GetById(string id);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression);
        Task<T> GetFirst();
    }
}