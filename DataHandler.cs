using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Services
{
    public partial class DataHandler
    {
        public Utils Util { get; set; }
        public DataHandler(Utils util)
        {
            Util = util;
        }
    }
}
