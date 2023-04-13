using ArtClubApp.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArtClubApp.DataAccess.Abstractions
{
    public interface IBaseRepository <T> where T : ModelEntity
    {
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Remove(int entityId);

    }
}