using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;
namespace SocialNetwork.src.repositoryinterfaces.repository
{
    public class AlbumMusicRepo : IRepository<AlbumMusic, string>
    {
        public MongoDB.Driver.MongoCollection<AlbumMusic> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public AlbumMusic Add(AlbumMusic entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<AlbumMusic> entities)
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

        public void Delete(AlbumMusic entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<AlbumMusic, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<AlbumMusic, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AlbumMusic GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<AlbumMusic> GetEnumerator()
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

        public AlbumMusic Update(AlbumMusic entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<AlbumMusic> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}