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
    /// Платёжка.
    /// </summary>
    // *** Start programmer edit section *** (Платёжка CustomAttributes)

    // *** End programmer edit section *** (Платёжка CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПлатёжкаE", new string[] {
            "Дата as \'Дата\'"})]
    [AssociatedDetailViewAttribute("ПлатёжкаE", "СтрокаИзПлатёжки", "СтрокаИзПлатёжкиE", true, "", "Строка из платёжки", true, new string[] {
            ""})]
    [View("ПлатёжкаL", new string[] {
            "Дата as \'Дата\'"})]
    [AssociatedDetailViewAttribute("ПлатёжкаL", "СтрокаИзПлатёжки", "СтрокаИзПлатёжкиE", true, "", "", false, new string[] {
            ""})]
    public class Платёжка : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private IIS.Электронный_Магазин.DetailArrayOfСтрокаИзПлатёжки fСтрокаИзПлатёжки;
        
        // *** Start programmer edit section *** (Платёжка CustomMembers)

        // *** End programmer edit section *** (Платёжка CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Платёжка.Дата CustomAttributes)

        // *** End programmer edit section *** (Платёжка.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Платёжка.Дата Get start)

                // *** End programmer edit section *** (Платёжка.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Платёжка.Дата Get end)

                // *** End programmer edit section *** (Платёжка.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Платёжка.Дата Set start)

                // *** End programmer edit section *** (Платёжка.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Платёжка.Дата Set end)

                // *** End programmer edit section *** (Платёжка.Дата Set end)
            }
        }
        
        /// <summary>
        /// Платёжка.
        /// </summary>
        // *** Start programmer edit section *** (Платёжка.СтрокаИзПлатёжки CustomAttributes)

        // *** End programmer edit section *** (Платёжка.СтрокаИзПлатёжки CustomAttributes)
        public virtual IIS.Электронный_Магазин.DetailArrayOfСтрокаИзПлатёжки СтрокаИзПлатёжки
        {
            get
            {
                // *** Start programmer edit section *** (Платёжка.СтрокаИзПлатёжки Get start)

                // *** End programmer edit section *** (Платёжка.СтрокаИзПлатёжки Get start)
                if ((this.fСтрокаИзПлатёжки == null))
                {
                    this.fСтрокаИзПлатёжки = new IIS.Электронный_Магазин.DetailArrayOfСтрокаИзПлатёжки(this);
                }
                IIS.Электронный_Магазин.DetailArrayOfСтрокаИзПлатёжки result = this.fСтрокаИзПлатёжки;
                // *** Start programmer edit section *** (Платёжка.СтрокаИзПлатёжки Get end)

                // *** End programmer edit section *** (Платёжка.СтрокаИзПлатёжки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Платёжка.СтрокаИзПлатёжки Set start)

                // *** End programmer edit section *** (Платёжка.СтрокаИзПлатёжки Set start)
                this.fСтрокаИзПлатёжки = value;
                // *** Start programmer edit section *** (Платёжка.СтрокаИзПлатёжки Set end)

                // *** End programmer edit section *** (Платёжка.СтрокаИзПлатёжки Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПлатёжкаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПлатёжкаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПлатёжкаE", typeof(IIS.Электронный_Магазин.Платёжка));
                }
            }
            
            /// <summary>
            /// "ПлатёжкаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПлатёжкаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПлатёжкаL", typeof(IIS.Электронный_Магазин.Платёжка));
                }
            }
        }
    }
}
