﻿using GroceryApp.Models.Models;

namespace GroceryApp.Data.DAL.Repositories
{
    public interface IRepository<T> where T : Model
    {
        List<T> GetAll();
        T? Get(int id);
        T Add(T item);
        T? Update(T item);
        T? Delete(T item);
    }
}
