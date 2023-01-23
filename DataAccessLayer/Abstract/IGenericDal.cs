using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class        //T entity değer gönderebilmek için ve where şartı bir classa ait bütün değerleri kullanıcak
    {
        void Insert(T t);  //T türünde ve t değişkeninde bir entityi dışardan çağırdık
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
