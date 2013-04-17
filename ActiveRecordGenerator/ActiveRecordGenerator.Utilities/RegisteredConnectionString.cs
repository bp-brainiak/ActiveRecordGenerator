using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveRecordGenerator.Utilities
{
    public class RegisteredConnectionString
    {
        public int Id { get; set; }
        public string ConnectionStringName { get; set; }
        public string ConnectionString { get; set; }
    }
}
