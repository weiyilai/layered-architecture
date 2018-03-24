using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.ViewModel;

namespace Test.Web.Models
{
    public class TestModel
    {
        public TestViewModel Query { get; set; }

        /// <summary>
        /// Controller
        /// </summary>
        public TestModel()
        {
            this.Query = new TestViewModel();
        }
    }
}