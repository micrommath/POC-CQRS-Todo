﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todo.Application.Services
{
    public interface ITodoProvider
    {
        Task Add(Domain.Todo todo);
        Task Delete(Guid id);
        Task<List<Domain.Todo>> GetAll();
        Task<Domain.Todo> GetById(Guid id);
        Task Update(Domain.Todo todo);
    }
}