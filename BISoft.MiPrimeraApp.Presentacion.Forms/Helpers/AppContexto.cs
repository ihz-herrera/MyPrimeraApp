using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyPrimeraApp.Fabrica.RepositoryFactory;

namespace MyPrimeraApp.Helpers
{
    internal class AppContexto
    {

        private static AppContexto _instance;

        public  DBType DBType { get; }

        private AppContexto(DBType type)
        {
            DBType = type;
        }


        public static AppContexto Instance(DBType type = DBType.Txt) { 
        
            if(_instance == null)
            {
                _instance = new AppContexto(type);
            }
        
            return _instance;
        

        }
    }
}
