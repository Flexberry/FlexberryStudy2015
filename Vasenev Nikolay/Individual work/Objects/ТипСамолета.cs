﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Авиакомпания
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Тип самолета.
    /// </summary>
    // *** Start programmer edit section *** (ТипСамолета CustomAttributes)

    // *** End programmer edit section *** (ТипСамолета CustomAttributes)
    [AutoAltered()]
    [Caption("Тип самолета")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Dvigateli", new string[] {
            "Название",
            "Код",
            "КоличествоДвигателей"})]
    [View("Mesta", new string[] {
            "Название",
            "Код",
            "КоличествоМест as \'Количество мест\'"})]
    [View("ТипСамолетаE", new string[] {
            "Название as \'Название\'",
            "Код as \'Код\'",
            "КоличествоДвигателей as \'Количество двигателей\'",
            "КоличествоМест as \'Количество мест\'",
            "Масса"})]
    [View("ТипСамолетаL", new string[] {
            "Название as \'Название\'",
            "Код as \'Код\'"})]
    public class ТипСамолета : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private string fКод;
        
        private int fМасса;
        
        private int fКоличествоДвигателей;
        
        private int fКоличествоМест;
        
        // *** Start programmer edit section *** (ТипСамолета CustomMembers)

        // *** End programmer edit section *** (ТипСамолета CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (ТипСамолета.Название CustomAttributes)

        // *** End programmer edit section *** (ТипСамолета.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (ТипСамолета.Название Get start)

                // *** End programmer edit section *** (ТипСамолета.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (ТипСамолета.Название Get end)

                // *** End programmer edit section *** (ТипСамолета.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипСамолета.Название Set start)

                // *** End programmer edit section *** (ТипСамолета.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (ТипСамолета.Название Set end)

                // *** End programmer edit section *** (ТипСамолета.Название Set end)
            }
        }
        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (ТипСамолета.Код CustomAttributes)

        // *** End programmer edit section *** (ТипСамолета.Код CustomAttributes)
        [StrLen(255)]
        public virtual string Код
        {
            get
            {
                // *** Start programmer edit section *** (ТипСамолета.Код Get start)

                // *** End programmer edit section *** (ТипСамолета.Код Get start)
                string result = this.fКод;
                // *** Start programmer edit section *** (ТипСамолета.Код Get end)

                // *** End programmer edit section *** (ТипСамолета.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипСамолета.Код Set start)

                // *** End programmer edit section *** (ТипСамолета.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (ТипСамолета.Код Set end)

                // *** End programmer edit section *** (ТипСамолета.Код Set end)
            }
        }
        
        /// <summary>
        /// Масса.
        /// </summary>
        // *** Start programmer edit section *** (ТипСамолета.Масса CustomAttributes)

        // *** End programmer edit section *** (ТипСамолета.Масса CustomAttributes)
        public virtual int Масса
        {
            get
            {
                // *** Start programmer edit section *** (ТипСамолета.Масса Get start)

                // *** End programmer edit section *** (ТипСамолета.Масса Get start)
                int result = this.fМасса;
                // *** Start programmer edit section *** (ТипСамолета.Масса Get end)

                // *** End programmer edit section *** (ТипСамолета.Масса Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипСамолета.Масса Set start)

                // *** End programmer edit section *** (ТипСамолета.Масса Set start)
                this.fМасса = value;
                // *** Start programmer edit section *** (ТипСамолета.Масса Set end)

                // *** End programmer edit section *** (ТипСамолета.Масса Set end)
            }
        }
        
        /// <summary>
        /// КоличествоДвигателей.
        /// </summary>
        // *** Start programmer edit section *** (ТипСамолета.КоличествоДвигателей CustomAttributes)

        // *** End programmer edit section *** (ТипСамолета.КоличествоДвигателей CustomAttributes)
        public virtual int КоличествоДвигателей
        {
            get
            {
                // *** Start programmer edit section *** (ТипСамолета.КоличествоДвигателей Get start)

                // *** End programmer edit section *** (ТипСамолета.КоличествоДвигателей Get start)
                int result = this.fКоличествоДвигателей;
                // *** Start programmer edit section *** (ТипСамолета.КоличествоДвигателей Get end)

                // *** End programmer edit section *** (ТипСамолета.КоличествоДвигателей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипСамолета.КоличествоДвигателей Set start)

                // *** End programmer edit section *** (ТипСамолета.КоличествоДвигателей Set start)
                this.fКоличествоДвигателей = value;
                // *** Start programmer edit section *** (ТипСамолета.КоличествоДвигателей Set end)

                // *** End programmer edit section *** (ТипСамолета.КоличествоДвигателей Set end)
            }
        }
        
        /// <summary>
        /// КоличествоМест.
        /// </summary>
        // *** Start programmer edit section *** (ТипСамолета.КоличествоМест CustomAttributes)

        // *** End programmer edit section *** (ТипСамолета.КоличествоМест CustomAttributes)
        public virtual int КоличествоМест
        {
            get
            {
                // *** Start programmer edit section *** (ТипСамолета.КоличествоМест Get start)

                // *** End programmer edit section *** (ТипСамолета.КоличествоМест Get start)
                int result = this.fКоличествоМест;
                // *** Start programmer edit section *** (ТипСамолета.КоличествоМест Get end)

                // *** End programmer edit section *** (ТипСамолета.КоличествоМест Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипСамолета.КоличествоМест Set start)

                // *** End programmer edit section *** (ТипСамолета.КоличествоМест Set start)
                this.fКоличествоМест = value;
                // *** Start programmer edit section *** (ТипСамолета.КоличествоМест Set end)

                // *** End programmer edit section *** (ТипСамолета.КоличествоМест Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Dvigateli" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Dvigateli
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Dvigateli", typeof(IIS.Авиакомпания.ТипСамолета));
                }
            }
            
            /// <summary>
            /// "Mesta" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Mesta
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Mesta", typeof(IIS.Авиакомпания.ТипСамолета));
                }
            }
            
            /// <summary>
            /// "ТипСамолетаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипСамолетаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипСамолетаE", typeof(IIS.Авиакомпания.ТипСамолета));
                }
            }
            
            /// <summary>
            /// "ТипСамолетаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипСамолетаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипСамолетаL", typeof(IIS.Авиакомпания.ТипСамолета));
                }
            }
        }
    }
}
