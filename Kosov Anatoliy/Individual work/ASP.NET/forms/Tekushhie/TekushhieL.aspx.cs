﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_40936
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ТекущиеL : BaseListForm<Текущие>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ТекущиеL() : base(Текущие.Views.ТекущиеL)
        {
            EditPage = ТекущиеE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Tekushhie/TekushhieL.aspx"; }
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
