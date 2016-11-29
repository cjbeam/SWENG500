using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Data
{
    public abstract class AbstractMemberFieldDataService : BaseDataService
    {
        abstract public DataTable LookupEducationOptions();
        abstract public DataTable LookupGenderOptions();
        abstract public DataTable LookupStateOptions();
    }

    public class MemberFieldDataService : AbstractMemberFieldDataService
    {
        public override DataTable LookupEducationOptions()
        {
            DataTable dt = null;
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_SEL_EducationLevels", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    conn.Open();
                    dt = base.GetDataTable(cmd, conn);
                }
            }
            return dt;
        }

        public override DataTable LookupGenderOptions()
        {
            DataTable dt = null;
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_SEL_GenderTypes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    dt = base.GetDataTable(cmd, conn);
                }
            }
            return dt;
        }

        public override DataTable LookupStateOptions()
        {
            DataTable dt = null;
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_SEL_States", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    dt = base.GetDataTable(cmd, conn);
                }
            }
            return dt;
        }
    }
}
