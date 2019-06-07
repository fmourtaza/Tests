using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace TestRss
{
    public partial class RssForm : System.Web.UI.Page
    {
        //https://stackoverflow.com/questions/19736120/how-to-display-another-sites-rss-feed-in-my-asp-net-site
        //https://uk.reuters.com/tools/rss
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRSS();
            }
        }

        protected void rptRSS_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HyperLink lnkArticle = (HyperLink)e.Item.FindControl("lnkArticle");
                Label lblDescription = (Label)e.Item.FindControl("lblDescription");
                Label lblRSSTitle = (Label)e.Item.FindControl("lblRSSTitle");
                Image imgRss = (Image)e.Item.FindControl("imgRss");
                string imgPath = null;
                SyndicationItem item = (SyndicationItem)e.Item.DataItem;

                if (item.ElementExtensions.Where(p => p.OuterName == "thumbnail").Count() != 0)
                {
                    imgPath = item.ElementExtensions.Where(p => p.OuterName == "thumbnail").First().GetObject<XElement>().Attribute("url").Value;
                }

                lnkArticle.Text = item.Title.Text;
                lnkArticle.NavigateUrl = item.Links[0].Uri.ToString(); ;
                lblRSSTitle.Text = item.Title.Text;
                lblDescription.Text = item.Summary.Text;
                if (!string.IsNullOrEmpty(imgPath))
                    imgRss.ImageUrl = imgPath;
            }
        }

        private void LoadRSS()
        {
            List<SyndicationItem> lstSynItem = new List<SyndicationItem>();
            string uri = "http://feeds.bbci.co.uk/news/entertainment_and_arts/rss.xml";
            SyndicationFeed myRss = SyndicationFeed.Load(XmlReader.Create(uri));

            foreach (SyndicationItem item in myRss.Items)
            {
                lstSynItem.Add(item);
            }
            rptRSS.DataSource = lstSynItem;
            rptRSS.DataBind();
        }
    }
}