﻿/*flexberryautogenerated="true"*/
namespace IIS.Авиакомпания
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ИнформацияОСамолетеL : BaseListForm<ИнформацияОСамолете>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ИнформацияОСамолетеL() : base(ИнформацияОСамолете.Views.ИнформацияОСамолетеL)
        {
            EditPage = ИнформацияОСамолетеE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/InformaciyaOSamolete/InformaciyaOSamoleteL.aspx"; }
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
