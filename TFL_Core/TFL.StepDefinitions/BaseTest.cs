using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFL_Libraries.TFL.Core;
using TFL_Libraries.TFL.Pages;

namespace TFL_Tests.TFL.StepDefinitions
{
    public class BaseTest
    {
        public T GetPage<T>() where T : BasePage
        {
            return (T)Activator.CreateInstance(typeof(T), Drivers.driver);
        }
    }
}
