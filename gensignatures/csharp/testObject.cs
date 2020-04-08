using System;
using System.Runtime.Serialization;

namespace genSignatures
{
    [Serializable]
    public class testObject
    {
        public string testProperty;
        
        public testObject() {
            this.testProperty = "test property";
        }
    }
}
