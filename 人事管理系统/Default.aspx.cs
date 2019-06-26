using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 人事管理系统
{
    public partial class Default : System.Web.UI.Page
    {
        private string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GenTreeNode();
            }
        }

        public void GenTreeNode()
        {
            //建立树菜单的实例
            TreeView treeView = new TreeView();
            //建立树节点的实例
            TreeNode treeNode = new TreeNode();
            //增加根节点
            treeNode.Text = "人事管理系统";
            treeNode.NavigateUrl = "";
            treeView.Nodes.Add(treeNode);

            //增加父节点


            //增加子节点
        }

        //获取登录用户的身份，并用dataset取出它的功能
        public void GetFounctionId()
        {
            string str;
            name = Session["userid"].ToString();
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter sqlData = new SqlDataAdapter();
            conn.ConnectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename='|DataDirectory|\\Database1.mdf';";
            conn.Open();
            str = string.Format("select RoleName from employee where eid={0}", name);
            DataSet dataSet = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(str, conn);


            

        }
    }
}