﻿/*flexberryautogenerated="true"*/
namespace IIS.Individual_work_1
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class НазваниеСкладаИТовараL : BaseListForm<НазваниеСкладаИТовара>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public НазваниеСкладаИТовараL() : base(НазваниеСкладаИТовара.Views.НазваниеСкладаИТовараL)
        {
            EditPage = НазваниеСкладаИТовараE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/NazvanieSkladaITovara/NazvanieSkladaITovaraL.aspx"; }
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
