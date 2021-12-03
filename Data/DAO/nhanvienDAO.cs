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
    public class nhanvienDAO : GenericDAO<nhanvien>
    {
        public nhanvienDAO() : base() { }

        public override void Add(nhanvien model)
        {
            provider.ExcuteNonQuery("nhanvien_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", model.ma_nv),
                new SqlParameter("@ten_nv", model.ten_nv),
                new SqlParameter("@diachi", model.diachi),
                new SqlParameter("@sdt", model.sdt),
                new SqlParameter("@chucvu", model.chucvu),
                new SqlParameter("@gioitinh", model.gioitinh),
                new SqlParameter("@ngay_vao_lam", model.ngay_vao_lam),
                new SqlParameter("@username", model.username),
                new SqlParameter("@avatar", model.avatar),
                new SqlParameter("@password", model.password));
        }

        public override List<nhanvien> GetAll()
        {
            var db = provider.GetDataToDataTable("nhanvien_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<nhanvien>(db);
        }

        public override void Remove(nhanvien model)
        {
            provider.ExcuteNonQuery("nhanvien_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", model.ma_nv));
        }

        public override void Update(nhanvien model)
        {
            provider.ExcuteNonQuery("nhanvien_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_nv", model.ma_nv),
                new SqlParameter("@ten_nv", model.ten_nv),
                new SqlParameter("@diachi", model.diachi),
                new SqlParameter("@sdt", model.sdt),
                new SqlParameter("@chucvu", model.chucvu),
                new SqlParameter("@gioitinh", model.gioitinh),
                new SqlParameter("@ngay_vao_lam", model.ngay_vao_lam),
                new SqlParameter("@username", model.username),
                new SqlParameter("@avatar", model.avatar),
                new SqlParameter("@password", model.password));
        }
    }
}
