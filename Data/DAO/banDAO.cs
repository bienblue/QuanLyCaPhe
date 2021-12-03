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
    public class banDAO : GenericDAO<ban>
    {
        public banDAO() : base() { }

        public override void Add(ban model)
        {
            provider.ExcuteNonQuery("ban_insert", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", model.ma_ban),
                new SqlParameter("@ten_ban", model.ten_ban),
                new SqlParameter("@thuoc_tinh", model.thuoc_tinh));
        }

        public override List<ban> GetAll()
        {
            var db = provider.GetDataToDataTable("ban_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<ban>(db);
        }

        public override void Remove(ban model)
        {
            provider.ExcuteNonQuery("ban_delete", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", model.ma_ban));
        }

        public override void Update(ban model)
        {
            provider.ExcuteNonQuery("ban_update", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", model.ma_ban),
                new SqlParameter("@ten_ban", model.ten_ban),
                new SqlParameter("@thuoc_tinh", model.thuoc_tinh));
        }

        public List<DetailBill> Calc(ban model)
        {
            var db = provider.GetDataToDataTable("tinhtien", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", model.ma_ban));
            return Convertor.DB_ToList<DetailBill>(db);
        }

        public int Pay(ban model)
        {
            return (int) provider.ExecuteScalar("thanhtoan", CommandType.StoredProcedure,
                new SqlParameter("@ma_ban", model.ma_ban)); 
        }
    }
}
