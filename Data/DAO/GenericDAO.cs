using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public abstract class GenericDAO<TModel>
    {
        public DataProvider provider;
        public GenericDAO()
        {
            provider = new DataProvider();
        }

        public abstract List<TModel> GetAll();
        public abstract void Remove(TModel model);
        public abstract void Add(TModel model);
        public abstract void Update(TModel model);
    }
}
