﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Склад
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
            "Название as \'Название\'",
            "Вместимость as \'Вместимость\'",
            "ВладелецСклада as \'Владелец склада\'",
            "ВладелецСклада.ФИО as \'ФИО\'"}, Hidden=new string[] {
            "ВладелецСклада.ФИО"})]
    [AssociatedDetailViewAttribute("СкладE", "ТоварНаСкладе", "ТоварНаСкладеE", true, "-Товары на складе", "Товар на складе", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("СкладE", "ВладелецСклада", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "ФИО")]
    [View("СкладL", new string[] {
            "Название as \'Название\'",
            "Вместимость as \'Вместимость\'",
            "ВладелецСклада.ФИО as \'ФИО\'"})]
    public class Склад : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private int fВместимость;
        
        private IIS.Склад.Личность fВладелецСклада;
        
        private IIS.Склад.DetailArrayOfТоварНаСкладе fТоварНаСкладе;
        
        // *** Start programmer edit section *** (Склад CustomMembers)

        // *** End programmer edit section *** (Склад CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Название CustomAttributes)

        // *** End programmer edit section *** (Склад.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Название Get start)

                // *** End programmer edit section *** (Склад.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Склад.Название Get end)

                // *** End programmer edit section *** (Склад.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Название Set start)

                // *** End programmer edit section *** (Склад.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Склад.Название Set end)

                // *** End programmer edit section *** (Склад.Название Set end)
            }
        }
        
        /// <summary>
        /// Вместимость.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Вместимость CustomAttributes)

        // *** End programmer edit section *** (Склад.Вместимость CustomAttributes)
        public virtual int Вместимость
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Вместимость Get start)

                // *** End programmer edit section *** (Склад.Вместимость Get start)
                int result = this.fВместимость;
                // *** Start programmer edit section *** (Склад.Вместимость Get end)

                // *** End programmer edit section *** (Склад.Вместимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Вместимость Set start)

                // *** End programmer edit section *** (Склад.Вместимость Set start)
                this.fВместимость = value;
                // *** Start programmer edit section *** (Склад.Вместимость Set end)

                // *** End programmer edit section *** (Склад.Вместимость Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ВладелецСклада CustomAttributes)

        // *** End programmer edit section *** (Склад.ВладелецСклада CustomAttributes)
        [PropertyStorage(new string[] {
                "ВладелецСклада"})]
        [NotNull()]
        public virtual IIS.Склад.Личность ВладелецСклада
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ВладелецСклада Get start)

                // *** End programmer edit section *** (Склад.ВладелецСклада Get start)
                IIS.Склад.Личность result = this.fВладелецСклада;
                // *** Start programmer edit section *** (Склад.ВладелецСклада Get end)

                // *** End programmer edit section *** (Склад.ВладелецСклада Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.ВладелецСклада Set start)

                // *** End programmer edit section *** (Склад.ВладелецСклада Set start)
                this.fВладелецСклада = value;
                // *** Start programmer edit section *** (Склад.ВладелецСклада Set end)

                // *** End programmer edit section *** (Склад.ВладелецСклада Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)
        public virtual IIS.Склад.DetailArrayOfТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get start)
                if ((this.fТоварНаСкладе == null))
                {
                    this.fТоварНаСкладе = new IIS.Склад.DetailArrayOfТоварНаСкладе(this);
                }
                IIS.Склад.DetailArrayOfТоварНаСкладе result = this.fТоварНаСкладе;
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
                    return ICSSoft.STORMNET.Information.GetView("СкладE", typeof(IIS.Склад.Склад));
                }
            }
            
            /// <summary>
            /// "СкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладL", typeof(IIS.Склад.Склад));
                }
            }
        }
    }
}
