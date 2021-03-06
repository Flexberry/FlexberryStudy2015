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
    /// Строка заказа.
    /// </summary>
    // *** Start programmer edit section *** (СтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (СтрокаЗаказа CustomAttributes)
    [AutoAltered()]
    [Caption("Строка заказа")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СтрокаЗаказаE", new string[] {
            "Количество as \'Количество\'",
            "ЦенаСНалогами as \'Цена с налогами\'",
            "Сумма as \'Сумма\'",
            "Товар as \'Товар\'",
            "Товар.Название as \'Название\'"}, Hidden=new string[] {
            "Товар.Название"})]
    [MasterViewDefineAttribute("СтрокаЗаказаE", "Товар", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class СтрокаЗаказа : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private double fЦенаСНалогами;
        
        private double fСумма;
        
        private IIS.АСУСклад.Товар fТовар;
        
        private IIS.АСУСклад.Заказ fЗаказ;
        
        // *** Start programmer edit section *** (СтрокаЗаказа CustomMembers)

        // *** End programmer edit section *** (СтрокаЗаказа CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Количество CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Количество Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Количество Set end)
            }
        }
        
        /// <summary>
        /// ЦенаСНалогами.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами CustomAttributes)
        public virtual double ЦенаСНалогами
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Get start)
                double result = this.fЦенаСНалогами;
                // *** Start programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Set start)
                this.fЦенаСНалогами = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.ЦенаСНалогами Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Сумма CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Сумма CustomAttributes)
        public virtual double Сумма
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Сумма Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Сумма Get start)
                double result = this.fСумма;
                // *** Start programmer edit section *** (СтрокаЗаказа.Сумма Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Сумма Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Сумма Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Строка заказа.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Товар CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Товар CustomAttributes)
        [PropertyStorage(new string[] {
                "Товар"})]
        [NotNull()]
        public virtual IIS.АСУСклад.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Get start)
                IIS.АСУСклад.Товар result = this.fТовар;
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Товар Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Товар Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУСклад.Заказ.
        /// </summary>
        // *** Start programmer edit section *** (СтрокаЗаказа.Заказ CustomAttributes)

        // *** End programmer edit section *** (СтрокаЗаказа.Заказ CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Заказ"})]
        public virtual IIS.АСУСклад.Заказ Заказ
        {
            get
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Get start)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Get start)
                IIS.АСУСклад.Заказ result = this.fЗаказ;
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Get end)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Set start)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Set start)
                this.fЗаказ = value;
                // *** Start programmer edit section *** (СтрокаЗаказа.Заказ Set end)

                // *** End programmer edit section *** (СтрокаЗаказа.Заказ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СтрокаЗаказаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтрокаЗаказаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтрокаЗаказаE", typeof(IIS.АСУСклад.СтрокаЗаказа));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of СтрокаЗаказа.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСтрокаЗаказа CustomAttributes)
    public class DetailArrayOfСтрокаЗаказа : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУСклад.DetailArrayOfСтрокаЗаказа members)

        // *** End programmer edit section *** (IIS.АСУСклад.DetailArrayOfСтрокаЗаказа members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type СтрокаЗаказа by index.
        /// </summary>
        /// <summary>
        /// Adds object with type СтрокаЗаказа.
        /// </summary>
        public DetailArrayOfСтрокаЗаказа(IIS.АСУСклад.Заказ fЗаказ) : 
                base(typeof(СтрокаЗаказа), ((ICSSoft.STORMNET.DataObject)(fЗаказ)))
        {
        }
        
        public IIS.АСУСклад.СтрокаЗаказа this[int index]
        {
            get
            {
                return ((IIS.АСУСклад.СтрокаЗаказа)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУСклад.СтрокаЗаказа dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
