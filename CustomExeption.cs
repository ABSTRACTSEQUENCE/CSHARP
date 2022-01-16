using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{


    public class Bankrupt : ApplicationException
    {
        private string message { get; }
        public DateTime time;

        public Bankrupt()
        {
            message = "Вы - банкрот!";
            time = DateTime.Now;
        }
        public string msg
        {
            get { return message; }
        }
    }
}
