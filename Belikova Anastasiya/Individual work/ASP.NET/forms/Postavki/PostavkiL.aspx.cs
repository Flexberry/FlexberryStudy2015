﻿/*flexberryautogenerated="true"*/
namespace IIS.Склад
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ПоставкиL : BaseListForm<Поставки>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ПоставкиL() : base(Поставки.Views.ПоставкиL)
        {
            EditPage = ПоставкиE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Postavki/PostavkiL.aspx"; }
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
