using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fregg_Template.Helper
{
    public class Year
    {
        public static int GetCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }
}