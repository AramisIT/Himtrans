using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using DatabaseObjects;
using System.Drawing;
using Aramis.Enums;

namespace Catalogs
    {
    [Catalog(Description = "Текс", GUID = "AE5230DB-D8FB-42D2-BD7A-2E713CB27CC4", IsHierarchic = false, ShowCodeFieldInForm = false)]
    public class Tex : CatalogTable
        {
        [DataField(Description = "Картинка(50x50)", NotEmpty = true)]
        public Image TexImage
            {
            get
                {
                return z_TexImage;
                }
            set
                {
                if ( z_TexImage != null && z_TexImage.Equals(value) )
                    {
                    return;
                    }
                z_TexImage = value;
                NotifyPropertyChanged("TexImage");
                }
            }
        private Image z_TexImage = Consts.DefaultTexImage;

        public Tex() : base() {
            }
        }
    }
