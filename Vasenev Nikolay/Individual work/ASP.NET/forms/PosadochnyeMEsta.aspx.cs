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
using ICSSoft.STORMNET.Business.LINQProvider;
using System.Linq;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;

namespace IIS.Авиакомпания
{
    public partial class ПосадочныеМЕста : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mom.DataObjectTypes = new[] { typeof(ТипСамолета) };
            Mom.View = ТипСамолета.Views.Mesta;
            Mom.Operations.New = false;
            Mom.Operations.Edit = false;
            Mom.Operations.EditInRow = false;
            Mom.Operations.Delete = false;
            Mom.Operations.DeleteInRow = false;


            //if (Session["nomer"] != null)
            //{
                var ds = DataServiceProvider.DataService;
                //var nomer = Convert.ToInt32(Session["nomer"]);
                var n = ds.Query<ТипСамолета>(ТипСамолета.Views.Mesta.Name).Where(g => g.Название=="Боинг").Where(о => о.Код=="727");
            Mom.LimitFunction = LinqToLcs.GetLcs(n.Expression, ТипСамолета.Views.Mesta).LimitFunction;
            //}
            //else
            //{
            //    Mom.LimitFunction = SQLWhereLanguageDef.LanguageDef.GetFunction(SQLWhereLanguageDef.LanguageDef.funcSQL, "1!=1");
            //}
        }

        //protected void Button_Click(object sender, EventArgs e)
        //{
        //    var ds = DataServiceProvider.DataService;
        //    try
        //    {

        //        var nomer = Convert.ToInt32(Num2.StringValue);
        //        Session["nomer"] = nomer;
        //    }
        //    catch (Exception)
        //    {
        //        Session["nomer"] = null;
        //    }
        //    Response.Redirect(Request.Url.ToString());
        //}
    }
}

