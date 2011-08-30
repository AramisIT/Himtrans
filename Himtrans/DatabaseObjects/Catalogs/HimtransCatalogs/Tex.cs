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
        private Image z_TexImage;

        public Tex() : base() {
            BeforeWriting += new BeforeWritingDelegate(Tex_BeforeWriting);
            }

        void Tex_BeforeWriting(DatabaseObject item, ref bool cancel)
        {
            int result = 0;
            cancel = !Int32.TryParse(((CatalogTable)item).Description, out result) || result == 0;
            if (cancel)
            {
                "Наименование текса должно быть числом отличным от нуля!".AlertBox();
            }
        }

        protected override void InitNewBeforeShowing()
        {
            base.InitNewBeforeShowing();
            z_TexImage = Consts.DefaultTexImage;
        }
        }
    }
