using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;

namespace Catalogs
    {
    [Catalog(Description = "ТУ У", GUID = "A7C15A04-A5AA-4BC8-BFC5-6EAE3ED06E41", IsHierarchic = false, ShowCodeFieldInForm = false)]
    public class Specifications : CatalogTable
        {
        [DataField(Description = "Номер ТУ У", NotEmpty = true)]
        public string Number
            {
            get
                {
                return z_Number;
                }
            set
                {
                if ( z_Number == value )
                    {
                    return;
                    }
                z_Number = value;
                NotifyPropertyChanged("Number");
                }
            }
        private string z_Number;

        public Specifications() : base() { }
        }
    }
