﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Электронный_Магазин
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ПоступлениеТовара.
    /// </summary>
    // *** Start programmer edit section *** (ПоступлениеТовара CustomAttributes)

    // *** End programmer edit section *** (ПоступлениеТовара CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПоступлениеТовараE", new string[] {
            "Количество as \'Количество\'",
            "Стоимость as \'Стоимость\'",
            "Товар as \'Товар\'",
            "ДатаПоступления as \'Дата поступления\'",
            "Товар.Код",
            "Товар.Наименование"}, Hidden=new string[] {
            "Товар.Код",
            "Товар.Наименование"})]
    [MasterViewDefineAttribute("ПоступлениеТовараE", "Товар", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("ПоступлениеТовараL", new string[] {
            "Количество as \'Количество\'",
            "Стоимость as \'Стоимость\'",
            "Товар.Наименование as \'Наименование\'",
            "ДатаПоступления as \'Дата поступления\'"})]
    public class ПоступлениеТовара : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private double fСтоимость;
        
        private System.DateTime fДатаПоступления;
        
        private IIS.Электронный_Магазин.Товар fТовар;
        
        // *** Start programmer edit section *** (ПоступлениеТовара CustomMembers)

        // *** End programmer edit section *** (ПоступлениеТовара CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (ПоступлениеТовара.Количество CustomAttributes)

        // *** End programmer edit section *** (ПоступлениеТовара.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Количество Get start)

                // *** End programmer edit section *** (ПоступлениеТовара.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (ПоступлениеТовара.Количество Get end)

                // *** End programmer edit section *** (ПоступлениеТовара.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Количество Set start)

                // *** End programmer edit section *** (ПоступлениеТовара.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (ПоступлениеТовара.Количество Set end)

                // *** End programmer edit section *** (ПоступлениеТовара.Количество Set end)
            }
        }
        
        /// <summary>
        /// Стоимость.
        /// </summary>
        // *** Start programmer edit section *** (ПоступлениеТовара.Стоимость CustomAttributes)

        // *** End programmer edit section *** (ПоступлениеТовара.Стоимость CustomAttributes)
        public virtual double Стоимость
        {
            get
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Стоимость Get start)

                // *** End programmer edit section *** (ПоступлениеТовара.Стоимость Get start)
                double result = this.fСтоимость;
                // *** Start programmer edit section *** (ПоступлениеТовара.Стоимость Get end)

                // *** End programmer edit section *** (ПоступлениеТовара.Стоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Стоимость Set start)

                // *** End programmer edit section *** (ПоступлениеТовара.Стоимость Set start)
                this.fСтоимость = value;
                // *** Start programmer edit section *** (ПоступлениеТовара.Стоимость Set end)

                // *** End programmer edit section *** (ПоступлениеТовара.Стоимость Set end)
            }
        }
        
        /// <summary>
        /// ДатаПоступления.
        /// </summary>
        // *** Start programmer edit section *** (ПоступлениеТовара.ДатаПоступления CustomAttributes)

        // *** End programmer edit section *** (ПоступлениеТовара.ДатаПоступления CustomAttributes)
        public virtual System.DateTime ДатаПоступления
        {
            get
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.ДатаПоступления Get start)

                // *** End programmer edit section *** (ПоступлениеТовара.ДатаПоступления Get start)
                System.DateTime result = this.fДатаПоступления;
                // *** Start programmer edit section *** (ПоступлениеТовара.ДатаПоступления Get end)

                // *** End programmer edit section *** (ПоступлениеТовара.ДатаПоступления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.ДатаПоступления Set start)

                // *** End programmer edit section *** (ПоступлениеТовара.ДатаПоступления Set start)
                this.fДатаПоступления = value;
                // *** Start programmer edit section *** (ПоступлениеТовара.ДатаПоступления Set end)

                // *** End programmer edit section *** (ПоступлениеТовара.ДатаПоступления Set end)
            }
        }
        
        /// <summary>
        /// ПоступлениеТовара.
        /// </summary>
        // *** Start programmer edit section *** (ПоступлениеТовара.Товар CustomAttributes)

        // *** End programmer edit section *** (ПоступлениеТовара.Товар CustomAttributes)
        [PropertyStorage(new string[] {
                "Товар"})]
        [NotNull()]
        public virtual IIS.Электронный_Магазин.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Товар Get start)

                // *** End programmer edit section *** (ПоступлениеТовара.Товар Get start)
                IIS.Электронный_Магазин.Товар result = this.fТовар;
                // *** Start programmer edit section *** (ПоступлениеТовара.Товар Get end)

                // *** End programmer edit section *** (ПоступлениеТовара.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПоступлениеТовара.Товар Set start)

                // *** End programmer edit section *** (ПоступлениеТовара.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (ПоступлениеТовара.Товар Set end)

                // *** End programmer edit section *** (ПоступлениеТовара.Товар Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПоступлениеТовараE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПоступлениеТовараE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПоступлениеТовараE", typeof(IIS.Электронный_Магазин.ПоступлениеТовара));
                }
            }
            
            /// <summary>
            /// "ПоступлениеТовараL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПоступлениеТовараL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПоступлениеТовараL", typeof(IIS.Электронный_Магазин.ПоступлениеТовара));
                }
            }
        }
    }
}
