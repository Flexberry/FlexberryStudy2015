﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Горводоканал
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Справочник.
    /// </summary>
    // *** Start programmer edit section *** (Справочник CustomAttributes)

    // *** End programmer edit section *** (Справочник CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СправочникE", new string[] {
            "Актуально as \'Актуально\'"})]
    [View("СправочникL", new string[] {
            "Актуально as \'Актуально\'"})]
    public class Справочник : ICSSoft.STORMNET.DataObject
    {
        
        private bool fАктуально = true;
        
        // *** Start programmer edit section *** (Справочник CustomMembers)

        // *** End programmer edit section *** (Справочник CustomMembers)

        
        /// <summary>
        /// Актуально.
        /// </summary>
        // *** Start programmer edit section *** (Справочник.Актуально CustomAttributes)

        // *** End programmer edit section *** (Справочник.Актуально CustomAttributes)
        public virtual bool Актуально
        {
            get
            {
                // *** Start programmer edit section *** (Справочник.Актуально Get start)

                // *** End programmer edit section *** (Справочник.Актуально Get start)
                bool result = this.fАктуально;
                // *** Start programmer edit section *** (Справочник.Актуально Get end)

                // *** End programmer edit section *** (Справочник.Актуально Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Справочник.Актуально Set start)

                // *** End programmer edit section *** (Справочник.Актуально Set start)
                this.fАктуально = value;
                // *** Start programmer edit section *** (Справочник.Актуально Set end)

                // *** End programmer edit section *** (Справочник.Актуально Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СправочникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СправочникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СправочникE", typeof(NewPlatform.Горводоканал.Справочник));
                }
            }
            
            /// <summary>
            /// "СправочникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СправочникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СправочникL", typeof(NewPlatform.Горводоканал.Справочник));
                }
            }
        }
    }
}
