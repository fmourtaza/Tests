using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TestRss
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "ITDesigns - Home";
            GetRss();
        }

        protected void GetRss()
        {
            try
            {
                #region

                XDocument news = XDocument.Load(@"http://www.engadget.com/rss.xml");

                var p = (from c in news.Descendants("rss").Descendants("channel").Descendants("item")
                         orderby c.Element("pubDate").Value ascending
                         select new
                         {
                             pubDate = c.Element("pubDate").Value,
                             title = c.Element("title").Value,
                             description = c.Element("description").Value,
                         }).Take(2).ToList();

                int i = 0;
                foreach (var er in p)
                {
                    if (i == 0)
                    {
                        lblRDate1.Text = er.pubDate;
                        lblRss1.Text = er.title;
                    }
                    else
                    {
                        lblRDate2.Text = er.pubDate;
                        lblRss2.Text = er.title;
                    }
                    i++;
                }

                #endregion
            }
            catch (Exception)
            { }
        }

    }
}