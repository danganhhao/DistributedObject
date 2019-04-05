using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    public abstract class SObject
    {
        public int Handle;

        public SObject()
        {
            SManager.Register(this);
        }

        public virtual object ExecuteSomething(string strFunctionName, object allParams)
        {
            return null;
        }

        public object this[string strAttributeName]
        {
            //template method
            get
            {
                return GetAttributeValue(strAttributeName);
            }

            set
            {
                SetAttributeValue(strAttributeName, value);
            }
        }

        protected virtual void SetAttributeValue(string strAttributeName, object value)
        {
         
        }

        protected virtual object GetAttributeValue(string strAttributeName)
        {
            return null;
        }
    }
}
