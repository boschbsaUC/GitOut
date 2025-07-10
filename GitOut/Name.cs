using Microsoft.AspNetCore.Mvc;

namespace GitOut
{
    public class Name : Controller
    {
        public string FirstName { get; set; }

        public Name(string FirstName) { this.FirstName = FirstName; }
    }
}
