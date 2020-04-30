using System.Data.Common;
using System.Data.Entity;

namespace DbManager.Context
{
    public partial class Entities : DbContext
    {
        public Entities(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        public Entities(DbConnection connection, bool contextOwnConnection)
           : base(connection, contextOwnConnection) { }


    }
}
