using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using Aramis.SystemConfigurations;

namespace Catalogs.Predefined
    {
    public class Predefined
        {
        private static DBObjectRef z_SuperUser;
        public static DBObjectRef SuperUser
            {
            get
                {
                if ( z_SuperUser == null )
                    {
                    z_SuperUser = new DBObjectRef("Roles", Catalogs.PredefinedElements.GetPredefinedId(SystemConfiguration.DBConfigurationTree["Roles"].GUID, "SuperUser"));
                    }
                return z_SuperUser;
                }
            }
        }
    }
