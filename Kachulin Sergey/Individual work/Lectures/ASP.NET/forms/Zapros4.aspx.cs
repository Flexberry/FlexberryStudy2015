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
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using System.Linq;
using ICSSoft.STORMNET.Web.AjaxControls.Forms;

namespace IIS.Lectures
{
    public partial class Запрос4 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;

            if (!IsPostBack)
            {
                var subjects = ds.Query<Тетрадь>(Тетрадь.Views.ТетрадьL.Name);
                foreach (var subject in subjects)
                    dropDownList4.Items.Add(subject.Название);
            }
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;

            var subjects = ds.Query<Тетрадь>(Тетрадь.Views.ТетрадьE)
                    .Where(t => t.Название == dropDownList4.SelectedValue)
                    .First()
                    .ПредметВТетради.Cast<ПредметВТетради>().ToList()
                    .Select(t => t.Предмет);

            TableRow tr;
            TableCell tc;
            int i = 0;

            foreach (var subject in subjects)
            {
                var semesters = ds.Query<Семестр>(Семестр.Views.СеместрE)
                    .Where(s => s.ПредметВСеместре.Cast<ПредметВСеместре>().Any(p => p.Предмет == subject))
                    .OrderBy(s => s.Номер).ToList();

                int count = semesters.Count();

                i++;
                tr = new TableRow();

                tc = new TableCell();
                tc.Controls.Add(new LiteralControl(i + "."));
                tc.RowSpan = count;
                tr.Cells.Add(tc);

                tc = new TableCell();
                tc.Controls.Add(new LiteralControl(subject.Название));
                tc.RowSpan = count;
                tr.Cells.Add(tc);

                foreach (var semester in semesters)
                {
                    tc = new TableCell();
                    tc.Controls.Add(new LiteralControl(semester.Номер.ToString()));
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Controls.Add(new LiteralControl(semester.Название));
                    tr.Cells.Add(tc);

                    table4.Rows.Add(tr);

                    tr = new TableRow();
                }
            }
        }
    }
}