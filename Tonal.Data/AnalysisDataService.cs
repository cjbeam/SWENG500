using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Data
{
    public abstract class AbstractAnalysisDataService : BaseDataService
    {
        abstract public DataTable GetAnalysis(string category, int demographicId);
    }
    public class AnalysisDataService : AbstractAnalysisDataService
    {
        public override DataTable GetAnalysis(string category, int demographicId)
        {
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_SEL_Emotions", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@demographicId", demographicId);

                    conn.Open();
                    return base.GetDataTable(cmd, conn);
                }
            }
        }
    }
}
