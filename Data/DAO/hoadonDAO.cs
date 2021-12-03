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
    public class hoadonDAO : GenericDAO<hoadon>
    {
        public hoadonDAO() : base() { }

        public override void Add(hoadon model)
        {
            provider.ExcuteNonQuery("hoadon_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_hd", model.ma_hd),
                new SqlParameter("@ngay_hd", model.ngay_hd),
                new SqlParameter("@tong_tien", model.tong_tien),
                new SqlParameter("@ma_nv", model.ma_nv),
                new SqlParameter("@ma_ban", model.ma_ban));

        }

        public override List<hoadon> GetAll()
        {
            var db = provider.GetDataToDataTable("hoadon_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<hoadon>(db);
        }

        public override void Remove(hoadon model)
        {
            provider.ExcuteNonQuery("hoadon_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_hd", model.ma_hd));
        }

        public override void Update(hoadon model)
        {
            provider.ExcuteNonQuery("hoadon_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_hd", model.ma_hd),
                new SqlParameter("@ngay_hd", model.ngay_hd),
                new SqlParameter("@tong_tien", model.tong_tien),
                new SqlParameter("@ma_nv", model.ma_nv),
                new SqlParameter("@ma_ban", model.ma_ban));
        }

        public DataTable Revenue()
        {
            return provider.GetDataToDataTable("doanh_thu", CommandType.StoredProcedure);
        }
        public DataTable Revenue(int year)
        {
            return provider.GetDataToDataTable("doanh_thu_nam", CommandType.StoredProcedure,
                new SqlParameter("@nam", year));
        }
        public DataTable Revenue(int month, int year)
        {
            return provider.GetDataToDataTable("doanh_thu_thang", CommandType.StoredProcedure,
                new SqlParameter("@thang", month),
                new SqlParameter("@nam", year));
        }
    }
}
