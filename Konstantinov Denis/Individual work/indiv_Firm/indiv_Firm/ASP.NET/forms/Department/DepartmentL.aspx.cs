﻿/*flexberryautogenerated="true"*/
namespace IIS.indiv_Firm
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class DepartmentL : BaseListForm<Department>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public DepartmentL() : base(Department.Views.DepartmentL)
        {
            EditPage = DepartmentE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Department/DepartmentL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
