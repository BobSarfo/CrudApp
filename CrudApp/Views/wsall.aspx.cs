using CrudApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApp.Views
{
    public partial class wsall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterAsyncTask(new PageAsyncTask(async _ =>
            {
                var persons = await PersonWebService.GetPersonsAsync();
                personListGrid.DataSource = persons;
                personListGrid.DataBind();

            }));

        }

        protected void personListGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeletePerson")
            {
                var personidObject = e.CommandArgument;
                int personId;
                bool hasPersonId = int.TryParse(personidObject.ToString(), out personId);
                if (!hasPersonId) return;

                this.RegisterAsyncTask(new PageAsyncTask(async _ =>
                {
                    await PersonWebService.DeletePersonAsync(personId);

                }));
            }
        }

    }
}