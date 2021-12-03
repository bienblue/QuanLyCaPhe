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
    public class chi_tiet_ban_hangDAO : GenericDAO<chi_tiet_ban_hang>
    {
        public chi_tiet_ban_hangDAO() : base() { }
        public override void Add(chi_tiet_ban_hang model)
        {
            provider.ExcuteNonQuery("chi_tiet_bh_insert", CommandType.StoredProcedure,
                new SqlParameter("@mahd", model.ma_hd),
                new SqlParameter("@mahh", model.ma_hh),
                new SqlParameter("@so_luong", model.so_luong));
        }

        public override List<chi_tiet_ban_hang> GetAll()
        {
            var db = provider.GetDataToDataTable("chi_tiet_bh_selectall", CommandType.StoredProcedure);
            return Convertor.DB_ToList<chi_tiet_ban_hang>(db);
        }

        public override void Remove(chi_tiet_ban_hang model)
        {
            throw new NotImplementedException();
        }

        public override void Update(chi_tiet_ban_hang model)
        {
            throw new NotImplementedException();
        }
    }
}
