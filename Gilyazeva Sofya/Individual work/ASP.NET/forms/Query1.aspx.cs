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
using IIS.Flex.CaseberryInteraction;

namespace IIS.Книги
{
    public partial class Query1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            blAuthors.Items.Clear();
        }

        protected void btFind_Click(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var authors = ds.Query<Автор>(Автор.Views.АвторE).ToList();
            int max = authors.Max(a => a.АвторКнига.Count);
            var selauthors = authors.Where(a => a.АвторКнига.Count == max);
            foreach (var item in selauthors)
            {
                blAuthors.Items.Add(item.Фамилия.ToString() + " " + item.Имя.ToString());
            }
            lbCount.Text = lbCount.Text + max.ToString();
        }
    }
}
