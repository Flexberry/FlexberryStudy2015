﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУСклад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склад.
    /// </summary>
    // *** Start programmer edit section *** (Склад CustomAttributes)

    // *** End programmer edit section *** (Склад CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СкладE", new string[] {
            "Номер as \'Номер\'",
            "Адрес as \'Адрес\'",
            "Кладовщик as \'Кладовщик\'",
            "Кладовщик.Фамилия as \'Фамилия\'"})]
    [AssociatedDetailViewAttribute("СкладE", "ТоварНаСкладе", "ТоварНаСкладеE", true, "", "Товар на складе", true, new string[] {
            ""})]
    [View("СкладL", new string[] {
            "Номер as \'Номер\'",
            "Адрес as \'Адрес\'",
            "Кладовщик.Фамилия as \'Фамилия\'"})]
    public class Склад : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private string fАдрес;
        
        private IIS.АСУСклад.Сотрудник fКладовщик;
        
        private IIS.АСУСклад.DetailArrayOfТоварНаСкладе fТоварНаСкладе;
        
        // *** Start programmer edit section *** (Склад CustomMembers)

        // *** End programmer edit section *** (Склад CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Номер CustomAttributes)

        // *** End programmer edit section *** (Склад.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Номер Get start)

                // *** End programmer edit section *** (Склад.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Склад.Номер Get end)

                // *** End programmer edit section *** (Склад.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Номер Set start)

                // *** End programmer edit section *** (Склад.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Склад.Номер Set end)

                // *** End programmer edit section *** (Склад.Номер Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Адрес CustomAttributes)

        // *** End programmer edit section *** (Склад.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Адрес Get start)

                // *** End programmer edit section *** (Склад.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Склад.Адрес Get end)

                // *** End programmer edit section *** (Склад.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Адрес Set start)

                // *** End programmer edit section *** (Склад.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Склад.Адрес Set end)

                // *** End programmer edit section *** (Склад.Адрес Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Кладовщик CustomAttributes)

        // *** End programmer edit section *** (Склад.Кладовщик CustomAttributes)
        [PropertyStorage(new string[] {
                "Кладовщик"})]
        [NotNull()]
        public virtual IIS.АСУСклад.Сотрудник Кладовщик
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Кладовщик Get start)

                // *** End programmer edit section *** (Склад.Кладовщик Get start)
                IIS.АСУСклад.Сотрудник result = this.fКладовщик;
                // *** Start programmer edit section *** (Склад.Кладовщик Get end)

                // *** End programmer edit section *** (Склад.Кладовщик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Кладовщик Set start)

                // *** End programmer edit section *** (Склад.Кладовщик Set start)
                this.fКладовщик = value;
                // *** Start programmer edit section *** (Склад.Кладовщик Set end)

                // *** End programmer edit section *** (Склад.Кладовщик Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)
        public virtual IIS.АСУСклад.DetailArrayOfТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get start)
                if ((this.fТоварНаСкладе == null))
                {
                    this.fТоварНаСкладе = new IIS.АСУСклад.DetailArrayOfТоварНаСкладе(this);
                }
                IIS.АСУСклад.DetailArrayOfТоварНаСкладе result = this.fТоварНаСкладе;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set start)
                this.fТоварНаСкладе = value;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СкладE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладE", typeof(IIS.АСУСклад.Склад));
                }
            }
            
            /// <summary>
            /// "СкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладL", typeof(IIS.АСУСклад.Склад));
                }
            }
        }
    }
}
