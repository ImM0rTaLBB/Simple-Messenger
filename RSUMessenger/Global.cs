using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSUMessenger
{
    class Global
    {
        private static AppData _db;

        public static AppData DB
        {
            get
            {
                if (_db == null)
                    _db = new AppData();
                return _db;
            }
        }
    }
}
