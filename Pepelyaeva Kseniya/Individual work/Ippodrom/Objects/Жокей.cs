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
    /// Жокей.
    /// </summary>
    // *** Start programmer edit section *** (Жокей CustomAttributes)

    // *** End programmer edit section *** (Жокей CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЖокейE", new string[] {
            "Фамилия as \'Фамилия\'",
            "Разряд as \'Разряд\'"})]
    [View("ЖокейL", new string[] {
            "Фамилия",
            "Разряд"})]
    public class Жокей : ICSSoft.STORMNET.DataObject
    {
        
        private string fФамилия;
        
        private string fРазряд;
        
        // *** Start programmer edit section *** (Жокей CustomMembers)

        // *** End programmer edit section *** (Жокей CustomMembers)

        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Жокей.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Жокей.Фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Жокей.Фамилия Get start)

                // *** End programmer edit section *** (Жокей.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Жокей.Фамилия Get end)

                // *** End programmer edit section *** (Жокей.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Жокей.Фамилия Set start)

                // *** End programmer edit section *** (Жокей.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Жокей.Фамилия Set end)

                // *** End programmer edit section *** (Жокей.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Разряд.
        /// </summary>
        // *** Start programmer edit section *** (Жокей.Разряд CustomAttributes)

        // *** End programmer edit section *** (Жокей.Разряд CustomAttributes)
        [StrLen(255)]
        public virtual string Разряд
        {
            get
            {
                // *** Start programmer edit section *** (Жокей.Разряд Get start)

                // *** End programmer edit section *** (Жокей.Разряд Get start)
                string result = this.fРазряд;
                // *** Start programmer edit section *** (Жокей.Разряд Get end)

                // *** End programmer edit section *** (Жокей.Разряд Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Жокей.Разряд Set start)

                // *** End programmer edit section *** (Жокей.Разряд Set start)
                this.fРазряд = value;
                // *** Start programmer edit section *** (Жокей.Разряд Set end)

                // *** End programmer edit section *** (Жокей.Разряд Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЖокейE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЖокейE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЖокейE", typeof(IIS.Ippodrom.Жокей));
                }
            }
            
            /// <summary>
            /// "ЖокейL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЖокейL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЖокейL", typeof(IIS.Ippodrom.Жокей));
                }
            }
        }
    }
}
