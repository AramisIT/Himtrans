﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;
using System.Drawing;
using Aramis.Enums;

namespace Catalogs
{

    [Catalog(Description = "Варианты печати веса", GUID = "A2C5F3C2-46D5-4347-AF3E-7E38FEA4254E", IsHierarchic = false, ShowCodeFieldInForm = false)]
    public class WeightVariants : CatalogTable
    {

        public WeightVariants()
            : base()
        {
        }


    }
}
