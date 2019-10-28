using System;
using System.Collections.Generic;

namespace BitFlagger
{
    public abstract class _BitFlager
    {
        static  Dictionary<string, UInt64> bitFlags;
        private UInt64 value =0;
        protected static void Initialize(string[] KeyData)
        {
            if(KeyData.Length >64 )
            {
                throw new Exception("This solution supports maximum of 64 flags");
            }

            bitFlags = new Dictionary<string, UInt64>();
            UInt64 flag = 1; //Start with 1 , 2 power 0 
            foreach (var sc in KeyData)
            {
                bitFlags.Add(sc, flag);
                flag = flag * 2;
            }

        }
        public UInt64 UnSet( string key)
        {
            // doing EXOR sets flag to 0 . since we have banned states . we need to unset the flag. To begin with each Fecility will be intialed to support all States.
            //based on CVS file this , banned States will be unset .
            return value= value ^ bitFlags[key];
        }
        public UInt64 Set(string key)
        {
   
            return value= value | bitFlags[key];
        }
        public bool Check( string key)
        {
            // Since only single bit is set for each state , if bit at that position is set in fecilityStateAllowedFlag , 
            //doing an &  between them gives stateflag for that  state. 

            return ((value & bitFlags[key]) == bitFlags[key]);

        }
    }
}
