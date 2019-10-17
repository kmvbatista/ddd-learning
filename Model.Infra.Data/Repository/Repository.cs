﻿using Model.Domain.Entities;
using Model.Domain.Interfaces;
using Model.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Infra.Data.Repository
{

    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext context = new MySqlContext();

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Set<T>().Remove(SelectById(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public T SelectById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
