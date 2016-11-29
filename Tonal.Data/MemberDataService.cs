using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonal.Model;

namespace Tonal.Data
{
    public abstract class AbstractMemberDataService : BaseDataService
    {
        abstract public bool Create(Tonal.Model.Member member);
        abstract public DataTable Read(string email);
        abstract public DataTable Update(Tonal.Model.Member member);
    }


    public class MemberDataService : AbstractMemberDataService
    {
        public override bool Create(Member member)
        {
            bool pass = false;
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_INS_Member", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@email", member.email);
                    cmd.Parameters.AddWithValue("@birthDate", member.birthDate);
                    cmd.Parameters.AddWithValue("@genderId", member.gender.GenderId);
                    cmd.Parameters.AddWithValue("@stateId", member.state.StateId);
                    cmd.Parameters.AddWithValue("@educationId", member.education.EducationId);

                    conn.Open();
                    base.ExecuteNonQuery(cmd, conn);
                    pass = true;
                }
            }
            return pass;
        }

        public override DataTable Read(string email)
        {
            using (SqlConnection conn = base.GetSQLConnection())
            {
                using (SqlCommand cmd = new SqlCommand("usp_TONAL_SEL_MemberByEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    return base.GetDataTable(cmd, conn);
                }
            }
        }

        public override DataTable Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
