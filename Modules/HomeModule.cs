using Nancy;
using System.Collections.Generic;
using NumbersToWords.Objects;


namespace NumbersToWords
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        }
    }
}
