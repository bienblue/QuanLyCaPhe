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
    public class hanghoaDAO : GenericDAO<hanghoa>
    {
        public hanghoaDAO() : base() { }
        public override void Add(hanghoa model)
        {
            provider.ExcuteNonQuery("douong_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", model.ma_hh),
                new SqlParameter("@ten_hh", model.ten_hh),
                new SqlParameter("@gia_sp", model.gia_sp),
                new SqlParameter("@soluong", model.soluong),
                new SqlParameter("@ma_lh", model.ma_lh));
        }

        public override List<hanghoa> GetAll()
        {
            var db = provider.GetDataToDataTable("douong_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<hanghoa>(db);
        }

        public override void Remove(hanghoa model)
        {
            provider.ExcuteNonQuery("douong_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", model.ma_hh));
        }

        public override void Update(hanghoa model)
        {
            provider.ExcuteNonQuery("douong_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_hh", model.ma_hh),
                new SqlParameter("@ten_hh", model.ten_hh),
                new SqlParameter("@soluong", model.soluong),
                new SqlParameter("@gia_sp", model.gia_sp),
                new SqlParameter("@ma_lh", model.ma_lh));
        }
    }
}
