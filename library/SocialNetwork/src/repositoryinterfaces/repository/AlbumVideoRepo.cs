using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;

namespace SocialNetwork.src.repositoryinterfaces.repository
{
    public class AlbumVideoRepo : IRepository<AlbumVideo, string>
    {
        public MongoDB.Driver.MongoCollection<AlbumVideo> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public AlbumVideo Add(AlbumVideo entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<AlbumVideo> entities)
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

        public void Delete(AlbumVideo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<AlbumVideo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<AlbumVideo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AlbumVideo GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<AlbumVideo> GetEnumerator()
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

        public AlbumVideo Update(AlbumVideo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<AlbumVideo> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}