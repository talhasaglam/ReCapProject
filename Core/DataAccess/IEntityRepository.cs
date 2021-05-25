using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class
    {

        //Filter null demek filterede kullanmayabiliriz demek. Kategorie göre sıralamayı da burdan yapcuz.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Get operasyonu da yazdık, filtreleme de gerekebilir.
        //Detay istersen Filtere vermek şart.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);


    }
}
