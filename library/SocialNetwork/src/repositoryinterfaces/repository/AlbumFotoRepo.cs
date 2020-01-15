

using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using MongoRepository;
using SocialNetwork.src.entitiesinterfaces.entities;

namespace SocialNetwork.src.repositoryinterfaces.repository
{
    public class AlbumFotoRepo : IRepository<AlbumFoto, string>
    {
        public MongoDB.Driver.MongoCollection<AlbumFoto> Collection => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public AlbumFoto Add(AlbumFoto entity)
        {
            throw new NotImplementedException();
        }

        public void Add(System.Collections.Generic.IEnumerable<AlbumFoto> entities)
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

        public void Delete(AlbumFoto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<AlbumFoto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<AlbumFoto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AlbumFoto GetById(string id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerator<AlbumFoto> GetEnumerator()
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

        public AlbumFoto Update(AlbumFoto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(System.Collections.Generic.IEnumerable<AlbumFoto> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}