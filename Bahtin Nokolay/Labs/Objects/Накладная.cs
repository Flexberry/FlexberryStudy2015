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
    /// Накладная.
    /// </summary>
    // *** Start programmer edit section *** (Накладная CustomAttributes)

    // *** End programmer edit section *** (Накладная CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("НакладнаяE", new string[] {
            "Статус as \'Статус\'",
            "ДатаВремяОтгрузки as \'Дата время отгрузки\'",
            "Сумма as \'Сумма\'",
            "Примечания as \'Примечания\'",
            "ФИОПолучателя as \'Ф и о получателя\'",
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'",
            "Заказ as \'Заказ\'",
            "Заказ.Статус as \'Статус\'",
            "МатериальноОтветственноеЛицо as \'Материально ответственное лицо\'",
            "МатериальноОтветственноеЛицо.Фамилия as \'Фамилия\'"})]
    [AssociatedDetailViewAttribute("НакладнаяE", "ЗаписьВНакладной", "ЗаписьВНакладнойE", true, "", "Запись в накладной", true, new string[] {
            ""})]
    [View("НакладнаяL", new string[] {
            "Статус as \'Статус\'",
            "ДатаВремяОтгрузки as \'Дата время отгрузки\'",
            "Сумма as \'Сумма\'",
            "Примечания as \'Примечания\'",
            "ФИОПолучателя as \'Ф и о получателя\'",
            "Номер as \'Номер\'",
            "ДатаЗаполнения as \'Дата заполнения\'",
            "Заказ.Статус as \'Статус\'",
            "МатериальноОтветственноеЛицо.Фамилия as \'Фамилия\'"})]
    public class Накладная : IIS.АСУ_Склад.Документ
    {
        
        private IIS.АСУ_Склад.СостояниеНакладной fСтатус;
        
        private System.DateTime fДатаВремяОтгрузки;
        
        private double fСумма;
        
        private string fПримечания;
        
        private string fФИОПолучателя;
        
        private IIS.АСУ_Склад.Заказ fЗаказ;
        
        private IIS.АСУ_Склад.Сотрудник fМатериальноОтветственноеЛицо;
        
        private IIS.АСУ_Склад.DetailArrayOfЗаписьВНакладной fЗаписьВНакладной;
        
        // *** Start programmer edit section *** (Накладная CustomMembers)

        // *** End programmer edit section *** (Накладная CustomMembers)

        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.Статус CustomAttributes)

        // *** End programmer edit section *** (Накладная.Статус CustomAttributes)
        public virtual IIS.АСУ_Склад.СостояниеНакладной Статус
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.Статус Get start)

                // *** End programmer edit section *** (Накладная.Статус Get start)
                IIS.АСУ_Склад.СостояниеНакладной result = this.fСтатус;
                // *** Start programmer edit section *** (Накладная.Статус Get end)

                // *** End programmer edit section *** (Накладная.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.Статус Set start)

                // *** End programmer edit section *** (Накладная.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (Накладная.Статус Set end)

                // *** End programmer edit section *** (Накладная.Статус Set end)
            }
        }
        
        /// <summary>
        /// ДатаВремяОтгрузки.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.ДатаВремяОтгрузки CustomAttributes)

        // *** End programmer edit section *** (Накладная.ДатаВремяОтгрузки CustomAttributes)
        public virtual System.DateTime ДатаВремяОтгрузки
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.ДатаВремяОтгрузки Get start)

                // *** End programmer edit section *** (Накладная.ДатаВремяОтгрузки Get start)
                System.DateTime result = this.fДатаВремяОтгрузки;
                // *** Start programmer edit section *** (Накладная.ДатаВремяОтгрузки Get end)

                // *** End programmer edit section *** (Накладная.ДатаВремяОтгрузки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.ДатаВремяОтгрузки Set start)

                // *** End programmer edit section *** (Накладная.ДатаВремяОтгрузки Set start)
                this.fДатаВремяОтгрузки = value;
                // *** Start programmer edit section *** (Накладная.ДатаВремяОтгрузки Set end)

                // *** End programmer edit section *** (Накладная.ДатаВремяОтгрузки Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.Сумма CustomAttributes)

        // *** End programmer edit section *** (Накладная.Сумма CustomAttributes)
        public virtual double Сумма
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.Сумма Get start)

                // *** End programmer edit section *** (Накладная.Сумма Get start)
                double result = this.fСумма;
                // *** Start programmer edit section *** (Накладная.Сумма Get end)

                // *** End programmer edit section *** (Накладная.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.Сумма Set start)

                // *** End programmer edit section *** (Накладная.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (Накладная.Сумма Set end)

                // *** End programmer edit section *** (Накладная.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Примечания.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.Примечания CustomAttributes)

        // *** End programmer edit section *** (Накладная.Примечания CustomAttributes)
        [StrLen(255)]
        public virtual string Примечания
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.Примечания Get start)

                // *** End programmer edit section *** (Накладная.Примечания Get start)
                string result = this.fПримечания;
                // *** Start programmer edit section *** (Накладная.Примечания Get end)

                // *** End programmer edit section *** (Накладная.Примечания Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.Примечания Set start)

                // *** End programmer edit section *** (Накладная.Примечания Set start)
                this.fПримечания = value;
                // *** Start programmer edit section *** (Накладная.Примечания Set end)

                // *** End programmer edit section *** (Накладная.Примечания Set end)
            }
        }
        
        /// <summary>
        /// ФИОПолучателя.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.ФИОПолучателя CustomAttributes)

        // *** End programmer edit section *** (Накладная.ФИОПолучателя CustomAttributes)
        [StrLen(255)]
        public virtual string ФИОПолучателя
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.ФИОПолучателя Get start)

                // *** End programmer edit section *** (Накладная.ФИОПолучателя Get start)
                string result = this.fФИОПолучателя;
                // *** Start programmer edit section *** (Накладная.ФИОПолучателя Get end)

                // *** End programmer edit section *** (Накладная.ФИОПолучателя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.ФИОПолучателя Set start)

                // *** End programmer edit section *** (Накладная.ФИОПолучателя Set start)
                this.fФИОПолучателя = value;
                // *** Start programmer edit section *** (Накладная.ФИОПолучателя Set end)

                // *** End programmer edit section *** (Накладная.ФИОПолучателя Set end)
            }
        }
        
        /// <summary>
        /// Накладная.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.Заказ CustomAttributes)

        // *** End programmer edit section *** (Накладная.Заказ CustomAttributes)
        [PropertyStorage(new string[] {
                "Заказ"})]
        [NotNull()]
        public virtual IIS.АСУ_Склад.Заказ Заказ
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.Заказ Get start)

                // *** End programmer edit section *** (Накладная.Заказ Get start)
                IIS.АСУ_Склад.Заказ result = this.fЗаказ;
                // *** Start programmer edit section *** (Накладная.Заказ Get end)

                // *** End programmer edit section *** (Накладная.Заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.Заказ Set start)

                // *** End programmer edit section *** (Накладная.Заказ Set start)
                this.fЗаказ = value;
                // *** Start programmer edit section *** (Накладная.Заказ Set end)

                // *** End programmer edit section *** (Накладная.Заказ Set end)
            }
        }
        
        /// <summary>
        /// Накладная.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.МатериальноОтветственноеЛицо CustomAttributes)

        // *** End programmer edit section *** (Накладная.МатериальноОтветственноеЛицо CustomAttributes)
        [PropertyStorage(new string[] {
                "МатериальноОтветственноеЛицо"})]
        [NotNull()]
        public virtual IIS.АСУ_Склад.Сотрудник МатериальноОтветственноеЛицо
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Get start)

                // *** End programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Get start)
                IIS.АСУ_Склад.Сотрудник result = this.fМатериальноОтветственноеЛицо;
                // *** Start programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Get end)

                // *** End programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Set start)

                // *** End programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Set start)
                this.fМатериальноОтветственноеЛицо = value;
                // *** Start programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Set end)

                // *** End programmer edit section *** (Накладная.МатериальноОтветственноеЛицо Set end)
            }
        }
        
        /// <summary>
        /// Накладная.
        /// </summary>
        // *** Start programmer edit section *** (Накладная.ЗаписьВНакладной CustomAttributes)

        // *** End programmer edit section *** (Накладная.ЗаписьВНакладной CustomAttributes)
        public virtual IIS.АСУ_Склад.DetailArrayOfЗаписьВНакладной ЗаписьВНакладной
        {
            get
            {
                // *** Start programmer edit section *** (Накладная.ЗаписьВНакладной Get start)

                // *** End programmer edit section *** (Накладная.ЗаписьВНакладной Get start)
                if ((this.fЗаписьВНакладной == null))
                {
                    this.fЗаписьВНакладной = new IIS.АСУ_Склад.DetailArrayOfЗаписьВНакладной(this);
                }
                IIS.АСУ_Склад.DetailArrayOfЗаписьВНакладной result = this.fЗаписьВНакладной;
                // *** Start programmer edit section *** (Накладная.ЗаписьВНакладной Get end)

                // *** End programmer edit section *** (Накладная.ЗаписьВНакладной Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Накладная.ЗаписьВНакладной Set start)

                // *** End programmer edit section *** (Накладная.ЗаписьВНакладной Set start)
                this.fЗаписьВНакладной = value;
                // *** Start programmer edit section *** (Накладная.ЗаписьВНакладной Set end)

                // *** End programmer edit section *** (Накладная.ЗаписьВНакладной Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "НакладнаяE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View НакладнаяE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("НакладнаяE", typeof(IIS.АСУ_Склад.Накладная));
                }
            }
            
            /// <summary>
            /// "НакладнаяL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View НакладнаяL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("НакладнаяL", typeof(IIS.АСУ_Склад.Накладная));
                }
            }
        }
    }
}
