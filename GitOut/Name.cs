using Microsoft.AspNetCore.Mvc;

namespace GitOut
{
    public class Name : Controller
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name(string FirstName, string lastName)
        {
            this.FirstName = FirstName;
            LastName = lastName;
        }
    }
}
