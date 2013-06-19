using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aramis.Core;
using Aramis.Attributes;
using Aramis.Enums;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Catalogs
    {
    [Catalog(Description = "Константы", IsHidden = true, GUID = "AF0F1333-84CC-44D5-AAAA-7292E7622478")]
    public class Consts : SystemConsts
        {
        private static Color breakedComplectation;
        public static Color BreakedComplectation
            {
            get
                {
                lock (locker)
                    {
                    return breakedComplectation;
                    }
                }
            set
                {
                lock (locker)
                    {
                    if (breakedComplectation.ToArgb() != value.ToArgb())
                        {
                        breakedComplectation = value;
                        NotifyPropertyChanged("BreakedComplectation");
                        }
                    }
                }
            }

        private static Color postedComplectation;
        public static Color PostedComplectation
            {
            get
                {
                lock (locker)
                    {
                    return postedComplectation;
                    }
                }
            set
                {
                lock (locker)
                    {
                    if (postedComplectation.ToArgb() != value.ToArgb())
                        {
                        postedComplectation = value;
                        NotifyPropertyChanged("PostedComplectation");
                        }
                    }
                }
            }

        public static Senders Sender
            {
            get
                {
                lock (locker)
                    {
                    return (Senders)GetValueForObjectProperty("Sender");
                    }
                }
            set
                {
                lock (locker)
                    {
                    SetValueForObjectProperty("Sender", value);
                    }
                }
            }

        public static Specifications Specification
            {
            get
                {
                lock (locker)
                    {
                    return (Specifications)GetValueForObjectProperty("Specification");
                    }
                }
            set
                {
                lock (locker)
                    {
                    SetValueForObjectProperty("Specification", value);
                    }
                }
            }

        private static Image defaultTexImage;
        public static Image DefaultTexImage
            {
            get
                {
                lock (locker)
                    {
                    return defaultTexImage;
                    }
                }
            set
                {
                lock (locker)
                    {
                    if ((value == null && defaultTexImage == null) || (defaultTexImage != null && defaultTexImage.Equals(value)))
                        {
                        return;
                        }
                    defaultTexImage = value;
                    NotifyPropertyChanged("DefaultTexImage");
                    }
                }
            }
        }
    }


