﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Individual_work_1
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Автомашина.
    /// </summary>
    // *** Start programmer edit section *** (Автомашина CustomAttributes)

    // *** End programmer edit section *** (Автомашина CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("АвтомашинаE", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность (в тоннах)\'",
            "ВладелецАвтомашины as \'Владелец автомашины\'"})]
    [View("АвтомашинаL", new string[] {
            "Марка as \'Марка\'",
            "Грузоподъемность as \'Грузоподъемность (в тоннах)\'",
            "ВладелецАвтомашины.ФИО as \'ФИО\'"})]
    public class Автомашина : ICSSoft.STORMNET.DataObject
    {
        
        private string fМарка;
        
        private double fГрузоподъемность;
        
        private IIS.Individual_work_1.Владелец fВладелецАвтомашины;
        
        // *** Start programmer edit section *** (Автомашина CustomMembers)

        // *** End programmer edit section *** (Автомашина CustomMembers)

        
        /// <summary>
        /// Марка.
        /// </summary>
        // *** Start programmer edit section *** (Автомашина.Марка CustomAttributes)

        // *** End programmer edit section *** (Автомашина.Марка CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Марка
        {
            get
            {
                // *** Start programmer edit section *** (Автомашина.Марка Get start)

                // *** End programmer edit section *** (Автомашина.Марка Get start)
                string result = this.fМарка;
                // *** Start programmer edit section *** (Автомашина.Марка Get end)

                // *** End programmer edit section *** (Автомашина.Марка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Автомашина.Марка Set start)

                // *** End programmer edit section *** (Автомашина.Марка Set start)
                this.fМарка = value;
                // *** Start programmer edit section *** (Автомашина.Марка Set end)

                // *** End programmer edit section *** (Автомашина.Марка Set end)
            }
        }
        
        /// <summary>
        /// Грузоподъемность.
        /// </summary>
        // *** Start programmer edit section *** (Автомашина.Грузоподъемность CustomAttributes)

        // *** End programmer edit section *** (Автомашина.Грузоподъемность CustomAttributes)
        [NotNull()]
        public virtual double Грузоподъемность
        {
            get
            {
                // *** Start programmer edit section *** (Автомашина.Грузоподъемность Get start)

                // *** End programmer edit section *** (Автомашина.Грузоподъемность Get start)
                double result = this.fГрузоподъемность;
                // *** Start programmer edit section *** (Автомашина.Грузоподъемность Get end)

                // *** End programmer edit section *** (Автомашина.Грузоподъемность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Автомашина.Грузоподъемность Set start)

                // *** End programmer edit section *** (Автомашина.Грузоподъемность Set start)
                this.fГрузоподъемность = value;
                // *** Start programmer edit section *** (Автомашина.Грузоподъемность Set end)

                // *** End programmer edit section *** (Автомашина.Грузоподъемность Set end)
            }
        }
        
        /// <summary>
        /// Автомашина.
        /// </summary>
        // *** Start programmer edit section *** (Автомашина.ВладелецАвтомашины CustomAttributes)

        // *** End programmer edit section *** (Автомашина.ВладелецАвтомашины CustomAttributes)
        [NotNull()]
        public virtual IIS.Individual_work_1.Владелец ВладелецАвтомашины
        {
            get
            {
                // *** Start programmer edit section *** (Автомашина.ВладелецАвтомашины Get start)

                // *** End programmer edit section *** (Автомашина.ВладелецАвтомашины Get start)
                IIS.Individual_work_1.Владелец result = this.fВладелецАвтомашины;
                // *** Start programmer edit section *** (Автомашина.ВладелецАвтомашины Get end)

                // *** End programmer edit section *** (Автомашина.ВладелецАвтомашины Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Автомашина.ВладелецАвтомашины Set start)

                // *** End programmer edit section *** (Автомашина.ВладелецАвтомашины Set start)
                this.fВладелецАвтомашины = value;
                // *** Start programmer edit section *** (Автомашина.ВладелецАвтомашины Set end)

                // *** End programmer edit section *** (Автомашина.ВладелецАвтомашины Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "АвтомашинаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View АвтомашинаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("АвтомашинаE", typeof(IIS.Individual_work_1.Автомашина));
                }
            }
            
            /// <summary>
            /// "АвтомашинаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View АвтомашинаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("АвтомашинаL", typeof(IIS.Individual_work_1.Автомашина));
                }
            }
        }
    }
}
