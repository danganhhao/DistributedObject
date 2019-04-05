using System;

namespace DistributedObject
{
    internal class CManager
    {
        internal static int CreateRemoteObject(string strClassName)
        {
            return SManager.CreateObjectByName(strClassName);
        }

        internal static object GetAttributeValue(int handle, string strAttributeName)
        {
            return SManager.GetAttributeValue(handle, strAttributeName);
        }

        internal static void SetAttributeValue(int handle, string strAttributeName, object value)
        {
            SManager.SetAttributeValue(handle, strAttributeName, value);
        }
    }
}