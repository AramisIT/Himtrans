using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using Aramis.Attributes;
using Aramis.Enums;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Catalogs
    {
    [Catalog(Description = "Константы", IsHidden = true, GUID = "AF0F1333-84CC-44D5-AAAA-7292E7622478")]
    public class Consts : CatalogTable
        {

        #region Default members (for any Aramis IT system)

        #region string Value (Значение константы)

        private const int MAX_VALUE_LENGTH = int.MaxValue;

        [DataField(Description = "Значение", Size = MAX_VALUE_LENGTH)]
        public string Value
            {
            get
                {
                return z_Value;
                }
            set
                {
                if ( z_Value == value )
                    {
                    return;
                    }

                z_Value = value;
                NotifyPropertyChanged("Value");
                }
            }
        private string z_Value = "";

        #endregion

        #region Constructor

        public Consts()
            : base()
            {
            }

        #endregion

        #region Reading / writting consts

        private static Consts FindByDescription(string description)
            {
            return ( Consts ) CatalogTable.FindByDescription("Consts", description);
            }

        private static string GetStrValue(string constName)
            {
            Consts catalog = FindByDescription(constName);

            if ( catalog == null )
                {
                ( constName + " consts is not exists" ).Error(ErrorLevels.CanIgnore, ErrorActions.LogError);
                return null;
                }
            else
                {
                return catalog.Value;
                }
            }

        private static void WriteStrValue(string constName, string value)
            {
            Consts catalog = FindByDescription(constName);

            if ( catalog == null )
                {
                catalog = new Consts();
                catalog.Description = constName;
                }

            if ( value.Length > MAX_VALUE_LENGTH )
                {
                catalog.Value = value.Substring(0, MAX_VALUE_LENGTH);
                }
            else
                {
                catalog.Value = value;
                }

            catalog.Write();
            }

        /// <summary>
        /// Содержит набор имен прочитанных из БД констант. 
        /// Значение в словаре не используется. Сам словарь применяется вместо списка так как быстрее работает проверка, если ли элемент в словаре
        /// </summary>        
        private static SortedDictionary<string, bool> constsActualityStatus = new SortedDictionary<string, bool>();

        private static bool ConstAlreadyRead(string constName)
            {
            return constsActualityStatus.ContainsKey(constName);
            }

        private static bool UpdateStrValue(string constName, out string strValue)
            {
            if ( constsActualityStatus.ContainsKey(constName) )
                {
                strValue = "";
                return false;
                }
            else
                {
                strValue = GetStrValue(constName);
                constsActualityStatus.Add(constName, true);
                return strValue != null;
                }
            }

        #endregion

        #endregion

        #region Константы
        private static Senders sender;
        public static Senders Sender
            {
            get
                {
                string strValue;

                if ( UpdateStrValue("Sender", out strValue) )
                    {
                    sender = new Senders();
                    sender.Read(Int64.Parse(strValue));
                    }

                return sender;
                }
            set
                {
                if ( ConstAlreadyRead("Sender") && sender != null && sender.Ref == value.Ref )
                    {
                    return;
                    }

                WriteStrValue("Sender", value.Id.ToString());
                sender = value;
                }
            }

        private static Specifications specification;
        public static Specifications Specification
            {
            get
                {
                string strValue;

                if ( UpdateStrValue("Specification", out strValue) )
                    {
                    specification = new Specifications();
                    specification.Read(Int64.Parse(strValue));
                    }

                return specification;
                }
            set
                {
                if ( ConstAlreadyRead("Specification") && specification != null && specification.Ref == value.Ref )
                    {
                    return;
                    }

                WriteStrValue("Specification", value.Id.ToString());
                specification = value;
                }
            }

        private static Color postedComplectation;
        public static Color PostedComplectation
            {
            get
                {
                string strValue;

                if ( UpdateStrValue("PostedComplectation", out strValue) )
                    {
                    postedComplectation = postedComplectation.ExtractFromToString(strValue);
                    }

                return postedComplectation;
                }
            set
                {
                if ( ConstAlreadyRead("PostedComplectation") && postedComplectation == value )
                    {
                    return;
                    }

                WriteStrValue("PostedComplectation", value.ConvertToString());
                postedComplectation = value;
                }
            }

        private static Color breakedComplectation;
        public static Color BreakedComplectation
            {
            get
                {
                string strValue;

                if ( UpdateStrValue("BreakedComplectation", out strValue) )
                    {
                    breakedComplectation = breakedComplectation.ExtractFromToString(strValue);
                    }

                return breakedComplectation;
                }
            set
                {
                if ( ConstAlreadyRead("BreakedComplectation") && breakedComplectation == value )
                    {
                    return;
                    }

                WriteStrValue("BreakedComplectation", value.ConvertToString());
                breakedComplectation = value;
                }
            }

        private static Image defaultTexImage;
        public static Image DefaultTexImage
            {
            get
                {
                string strValue;

                if ( UpdateStrValue("DefaultTexImage", out strValue) )
                    {
                    if ( !File.Exists(strValue) )
                        {
                        "Отсутствует файл изображения текса по умолчанию".WarningBox();
                        }
                    else
                        {
                        byte[] bytes = File.ReadAllBytes(strValue);
                        defaultTexImage = Image.FromStream(new MemoryStream(bytes));
                        }
                    }

                return defaultTexImage;
                }
            set
                {
                if ( ConstAlreadyRead("DefaultTexImage") && defaultTexImage != null && defaultTexImage.Equals(value) || value == null )
                    {
                    return;
                    }

                WriteStrValue("DefaultTexImage", value.Tag as string);
                defaultTexImage = value;
                }
            }
        #endregion
        }
    }
