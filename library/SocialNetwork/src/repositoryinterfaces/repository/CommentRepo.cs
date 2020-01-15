using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;
namespace SocialNetwork.src.repositoryinterfaces.repository
{
    public class CommentRepo : IRepository<Comment, string>
    {
        public MongoDB.Driver.MongoCollection<Comment> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public Comment Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Comment> entities)
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

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Comment, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Comment, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Comment> GetEnumerator()
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

        public Comment Update(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Comment> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}