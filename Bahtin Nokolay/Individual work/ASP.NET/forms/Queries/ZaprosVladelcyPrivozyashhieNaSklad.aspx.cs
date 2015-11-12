﻿/*flexberryautogenerated="true"*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Web.Tools.WOLVFeatures;
using ICSSoft.STORMNET.Business.LINQProvider;
using System.Linq;


namespace IIS.Indiv_Bahtin
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.Controls;
    using ICSSoft.STORMNET.Web.AjaxControls;

    public partial class ЗапросВладельцыПривозящиеНаСклад : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WolvOwners.DataObjectTypes = new[] { typeof(Поступление) };
            WolvOwners.View = Поступление.Views.ПоступлениеE;            

            ctrlСклад.MasterViewName = Склад.Views.СкладL.Name;
            ctrlСклад.MasterTypeName = typeof(Склад).AssemblyQualifiedName;
            ctrlСклад.PropertyToShow = "Название";

            if (Session["storagepk"] != null)
            {
                var ds = DataServiceProvider.DataService;
                var q = ds.Query<Поступление>(Поступление.Views.ПоступлениеE.Name)
                    .Where(g => g.Склад.__PrimaryKey.ToString() == ctrlСклад.SelectedMasterPK);
                WolvOwners.LimitFunction = LinqToLcs.GetLcs(q.Expression, Поступление.Views.ПоступлениеE).LimitFunction;
            }       

            //var q1 = ds.Query<Человек>(Человек.Views.ЧеловекL).Where<Автомашина>(g=>g.Марка=="Газель";            
        }        

        protected void PostApplyToControls()
        {            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var storagepk = ctrlСклад.SelectedMasterPK;
                Session["storagepk"] = storagepk;
            }
            catch (Exception)
            {
                Session["storagepk"] = null;
            }            
        }
    }
}
