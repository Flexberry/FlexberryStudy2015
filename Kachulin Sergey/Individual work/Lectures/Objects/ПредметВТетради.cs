﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Lectures
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Предмет в тетради.
    /// </summary>
    // *** Start programmer edit section *** (ПредметВТетради CustomAttributes)

    // *** End programmer edit section *** (ПредметВТетради CustomAttributes)
    [AutoAltered()]
    [Caption("Предмет в тетради")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПредметВТетрадиE", new string[] {
            "Предмет as \'Предмет\'",
            "КоличествоЛекций as \'Количество лекций\'",
            "Предмет.Название as \'Предмет\'"}, Hidden=new string[] {
            "Предмет.Название"})]
    [MasterViewDefineAttribute("ПредметВТетрадиE", "Предмет", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class ПредметВТетради : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличествоЛекций;
        
        private IIS.Lectures.Предмет fПредмет;
        
        private IIS.Lectures.Тетрадь fТетрадь;
        
        // *** Start programmer edit section *** (ПредметВТетради CustomMembers)

        // *** End programmer edit section *** (ПредметВТетради CustomMembers)

        
        /// <summary>
        /// КоличествоЛекций.
        /// </summary>
        // *** Start programmer edit section *** (ПредметВТетради.КоличествоЛекций CustomAttributes)

        // *** End programmer edit section *** (ПредметВТетради.КоличествоЛекций CustomAttributes)
        public virtual int КоличествоЛекций
        {
            get
            {
                // *** Start programmer edit section *** (ПредметВТетради.КоличествоЛекций Get start)

                // *** End programmer edit section *** (ПредметВТетради.КоличествоЛекций Get start)
                int result = this.fКоличествоЛекций;
                // *** Start programmer edit section *** (ПредметВТетради.КоличествоЛекций Get end)

                // *** End programmer edit section *** (ПредметВТетради.КоличествоЛекций Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредметВТетради.КоличествоЛекций Set start)

                // *** End programmer edit section *** (ПредметВТетради.КоличествоЛекций Set start)
                this.fКоличествоЛекций = value;
                // *** Start programmer edit section *** (ПредметВТетради.КоличествоЛекций Set end)

                // *** End programmer edit section *** (ПредметВТетради.КоличествоЛекций Set end)
            }
        }
        
        /// <summary>
        /// Предмет в тетради.
        /// </summary>
        // *** Start programmer edit section *** (ПредметВТетради.Предмет CustomAttributes)

        // *** End programmer edit section *** (ПредметВТетради.Предмет CustomAttributes)
        [PropertyStorage(new string[] {
                "Предмет"})]
        [NotNull()]
        public virtual IIS.Lectures.Предмет Предмет
        {
            get
            {
                // *** Start programmer edit section *** (ПредметВТетради.Предмет Get start)

                // *** End programmer edit section *** (ПредметВТетради.Предмет Get start)
                IIS.Lectures.Предмет result = this.fПредмет;
                // *** Start programmer edit section *** (ПредметВТетради.Предмет Get end)

                // *** End programmer edit section *** (ПредметВТетради.Предмет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредметВТетради.Предмет Set start)

                // *** End programmer edit section *** (ПредметВТетради.Предмет Set start)
                this.fПредмет = value;
                // *** Start programmer edit section *** (ПредметВТетради.Предмет Set end)

                // *** End programmer edit section *** (ПредметВТетради.Предмет Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Lectures.Тетрадь.
        /// </summary>
        // *** Start programmer edit section *** (ПредметВТетради.Тетрадь CustomAttributes)

        // *** End programmer edit section *** (ПредметВТетради.Тетрадь CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Тетрадь"})]
        public virtual IIS.Lectures.Тетрадь Тетрадь
        {
            get
            {
                // *** Start programmer edit section *** (ПредметВТетради.Тетрадь Get start)

                // *** End programmer edit section *** (ПредметВТетради.Тетрадь Get start)
                IIS.Lectures.Тетрадь result = this.fТетрадь;
                // *** Start programmer edit section *** (ПредметВТетради.Тетрадь Get end)

                // *** End programmer edit section *** (ПредметВТетради.Тетрадь Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ПредметВТетради.Тетрадь Set start)

                // *** End programmer edit section *** (ПредметВТетради.Тетрадь Set start)
                this.fТетрадь = value;
                // *** Start programmer edit section *** (ПредметВТетради.Тетрадь Set end)

                // *** End programmer edit section *** (ПредметВТетради.Тетрадь Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПредметВТетрадиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПредметВТетрадиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПредметВТетрадиE", typeof(IIS.Lectures.ПредметВТетради));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ПредметВТетради.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfПредметВТетради CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfПредметВТетради CustomAttributes)
    public class DetailArrayOfПредметВТетради : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Lectures.DetailArrayOfПредметВТетради members)

        // *** End programmer edit section *** (IIS.Lectures.DetailArrayOfПредметВТетради members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ПредметВТетради by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ПредметВТетради.
        /// </summary>
        public DetailArrayOfПредметВТетради(IIS.Lectures.Тетрадь fТетрадь) : 
                base(typeof(ПредметВТетради), ((ICSSoft.STORMNET.DataObject)(fТетрадь)))
        {
        }
        
        public IIS.Lectures.ПредметВТетради this[int index]
        {
            get
            {
                return ((IIS.Lectures.ПредметВТетради)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Lectures.ПредметВТетради dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
