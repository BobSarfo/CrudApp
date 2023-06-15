using CrudApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApp.Views
{
    public partial class wssearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            this.RegisterAsyncTask(new PageAsyncTask(async _ =>
            {
                var persons = await PersonWebService.SearchPersonAsync(inputSearch.Text);
                personListGrid.DataSource = persons;
                personListGrid.DataBind();

            }));
        }
    }
}