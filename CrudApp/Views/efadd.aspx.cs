using CrudApp.DAL;
using CrudApp.Models;
using System;
using System.Web.UI;

namespace CrudApp.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void efAddSubmit_Click(object sender, EventArgs e)
        {
            Person person = new Person();

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
                var result = await PersonService.AddPersonAsync(person);               
            }));

            inputFName.Text = "";
            inputLName.Text = "";
            inputAge.Text = "";

        }
    }
}