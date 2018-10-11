using System;

namespace NBKSite.Models.Home
{
    public class BingoBook : HomeViewModel
    {
        public string test {get;set;}

        public BingoBook()
        {
            controllerName = "BingoBook";
            test = "Test String Here";
        }
    }
}