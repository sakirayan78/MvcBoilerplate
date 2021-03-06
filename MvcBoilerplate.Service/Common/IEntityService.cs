﻿using System.Collections.Generic;
using MvcBoilerplate.Model.Common;
using MvcBoilerplate.Service.Common;


namespace ByX.Service.Common
{
    public interface IEntityService<T> : IService
     where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();      
        void Update(T entity);
    }
}
