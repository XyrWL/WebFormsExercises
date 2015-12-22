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
                LabelInfo.Visible = false;
            }
            catch (Exception ex)
            {
                LabelInfo.Text = ex.Message;
                LabelInfo.Visible = true;
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

        protected void ButtonAddCategory_OnClick(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=localhost; Database=AdventureWorks2012; Integrated Security=true");

            string sqlInsert = $"INSERT INTO Production.ProductCategory (Name) VALUES ('{TextBoxCategoryName.Text}')";
            SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection);
            try
            {
                sqlConnection.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    LabelInfo.Text = "New category added, press button to refresh list.";
                    LabelInfo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LabelInfo.Text = ex.Message;
                LabelInfo.Visible = true;
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }
        }
    }
}