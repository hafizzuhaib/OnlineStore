// Ignore Spelling: Online

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public static class Extensions
    {
        public static bool Exists(this IWebElement element)
        {
			try
			{
				var text = element.Text;
			}
			catch (Exception e)
			{

				return false;
			}

			return true;
        }
    }
}
