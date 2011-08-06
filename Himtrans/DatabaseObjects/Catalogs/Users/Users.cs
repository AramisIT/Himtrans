using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using System.Data;
using Aramis.Attributes;
using Aramis.Enums;
using Aramis.SystemConfigurations;
using System.Security.Cryptography;
using Aramis.DatabaseConnector;

namespace Catalogs
    {
    [Catalog(Description = "Пользователи", GUID = "A705F057-D476-46D6-BA96-0D6B111D1F85", AllowEnterByPattern = true)]
    public class Users : CatalogUsers
        {

        #region long MobilePhone (Мобильный телефон)

        [DataField(Description = "Мобильный телефон")]
        public long MobilePhone
            {
            get
                {
                return z_MobilePhone;
                }
            set
                {
                if ( z_MobilePhone != value )
                    {
                    z_MobilePhone = value;
                    NotifyPropertyChanged("MobilePhone");
                    }
                }
            }

        private long z_MobilePhone;

        #endregion

        public Users()
            : base()
            {
            }

        
        }
    }
