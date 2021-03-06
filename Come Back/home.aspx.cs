﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Come_Back
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("signin.aspx");
            }
            string html = "";
            Utils util = new Utils();
            List<Utils.productitem> items = util.GetLog(Session["username"].ToString());

            foreach (var item in items)
            {

                //html += "<div class=\"row\">";
                //html += "<div class=\"small-boxbg-red\">";
                //html += "<div class=\"inner\">";
                //html += "<h3>";
                //html += item.weight.ToString() + "KG";
                //html += "</h3>";
                //html += "<p>";
                //html += item.date.ToString();
                //html += "</p>";
                //html += "</div>";
                //html += "</div>";
                //html += "</div>";

                html += "<div class=\"col-lg-3 col-xs-6\">";
                html += "<div class=\"small-box bg-red\">";
                html += "<div class=\"inner\">";
                html += "<h3>";
                html += item.weight.ToString() + "KG";
                html += "</h3>";
                html += "<p>";
                html += item.date.ToString();
                html += "</p>";
                html += "</div>";
                html += "<div class=\"icon\">";
                html += "<i class=\"ion ion-pie-graph\"></i>";
                html += "</div>";
                html += " <a href=\"#\" class=\"small-box-footer\">";
                html += "More info <i class=\"fa fa-arrow-circle-right\"></i>";
                html += "</a>";
                html += "</div>";
                html += "</div>";


            }

            litLog.Text = html;

            string html2 = "";
            Utils Util = new Utils();
            List<Utils.ScheduleItem> items2 = util.GetSchedule(Session["username"].ToString());
            foreach (var item in items2)
            {
                lblmonday.Text = item.fld_monday;
                lbltuesday.Text = item.fld_tuesday;
                lblwednesday.Text = item.fld_wednesday;
                lblthursday.Text = item.fld_thursday;
                lblfriday.Text = item.fld_friday;
                lblstaruday.Text = item.fld_saturday;
                lblsunday.Text = item.fld_sunday;
                litmonth.Text = "<h3 class=\"box-title\">" + item.fld_CurrentMonth.ToString() + "</h3>";
            }
            

        }
    }
}