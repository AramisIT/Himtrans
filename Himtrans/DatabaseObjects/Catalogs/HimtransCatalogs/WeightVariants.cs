using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using Aramis.Core;
using System.Drawing;
using Aramis.Enums;

namespace Catalogs
{

    [Catalog(Description = "Вес", GUID = "A2C5F3C2-46D5-4347-AF3E-7E38FEA4254E", HierarchicType = HierarchicTypes.None, ShowCodeFieldInForm = false)]
    public class WeightVariants : CatalogTable
    {

        public WeightVariants()
            : base()
        {
        }


    }
}
