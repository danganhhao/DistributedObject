using System;
using System.Collections.Generic;

namespace DistributedObject
{
    public class SManager
    {
        private static int NextAvailableHandle = 1;
        private static Dictionary<int, SObject> objects = new Dictionary<int, SObject>();

        public static int CreateObjectByName(string strClassName)
        {
            switch (strClassName)
            {
                case "SStudent":
                    return new SStudent().Handle;
            }
            return 0;
        }
        internal static void Register(SObject sObject)
        {
            sObject.Handle = NextAvailableHandle++;
            objects.Add(sObject.Handle, sObject);
        }

        public static object GetAttributeValue(int Handle, string strAttributeName)
        {
            SObject obj = FindObjectByHandle(Handle);
            if (obj != null)
                return obj[strAttributeName];
            return null;
        }

        public static bool SetAttributeValue(int Handle, string strAttributeName, object newValue)
        {
            SObject obj = FindObjectByHandle(Handle);

            try {
                if (obj != null)
                {
                    obj[strAttributeName] = newValue;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static SObject FindObjectByHandle(int handle)
        {
            if (objects.ContainsKey(handle))
                return objects[handle];
            return null;
        }
    }
}