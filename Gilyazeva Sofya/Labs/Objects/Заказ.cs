﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Заказ.
    /// </summary>
    // *** Start programmer edit section *** (Заказ CustomAttributes)

    // *** End programmer edit section *** (Заказ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказE", new string[] {
            "Статус as \'Статус\'",
            "ДатаОтгрузки as \'Дата отгрузки\'",
            "ДатаОплаты as \'Дата оплаты\'",
            "Цена as \'Цена\'",
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'",
            "Менеджер as \'Менеджер\'",
            "Менеджер.Фамилия as \'Фамилия\'"})]
    [AssociatedDetailViewAttribute("ЗаказE", "СтрокаЗаказа", "СтрокаЗаказаE", true, "", "Строка заказа", true, new string[] {
            ""})]
    [View("ЗаказL", new string[] {
            "Статус as \'Статус\'",
            "ДатаОтгрузки as \'Дата отгрузки\'",
            "ДатаОплаты as \'Дата оплаты\'",
            "Цена as \'Цена\'",
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'",
            "Менеджер.Фамилия as \'Фамилия\'"})]
    public class Заказ : IIS.АСУ_Склад.Документ
    {
        
        private IIS.АСУ_Склад.СостояниеЗаказа fСтатус;
        
        private System.DateTime fДатаОтгрузки;
        
        private System.DateTime fДатаОплаты;
        
        private IIS.АСУ_Склад.Сотрудник fМенеджер;
        
        private IIS.АСУ_Склад.DetailArrayOfСтрокаЗаказа fСтрокаЗаказа;
        
        // *** Start programmer edit section *** (Заказ CustomMembers)

        // *** End programmer edit section *** (Заказ CustomMembers)

        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Статус CustomAttributes)

        // *** End programmer edit section *** (Заказ.Статус CustomAttributes)
        public virtual IIS.АСУ_Склад.СостояниеЗаказа Статус
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Статус Get start)

                // *** End programmer edit section *** (Заказ.Статус Get start)
                IIS.АСУ_Склад.СостояниеЗаказа result = this.fСтатус;
                // *** Start programmer edit section *** (Заказ.Статус Get end)

                // *** End programmer edit section *** (Заказ.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Статус Set start)

                // *** End programmer edit section *** (Заказ.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (Заказ.Статус Set end)

                // *** End programmer edit section *** (Заказ.Статус Set end)
            }
        }
        
        /// <summary>
        /// ДатаОтгрузки.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.ДатаОтгрузки CustomAttributes)

        // *** End programmer edit section *** (Заказ.ДатаОтгрузки CustomAttributes)
        public virtual System.DateTime ДатаОтгрузки
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.ДатаОтгрузки Get start)

                // *** End programmer edit section *** (Заказ.ДатаОтгрузки Get start)
                System.DateTime result = this.fДатаОтгрузки;
                // *** Start programmer edit section *** (Заказ.ДатаОтгрузки Get end)

                // *** End programmer edit section *** (Заказ.ДатаОтгрузки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.ДатаОтгрузки Set start)

                // *** End programmer edit section *** (Заказ.ДатаОтгрузки Set start)
                this.fДатаОтгрузки = value;
                // *** Start programmer edit section *** (Заказ.ДатаОтгрузки Set end)

                // *** End programmer edit section *** (Заказ.ДатаОтгрузки Set end)
            }
        }
        
        /// <summary>
        /// ДатаОплаты.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.ДатаОплаты CustomAttributes)

        // *** End programmer edit section *** (Заказ.ДатаОплаты CustomAttributes)
        public virtual System.DateTime ДатаОплаты
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.ДатаОплаты Get start)

                // *** End programmer edit section *** (Заказ.ДатаОплаты Get start)
                System.DateTime result = this.fДатаОплаты;
                // *** Start programmer edit section *** (Заказ.ДатаОплаты Get end)

                // *** End programmer edit section *** (Заказ.ДатаОплаты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.ДатаОплаты Set start)

                // *** End programmer edit section *** (Заказ.ДатаОплаты Set start)
                this.fДатаОплаты = value;
                // *** Start programmer edit section *** (Заказ.ДатаОплаты Set end)

                // *** End programmer edit section *** (Заказ.ДатаОплаты Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Цена CustomAttributes)

        // *** End programmer edit section *** (Заказ.Цена CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual double Цена
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Цена Get)

                return 0;
                // *** End programmer edit section *** (Заказ.Цена Get)
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Цена Set)

                // *** End programmer edit section *** (Заказ.Цена Set)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Менеджер CustomAttributes)

        // *** End programmer edit section *** (Заказ.Менеджер CustomAttributes)
        [PropertyStorage(new string[] {
                "Менеджер"})]
        [NotNull()]
        public virtual IIS.АСУ_Склад.Сотрудник Менеджер
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Менеджер Get start)

                // *** End programmer edit section *** (Заказ.Менеджер Get start)
                IIS.АСУ_Склад.Сотрудник result = this.fМенеджер;
                // *** Start programmer edit section *** (Заказ.Менеджер Get end)

                // *** End programmer edit section *** (Заказ.Менеджер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Менеджер Set start)

                // *** End programmer edit section *** (Заказ.Менеджер Set start)
                this.fМенеджер = value;
                // *** Start programmer edit section *** (Заказ.Менеджер Set end)

                // *** End programmer edit section *** (Заказ.Менеджер Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.СтрокаЗаказа CustomAttributes)

        // *** End programmer edit section *** (Заказ.СтрокаЗаказа CustomAttributes)
        public virtual IIS.АСУ_Склад.DetailArrayOfСтрокаЗаказа СтрокаЗаказа
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.СтрокаЗаказа Get start)

                // *** End programmer edit section *** (Заказ.СтрокаЗаказа Get start)
                if ((this.fСтрокаЗаказа == null))
                {
                    this.fСтрокаЗаказа = new IIS.АСУ_Склад.DetailArrayOfСтрокаЗаказа(this);
                }
                IIS.АСУ_Склад.DetailArrayOfСтрокаЗаказа result = this.fСтрокаЗаказа;
                // *** Start programmer edit section *** (Заказ.СтрокаЗаказа Get end)

                // *** End programmer edit section *** (Заказ.СтрокаЗаказа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.СтрокаЗаказа Set start)

                // *** End programmer edit section *** (Заказ.СтрокаЗаказа Set start)
                this.fСтрокаЗаказа = value;
                // *** Start programmer edit section *** (Заказ.СтрокаЗаказа Set end)

                // *** End programmer edit section *** (Заказ.СтрокаЗаказа Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказE", typeof(IIS.АСУ_Склад.Заказ));
                }
            }
            
            /// <summary>
            /// "ЗаказL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказL", typeof(IIS.АСУ_Склад.Заказ));
                }
            }
        }
    }
}
