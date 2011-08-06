using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;

namespace Catalogs
    {
    [Catalog(Description = "Стандарты веса бобин", IsHidden = false, IsHierarchic = false, GUID = "AED6A0F6-D58B-4d3e-B721-369F5D319690")]
    public class PackTypes : CatalogTable
        {
        [DataField(Description = "Вес бобины", ShowInList = true)]
        public int Weight
            {
            get { return z_Weight; }
            set
                {
                if ( z_Weight == value )
                    {
                    return;
                    }
                z_Weight = value;
                NotifyPropertyChanged("Weight");
                }
            }
        private int z_Weight;

        public PackTypes() : base() { }
        }
    }
