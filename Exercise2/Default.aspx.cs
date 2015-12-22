using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonLoadCategories_OnClick(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=localhost; Database=AdventureWorks2012; Integrated Security=true");

            string sqlQuery = "SELECT * FROM Production.ProductCategory";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            SqlDataReader sqlDataReader = null;

            DropDownCategories.Items.Clear();
            ListItem defaultItem = new ListItem { Text = "Select", Value = "0" };
            DropDownCategories.Items.Add(defaultItem);
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ListItem item = new ListItem();
                    item.Text = sqlDataReader["Name"].ToString();
                    item.Value = sqlDataReader["ProductCategoryID"].ToString();
                    DropDownCategories.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                LabelException.Text = ex.Message;
                LabelException.Visible = true;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlDataReader.Dispose();
                }
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }
        }
    }
}