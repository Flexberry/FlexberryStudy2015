﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.indiv_Firm
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Employee.
    /// </summary>
    // *** Start programmer edit section *** (Employee CustomAttributes)

    // *** End programmer edit section *** (Employee CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("EmployeeE", new string[] {
            "name as \'Name\'",
            "spouse as \'Spouse\'",
            "male as \'Male\'"})]
    [View("EmployeeL", new string[] {
            "name as \'Name\'",
            "spouse as \'Spouse\'",
            "male as \'Male\'"})]
    public class Employee : ICSSoft.STORMNET.DataObject
    {
        
        private string fname;
        
        private bool fspouse;
        
        private bool fmale;
        
        // *** Start programmer edit section *** (Employee CustomMembers)

        // *** End programmer edit section *** (Employee CustomMembers)

        
        /// <summary>
        /// name.
        /// </summary>
        // *** Start programmer edit section *** (Employee.name CustomAttributes)

        // *** End programmer edit section *** (Employee.name CustomAttributes)
        [StrLen(255)]
        public virtual string name
        {
            get
            {
                // *** Start programmer edit section *** (Employee.name Get start)

                // *** End programmer edit section *** (Employee.name Get start)
                string result = this.fname;
                // *** Start programmer edit section *** (Employee.name Get end)

                // *** End programmer edit section *** (Employee.name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.name Set start)

                // *** End programmer edit section *** (Employee.name Set start)
                this.fname = value;
                // *** Start programmer edit section *** (Employee.name Set end)

                // *** End programmer edit section *** (Employee.name Set end)
            }
        }
        
        /// <summary>
        /// spouse.
        /// </summary>
        // *** Start programmer edit section *** (Employee.spouse CustomAttributes)

        // *** End programmer edit section *** (Employee.spouse CustomAttributes)
        public virtual bool spouse
        {
            get
            {
                // *** Start programmer edit section *** (Employee.spouse Get start)

                // *** End programmer edit section *** (Employee.spouse Get start)
                bool result = this.fspouse;
                // *** Start programmer edit section *** (Employee.spouse Get end)

                // *** End programmer edit section *** (Employee.spouse Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.spouse Set start)

                // *** End programmer edit section *** (Employee.spouse Set start)
                this.fspouse = value;
                // *** Start programmer edit section *** (Employee.spouse Set end)

                // *** End programmer edit section *** (Employee.spouse Set end)
            }
        }
        
        /// <summary>
        /// male.
        /// </summary>
        // *** Start programmer edit section *** (Employee.male CustomAttributes)

        // *** End programmer edit section *** (Employee.male CustomAttributes)
        public virtual bool male
        {
            get
            {
                // *** Start programmer edit section *** (Employee.male Get start)

                // *** End programmer edit section *** (Employee.male Get start)
                bool result = this.fmale;
                // *** Start programmer edit section *** (Employee.male Get end)

                // *** End programmer edit section *** (Employee.male Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Employee.male Set start)

                // *** End programmer edit section *** (Employee.male Set start)
                this.fmale = value;
                // *** Start programmer edit section *** (Employee.male Set end)

                // *** End programmer edit section *** (Employee.male Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "EmployeeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EmployeeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EmployeeE", typeof(IIS.indiv_Firm.Employee));
                }
            }
            
            /// <summary>
            /// "EmployeeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EmployeeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EmployeeL", typeof(IIS.indiv_Firm.Employee));
                }
            }
        }
    }
}
