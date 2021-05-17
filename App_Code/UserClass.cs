using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Annex.App_Code
{
    //used for the authentication in order to get the user's details after loging in using google
    public class UserClass
    {
            public string id { get; set; }
            public string name { get; set; }
            public string given_name { get; set; }
            public string family_name { get; set; }
            public string link { get; set; }
            public string picture { get; set; }
            public string gender { get; set; }
            public string locale { get; set; }
        
    }
}