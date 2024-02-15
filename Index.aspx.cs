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
using System.Text;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace SliderModern
{
    public partial class Index : System.Web.UI.Page
    {
        #region id for slider...
        private int Id
        {
            get
            {
                if (ViewState["Id"] != null)
                    return int.Parse(ViewState["Id"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id"] = value; }
        }
        private int Id1
        {
            get
            {
                if (ViewState["Id1"] != null)
                    return int.Parse(ViewState["Id1"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id1"] = value; }
        }
        private int Id2
        {
            get
            {
                if (ViewState["Id2"] != null)
                    return int.Parse(ViewState["Id2"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id2"] = value; }
        }
        private int Id3
        {
            get
            {
                if (ViewState["Id3"] != null)
                    return int.Parse(ViewState["Id3"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id3"] = value; }
        }
        private int Id4
        {
            get
            {
                if (ViewState["Id4"] != null)
                    return int.Parse(ViewState["Id4"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id4"] = value; }
        }
        private int Id5
        {
            get
            {
                if (ViewState["Id5"] != null)
                    return int.Parse(ViewState["Id5"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id5"] = value; }
        }
        private int Id6
        {
            get
            {
                if (ViewState["Id6"] != null)
                    return int.Parse(ViewState["Id6"].ToString());
                else
                    return 0;
            }
            set { ViewState["Id6"] = value; }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DataImgUpload"].ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand("SELECT TOP 6 * FROM advertisement", conn);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 6)
                        {
                            Id1 = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
                            Label1.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                            Label2.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                            Image1.ImageUrl = "~/Images1/" +  ds.Tables[0].Rows[0]["Images"];

                            Id2 = Convert.ToInt32(ds.Tables[0].Rows[1]["Id"].ToString());
                            Label3.Text = ds.Tables[0].Rows[1]["Title"].ToString();
                            Label4.Text = ds.Tables[0].Rows[1]["Description"].ToString();
                            Image2.ImageUrl = "~/Images1/" + ds.Tables[0].Rows[1]["Images"];

                            Id3 = Convert.ToInt32(ds.Tables[0].Rows[2]["Id"].ToString());
                            Label5.Text = ds.Tables[0].Rows[2]["Title"].ToString();
                            Label6.Text = ds.Tables[0].Rows[2]["Description"].ToString();
                            Image3.ImageUrl = "~/Images1/" + ds.Tables[0].Rows[2]["Images"];

                            Id4 = Convert.ToInt32(ds.Tables[0].Rows[3]["Id"].ToString());
                            Label7.Text = ds.Tables[0].Rows[3]["Title"].ToString();
                            Label8.Text = ds.Tables[0].Rows[3]["Description"].ToString();
                            Image4.ImageUrl = "~/Images1/" + ds.Tables[0].Rows[3]["Images"];

                            Id5 = Convert.ToInt32(ds.Tables[0].Rows[4]["Id"].ToString());
                            Label9.Text = ds.Tables[0].Rows[4]["Title"].ToString();
                            Label10.Text = ds.Tables[0].Rows[4]["Description"].ToString();
                            Image5.ImageUrl = "~/Images1/" + ds.Tables[0].Rows[4]["Images"];

                            Id6 = Convert.ToInt32(ds.Tables[0].Rows[5]["Id"].ToString());
                            Label11.Text = ds.Tables[0].Rows[5]["Title"].ToString();
                            Label12.Text = ds.Tables[0].Rows[5]["Description"].ToString();
                            Image6.ImageUrl = "~/Images1/" + ds.Tables[0].Rows[5]["Images"];
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
      }
        protected void Oglas1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail1.aspx?Command=Edit&Id=" + Id1.ToString(), true);
        }
        protected void Oglas2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail1.aspx?Command=Edit&Id=" + Id2.ToString(), true);
        }
        protected void Oglas3_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail2.aspx?Command=Edit&Id=" + Id3.ToString(), true);
        }
        protected void Oglas4_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail2.aspx?Command=Edit&Id=" + Id4.ToString(), true);
        }
        protected void Oglas5_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail.aspx?Command=Edit&Id=" + Id5.ToString(), true);
        }
        protected void Oglas6_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ListaOglasiPomocDetail.aspx?Command=Edit&Id=" + Id6.ToString(), true);
        }
    }
}