using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    public class SStudent: SObject
    {
        protected string Name;
        protected double GPA;

        public override object ExecuteSomething(string strFunctionName, object allParams)
        {
            /*switch (strFunctionName)
            {
                case "name1": return Function1(allParams);
            }*/
            return null;
        }

        protected override object GetAttributeValue(string strAttributeName)
        {
            switch (strAttributeName)
            {
                case "Name": return Name;
                case "GPA": return GPA;
            }
            return null;
        }

        protected override void SetAttributeValue(string strAttributeName, object value)
        {
            switch (strAttributeName)
            {
                case "Name": Name = (string)value;
                    break;
                case "GPA": GPA = (double)value;
                    break;
            }
        }
    }
}
