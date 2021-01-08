using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace weeeb.Veri
{
    public class IdariContext : DbContext
    {
        public IdariContext() : base("IdariVeritabani")
        {

        }

    }
}