using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    public class CStudent : CObject
    {
        public CStudent()
        {
            this.Handle = CManager.CreateRemoteObject("SStudent");
        }

        protected override object GetAttribueValue(string strAttributeName)
        {
            switch (strAttributeName)
            {
                case "Ho ten":
                    return CManager.GetAttributeValue(this.Handle, "Name");
                case "DTB":
                    return CManager.GetAttributeValue(this.Handle, "GPA");
            }
            return null;
        }

        protected override void SetAttribuleValue(string strAttributeName, object value)
        {
            switch (strAttributeName)
            {
                case "Ho ten":
                    CManager.SetAttributeValue(this.Handle, "Name", value);
                    break;
                case "DTB":
                    CManager.SetAttributeValue(this.Handle, "GPA", value);
                    break;
            }
           
            
        }
    }
}
