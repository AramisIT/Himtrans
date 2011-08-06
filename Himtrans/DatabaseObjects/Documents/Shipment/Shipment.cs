using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using Aramis.Attributes;
using Catalogs;
using System.Drawing;
using Aramis.Enums;
using System.Data;
using Aramis.DatabaseConnector;
using Aramis.UI.WinFormsDevXpress;

namespace Documents
    {
    [Document(Description = "Партия", GUID = "009CD186-D21A-4AF3-BD81-A4B7E8D1B38B", ShowDateInForm = false, NumberIsReadonly = true)]
    public class Shipment:DocumentTable
        {

        [DataField(Description = "Текс", ShowInList = true, NotEmpty = true)]
        public Tex Tex
            {
            get
                {
                return ( Tex ) GetValueForObjectProperty("Tex");
                }
            set
                {
                SetValueForObjectProperty("Tex", value);
                }
            }

        [DataField(Description = "Картинка текса", StorageType = StorageTypes.Local, ReadOnly = true)]
        public Image TexImage
            {
            get { return z_TexImage; }
            set
                {
                if ( z_TexImage == value )
                    {
                    return;
                    }
                z_TexImage = value;
                NotifyPropertyChanged("TexImage");
                }
            }
        private Image z_TexImage;

        [DataField(Description = "Вес партии", StorageType = StorageTypes.Virtual, Formula = String.Format("[dbo].GetShipmentTotalWeight({0})", DOCUMENT_NUMBER_FIELD_NAME), DecimalPointsNumber = 3)]
        public double TotalShipmentWeight
            {
            get { return z_TotalShipmentWeight; }
            set
                {
                if ( z_TotalShipmentWeight == value )
                    {
                    return;
                    }
                z_TotalShipmentWeight = value;
                NotifyPropertyChanged("TotalShipmentWeight");
                }
            }
        private double z_TotalShipmentWeight;

        [DataField(Description = "Номер последней бобины в парти", StorageType = StorageTypes.Virtual, Formula = String.Format("[dbo].GetLastShipmentBobinNumber({0})", DOCUMENT_NUMBER_FIELD_NAME))]
        public int LastBobbinNumber
            {
            get { return z_LastBobbinNumber; }
            set
                {
                if ( z_LastBobbinNumber == value )
                    {
                    return;
                    }
                z_LastBobbinNumber = value;
                NotifyPropertyChanged("LastBobbinNumber");
                }
            }
        private int z_LastBobbinNumber;

        [Table(Columns = "Pallet")]
        [DataField(Description = "Палеты", StorageType = StorageTypes.Local)]
        public DataTable Pallets
            {
            get
                {
                return GetSubtable("Pallets");
                }
            }

        [SubTableField(Description = "Палета", PropertyType = typeof(Pallet), AllowOpenItem = true)]
        public DataColumn Pallet
            {
            get;
            set;
            }

        public Shipment()
            : base()
            {
            BeforeDBTableChecked += new CheckObjectSPDelegate(Shipment_BeforeDBTableChecked);
            }

        void Shipment_BeforeDBTableChecked()
            {
            List<string> funcText = new List<string>(){@"create function GetShipmentTotalWeight(@Number bigint)
returns real
begin
declare @result real
 select @result = (select Round(isnull(sum(TotalPalletWeight), 0), 3) from pallet where Shipment = @Number)
 return @result
end"
,@"create function GetLastShipmentBobinNumber(@Number bigint)
returns real
begin
declare @result real
 select @result = (select Max(BobbinNumber) from SubPalletBobbins b
join Pallet p
on b.IdDoc = p.Id
where p.Shipment = @Number )
 return @result
end"};
            Aramis.SystemConfigurations.SystemCheckers.CheckSPExistings.CreateByList(funcText);
            }

        protected override void InitItemBeforeShowing()
            {
            TexImage = Tex.TexImage;
            Pallets.Rows.Clear();
            Query query = DB.NewQuery("select Id from pallet where Shipment = @Shipment");
            query.AddInputParameter("Shipment", Number);
            QueryResult result = query.Select();
            while ( result.Next() )
                {
                DataRow row = Pallets.AddSubtableRow();
                row[Pallet] = result["Id"];
                }
            }
        }
    }
