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
    /// Документ.
    /// </summary>
    // *** Start programmer edit section *** (Документ CustomAttributes)

    // *** End programmer edit section *** (Документ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокументE", new string[] {
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'"})]
    [View("ДокументL", new string[] {
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'"})]
    public class Документ : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private System.DateTime fДатаЗаполнения = System.DateTime.Now;
        
        // *** Start programmer edit section *** (Документ CustomMembers)

        // *** End programmer edit section *** (Документ CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Документ.Номер CustomAttributes)

        // *** End programmer edit section *** (Документ.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Документ.Номер Get start)

                // *** End programmer edit section *** (Документ.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Документ.Номер Get end)

                // *** End programmer edit section *** (Документ.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Документ.Номер Set start)

                // *** End programmer edit section *** (Документ.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Документ.Номер Set end)

                // *** End programmer edit section *** (Документ.Номер Set end)
            }
        }
        
        /// <summary>
        /// ДатаЗаполнения.
        /// </summary>
        // *** Start programmer edit section *** (Документ.ДатаЗаполнения CustomAttributes)

        // *** End programmer edit section *** (Документ.ДатаЗаполнения CustomAttributes)
        public virtual System.DateTime ДатаЗаполнения
        {
            get
            {
                // *** Start programmer edit section *** (Документ.ДатаЗаполнения Get start)

                // *** End programmer edit section *** (Документ.ДатаЗаполнения Get start)
                System.DateTime result = this.fДатаЗаполнения;
                // *** Start programmer edit section *** (Документ.ДатаЗаполнения Get end)

                // *** End programmer edit section *** (Документ.ДатаЗаполнения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Документ.ДатаЗаполнения Set start)

                // *** End programmer edit section *** (Документ.ДатаЗаполнения Set start)
                this.fДатаЗаполнения = value;
                // *** Start programmer edit section *** (Документ.ДатаЗаполнения Set end)

                // *** End programmer edit section *** (Документ.ДатаЗаполнения Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокументE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументE", typeof(IIS.АСУСклад.Документ));
                }
            }
            
            /// <summary>
            /// "ДокументL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументL", typeof(IIS.АСУСклад.Документ));
                }
            }
        }
    }
}
