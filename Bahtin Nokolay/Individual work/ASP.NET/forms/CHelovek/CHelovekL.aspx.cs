﻿/*flexberryautogenerated="true"*/
namespace IIS.Indiv_Bahtin
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ЧеловекL : BaseListForm<Человек>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ЧеловекL() : base(Человек.Views.ЧеловекL)
        {
            EditPage = ЧеловекE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/CHelovek/CHelovekL.aspx"; }
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
