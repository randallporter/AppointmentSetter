﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace AppointmentSetter.DataAccess
{
    public interface IEntityRepository<T> : IDisposable
    {
        void setContext(AppointmentDBContext context);
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
        void Save();
    }
}
