using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\Users\\c_l445\\Desktop\\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}
