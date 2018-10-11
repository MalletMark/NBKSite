using System;

namespace NBKSite.Models.Home
{
    public class Index : HomeViewModel
    {
        public string test {get;set;}

        public Index()
        {
            controllerName = "Index";
            test = "Test String Here";
        }
    }
}