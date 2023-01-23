using EntityLayer.Concrete; //entityLayer.Conrete kullanmamız için ilgili referansı önceden dahil edilmiş olması gerekiyor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category); 
        void CategoryDelete(Category category); 
        void CategoryUpdate(Category category); 
        List<Category> GetList();
        Category GetById(int id);
    }
}
