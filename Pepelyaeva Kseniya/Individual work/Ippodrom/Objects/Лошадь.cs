﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Ippodrom
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Лошадь.
    /// </summary>
    // *** Start programmer edit section *** (Лошадь CustomAttributes)

    // *** End programmer edit section *** (Лошадь CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЛошадьE", new string[] {
            "Кличка as \'Кличка\'",
            "Жокей as \'Жокей\'",
            "Конюшня"})]
    [AssociatedDetailViewAttribute("ЛошадьE", "ЛошадьВСостязании", "ЛошадьВСостязанииE", true, "", "", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ЛошадьE", "Жокей", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [MasterViewDefineAttribute("ЛошадьE", "Конюшня", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("ЛошадьL", new string[] {
            "Кличка as \'Кличка\'",
            "Жокей.Фамилия as \'Фамилия\'",
            "Конюшня.Название as \'Название\'"})]
    public class Лошадь : ICSSoft.STORMNET.DataObject
    {
        
        private string fКличка;
        
        private IIS.Ippodrom.Жокей fЖокей;
        
        private IIS.Ippodrom.Конюшня fКонюшня;
        
        private IIS.Ippodrom.DetailArrayOfЛошадьВСостязании fЛошадьВСостязании;
        
        // *** Start programmer edit section *** (Лошадь CustomMembers)

        // *** End programmer edit section *** (Лошадь CustomMembers)

        
        /// <summary>
        /// Кличка.
        /// </summary>
        // *** Start programmer edit section *** (Лошадь.Кличка CustomAttributes)

        // *** End programmer edit section *** (Лошадь.Кличка CustomAttributes)
        [StrLen(255)]
        public virtual string Кличка
        {
            get
            {
                // *** Start programmer edit section *** (Лошадь.Кличка Get start)

                // *** End programmer edit section *** (Лошадь.Кличка Get start)
                string result = this.fКличка;
                // *** Start programmer edit section *** (Лошадь.Кличка Get end)

                // *** End programmer edit section *** (Лошадь.Кличка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лошадь.Кличка Set start)

                // *** End programmer edit section *** (Лошадь.Кличка Set start)
                this.fКличка = value;
                // *** Start programmer edit section *** (Лошадь.Кличка Set end)

                // *** End programmer edit section *** (Лошадь.Кличка Set end)
            }
        }
        
        /// <summary>
        /// Лошадь.
        /// </summary>
        // *** Start programmer edit section *** (Лошадь.Жокей CustomAttributes)

        // *** End programmer edit section *** (Лошадь.Жокей CustomAttributes)
        [PropertyStorage(new string[] {
                "Жокей"})]
        [NotNull()]
        public virtual IIS.Ippodrom.Жокей Жокей
        {
            get
            {
                // *** Start programmer edit section *** (Лошадь.Жокей Get start)

                // *** End programmer edit section *** (Лошадь.Жокей Get start)
                IIS.Ippodrom.Жокей result = this.fЖокей;
                // *** Start programmer edit section *** (Лошадь.Жокей Get end)

                // *** End programmer edit section *** (Лошадь.Жокей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лошадь.Жокей Set start)

                // *** End programmer edit section *** (Лошадь.Жокей Set start)
                this.fЖокей = value;
                // *** Start programmer edit section *** (Лошадь.Жокей Set end)

                // *** End programmer edit section *** (Лошадь.Жокей Set end)
            }
        }
        
        /// <summary>
        /// Лошадь.
        /// </summary>
        // *** Start programmer edit section *** (Лошадь.Конюшня CustomAttributes)

        // *** End programmer edit section *** (Лошадь.Конюшня CustomAttributes)
        [PropertyStorage(new string[] {
                "Конюшня"})]
        [NotNull()]
        public virtual IIS.Ippodrom.Конюшня Конюшня
        {
            get
            {
                // *** Start programmer edit section *** (Лошадь.Конюшня Get start)

                // *** End programmer edit section *** (Лошадь.Конюшня Get start)
                IIS.Ippodrom.Конюшня result = this.fКонюшня;
                // *** Start programmer edit section *** (Лошадь.Конюшня Get end)

                // *** End programmer edit section *** (Лошадь.Конюшня Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лошадь.Конюшня Set start)

                // *** End programmer edit section *** (Лошадь.Конюшня Set start)
                this.fКонюшня = value;
                // *** Start programmer edit section *** (Лошадь.Конюшня Set end)

                // *** End programmer edit section *** (Лошадь.Конюшня Set end)
            }
        }
        
        /// <summary>
        /// Лошадь.
        /// </summary>
        // *** Start programmer edit section *** (Лошадь.ЛошадьВСостязании CustomAttributes)

        // *** End programmer edit section *** (Лошадь.ЛошадьВСостязании CustomAttributes)
        public virtual IIS.Ippodrom.DetailArrayOfЛошадьВСостязании ЛошадьВСостязании
        {
            get
            {
                // *** Start programmer edit section *** (Лошадь.ЛошадьВСостязании Get start)

                // *** End programmer edit section *** (Лошадь.ЛошадьВСостязании Get start)
                if ((this.fЛошадьВСостязании == null))
                {
                    this.fЛошадьВСостязании = new IIS.Ippodrom.DetailArrayOfЛошадьВСостязании(this);
                }
                IIS.Ippodrom.DetailArrayOfЛошадьВСостязании result = this.fЛошадьВСостязании;
                // *** Start programmer edit section *** (Лошадь.ЛошадьВСостязании Get end)

                // *** End programmer edit section *** (Лошадь.ЛошадьВСостязании Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Лошадь.ЛошадьВСостязании Set start)

                // *** End programmer edit section *** (Лошадь.ЛошадьВСостязании Set start)
                this.fЛошадьВСостязании = value;
                // *** Start programmer edit section *** (Лошадь.ЛошадьВСостязании Set end)

                // *** End programmer edit section *** (Лошадь.ЛошадьВСостязании Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЛошадьE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛошадьE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛошадьE", typeof(IIS.Ippodrom.Лошадь));
                }
            }
            
            /// <summary>
            /// "ЛошадьL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛошадьL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛошадьL", typeof(IIS.Ippodrom.Лошадь));
                }
            }
        }
    }
}
