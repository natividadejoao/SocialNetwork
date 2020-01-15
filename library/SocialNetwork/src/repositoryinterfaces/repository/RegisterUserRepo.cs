using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;


namespace SocialNetwork.src.repositoryinterfaces.repository
{

    public class RegisterUserRepo : IRepository<RegisterUser, string>
    {
        public MongoDB.Driver.MongoCollection<RegisterUser> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public RegisterUser Add(RegisterUser entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<RegisterUser> entities)
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

        public void Delete(RegisterUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<RegisterUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<RegisterUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public RegisterUser GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<RegisterUser> GetEnumerator()
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

        public RegisterUser Update(RegisterUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<RegisterUser> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}