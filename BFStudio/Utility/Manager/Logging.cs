using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Utility.Manager
{
    public class Logging
    {
        public static ILog Logger
        {
            get
            {
                ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

                return logger;
            }
        }
    }
}