using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace KP_Instagram_Monitor
{
    [Table]
    public class DatabasePost
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
        
        public string no { get; set; }

        [Column]
        public string link { get; set; }

        [Column]
        public string detail { get; set; }
        
    }
    public class DatabasePostContext : DataContext
    {
        public Table<DatabasePost> postdetail;
        public DatabasePostContext(string connectionstring) : base(connectionstring) { }
    }
}
