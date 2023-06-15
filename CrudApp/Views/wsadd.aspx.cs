using CrudApp.DAL;
using CrudApp.DTOs;
using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApp.Views
{
    public partial class WSAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void efAddSubmit_Click(object sender, EventArgs e)
        {
            PersonDto person = new PersonDto();

            string firstName = inputFName.Text.Trim();
            string lastName = inputLName.Text.Trim();
            person.FirstName = firstName;
            person.LastName = lastName;

            if (int.TryParse(inputAge.Text.Trim(), out int personAge))
            {
                person.Age = personAge;
            }

            this.RegisterAsyncTask(new PageAsyncTask(async _ =>
            {
                var result = await PersonWebService.AddPersonAsync(person);
            }));

            inputFName.Text = "";
            inputLName.Text = "";
            inputAge.Text = "";

        }
    }
}