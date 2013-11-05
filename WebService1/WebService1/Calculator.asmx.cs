using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/",
        Description = "Simple Calculator Service",
        Name = "CalculatorService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Divide(double a, double b)
        {
            /*if (B == 0)
            {
                return 0;
            }*/
            return a / b;
        }

        [WebMethod]
        public double Power(double index, int exponent)
        {
            double result = 1;

            if (exponent == 0)
            {
                result = 1;
            }
            else if (exponent > 0)
            {
                for (int i = 1; i <= exponent; i++)
                {
                    result = result * index;
                }
            }
            else
            {
                result = -1;
            }

            return result;
        }

    }
}