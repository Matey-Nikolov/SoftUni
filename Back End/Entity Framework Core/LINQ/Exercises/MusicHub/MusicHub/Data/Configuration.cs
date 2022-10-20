using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data
{
    internal class Configuration
    {
        public static string ConnectionString = "\"Server=(localdb)\\MSSQLLocalDB;Database=MusicHub;Integrated Security=True;\" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models";
    }
}
