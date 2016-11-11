using System;
using System.Collections.Generic;
using System.Data;
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
            throw new NotImplementedException();
        }

        public override DataTable LookupGenderOptions()
        {
            throw new NotImplementedException();
        }

        public override DataTable LookupStateOptions()
        {
            throw new NotImplementedException();
        }
    }
}
