using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public class loaihangDAO : GenericDAO<loaihang>
    {
        public loaihangDAO() : base() { }

        public override void Add(loaihang model)
        {
            provider.ExcuteNonQuery("loaihang_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_lh", model.ma_lh),
                new SqlParameter("@ten_lh", model.ten_lh),
                new SqlParameter("@mo_ta", model.mo_ta));
        }

        public override List<loaihang> GetAll()
        {
            var db = provider.GetDataToDataTable("loaihang_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<loaihang>(db);
        }

        public override void Remove(loaihang model)
        {
            provider.ExcuteNonQuery("loaihang_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_lh", model.ma_lh));
        }

        public override void Update(loaihang model)
        {
            provider.ExcuteNonQuery("loaihang_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_lh", model.ma_lh),
                new SqlParameter("@ten_lh", model.ten_lh),
                new SqlParameter("@mo_ta", model.mo_ta));
        }
    }
}
