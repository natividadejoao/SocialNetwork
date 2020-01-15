
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;

namespace SocialNetwork.src.repositoryinterfaces.repository
{
    public class AdminUserRepo : IRepository<AdminUser, string>
    {
       public MongoDB.Driver.MongoCollection<AdminUser> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public AdminUser Add(AdminUser entity)
        {
            throw new NotImplementedException();
        }

        public void Add(System.Collections.Generic.IEnumerable<AdminUser> entities)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(AdminUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<AdminUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<AdminUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AdminUser GetById(string id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerator<AdminUser> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RequestDone()
        {
            throw new NotImplementedException();
        }

        public IDisposable RequestStart()
        {
            throw new NotImplementedException();
        }

        public AdminUser Update(AdminUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(System.Collections.Generic.IEnumerable<AdminUser> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}