using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    public class CObject
    {
        protected int Handle = 0;
        public object this[string strAttributeName]
        {
            get {
                return GetAttribueValue(strAttributeName);
            }
            set {
                SetAttribuleValue(strAttributeName, value);
            }
        }

        protected virtual void SetAttribuleValue(string strAttributeName, object value)
        {
            
        }

        protected virtual object GetAttribueValue(string strAttributeName)
        {
            return null;
        }
    }
}
