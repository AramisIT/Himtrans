using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;

namespace Catalogs
    {
    [Catalog(Description = "ТУ У", GUID = "A7C15A04-A5AA-4BC8-BFC5-6EAE3ED06E41")]
    public class Specifications : CatalogTable
        {
        public Specifications() : base() { }
        }
    }
