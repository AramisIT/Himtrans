using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Attributes;
using Aramis.Core;
using Aramis.Enums;

namespace Catalogs
    {
    [Catalog(Description = "Отправители", GUID = "AA3F6957-C148-455B-AE06-D7973F4CD65B", HierarchicType = HierarchicTypes.None, ShowCodeFieldInForm = false)]
    public class Senders : CatalogTable
        {
        [DataField(Description = "Название", ShowInList = false)]
        public string Name
            {
            get { return z_Name; }
            set
                {
                if ( z_Name == value )
                    {
                    return;
                    }
                z_Name = value;
                NotifyPropertyChanged("Name");
                }
            }
        private string z_Name = "";

        [DataField(Description = "Город", ShowInList = false)]
        public string City
            {
            get { return z_City; }
            set
                {
                if ( z_City == value )
                    {
                    return;
                    }
                z_City = value;
                NotifyPropertyChanged("City");
                }
            }
        private string z_City = "";

        [DataField(Description = "Улица", ShowInList = false)]
        public string Street
            {
            get { return z_Street; }
            set
                {
                if ( z_Street == value )
                    {
                    return;
                    }
                z_Street = value;
                NotifyPropertyChanged("Street");
                }
            }
        private string z_Street = "";

        [DataField(Description = "Номер дома", ShowInList = false)]
        public string HouseNum
            {
            get { return z_HouseNum; }
            set
                {
                if ( z_HouseNum == value )
                    {
                    return;
                    }
                z_HouseNum = value;
                NotifyPropertyChanged("HouseNum");
                }
            }
        private string z_HouseNum = "";

        [DataField(Description = "Телефон 1", ShowInList = false)]
        public string Phone1
            {
            get { return z_Phone1; }
            set
                {
                if ( z_Phone1 == value )
                    {
                    return;
                    }
                z_Phone1 = value;
                NotifyPropertyChanged("Phone1");
                }
            }
        private string z_Phone1 = "";

        [DataField(Description = "Телефон 2", ShowInList = false)]
        public string Phone2
            {
            get { return z_Phone2; }
            set
                {
                if ( z_Phone2 == value )
                    {
                    return;
                    }
                z_Phone2 = value;
                NotifyPropertyChanged("Phone2");
                }
            }
        private string z_Phone2 = "";

        [DataField(Description = "Телефон 3", ShowInList = false)]
        public string Phone3
            {
            get { return z_Phone3; }
            set
                {
                if ( z_Phone3 == value )
                    {
                    return;
                    }
                z_Phone3 = value;
                NotifyPropertyChanged("Phone3");
                }
            }
        private string z_Phone3 = "";

        public Senders() : base() { }
        }
    }
