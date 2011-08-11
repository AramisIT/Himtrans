using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseObjects;
using Aramis.Attributes;
using Catalogs;
using Aramis.Enums;

namespace Aramis.Enums
    {
    public enum Events
        {
        [DataField(Description = "Вход в систему")]
        LogIn,
        [DataField(Description = "Выход из системы")]
        LogOut,
        [DataField(Description = "Открыта партия")]
        ShipmentOpened,
        [DataField(Description = "Комплектация")]
        Packing,
        [DataField(Description = "Доукомплектация")]
        PackingRenewal,
        [DataField(Description = "Завершение комплектации")]
        PackingEnd,
        [DataField(Description = "Прерывание комплектации")]
        PackingBreak,
        [DataField(Description = "Ручной ввод")]
        ManualEntering,
        [DataField(Description = "Перевзвешивание")]
        ReWeighting,
        [DataField(Description = "Отсутствующая бобина")]
        MissingBobbin,
        [DataField(Description = "Удаление бобины")]
        BobbinRemoving,
        [DataField(Description = "Повторная печать")]
        RePrinting
        }
    }

namespace Documents
    {
    [Document(Description = "Журнал", GUID = "0F100906-50BA-45AD-B0FC-BFC939EEA81E", ShowNumberInForm = false, ShowResponsibleInList = true, DateIsReadOnly = true)]
    public class Jornal : DocumentTable
        {
        [DataField(Description = "Событие", ReadOnly = true, ShowInList = true)]
        public Events Event
            {
            get { return z_Event; }
            set
                {
                if ( z_Event == value )
                    {
                    return;
                    }
                z_Event = value;
                NotifyPropertyChanged("Event");
                }
            }
        private Events z_Event;

        [DataField(Description = "Спецификация", ReadOnly = true, ShowInList = true, AllowOpenItem = true)]
        public Pallet Pallet
            {
            get { return ( Pallet ) GetValueForObjectProperty("Pallet"); }
            set { SetValueForObjectProperty("Pallet", value); }
            }

        [DataField(Description = "Описание", ReadOnly = true, ShowInList = true, Size = 500)]
        public string Description
            {
            get { return z_Description; }
            set
                {
                if ( z_Description == value )
                    {
                    return;
                    }
                z_Description = value;
                NotifyPropertyChanged("Description");
                }
            }
        private string z_Description;

        [DataField(Description = "Пользователь", ReadOnly = true, ShowInList = true, AllowOpenItem = true)]
        public Users User
            {
            get { return ( Users ) GetValueForObjectProperty("User"); }
            set { SetValueForObjectProperty("User", value); }
            }

        public Jornal()
            : base()
            {
            if ( Aramis.Platform.SystemAramis.CurrentUser != null )
                {
                User = ( Users ) Aramis.Platform.SystemAramis.CurrentUser;
                }
            }
        }
    }
