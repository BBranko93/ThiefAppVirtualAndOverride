using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAppVirtualAndOverride
{
    class Safe
    {
        private string contents = "precious jewels";
        private string safeCombination = "12345";

        /// <summary>
        /// A Safe object keeps valuables in its "contents" field.
        /// It doesn't return them unless Open is called with the
        /// right combination...or if a locksmith picks the lock.
        /// </summary>
        /// <param name="combination"></param>
        /// <returns></returns>
        public string Open(string combination)
        {
            if (combination == safeCombination) return contents;
            return "";
        }

        /// <summary>
        /// Adding a Locksmith class that can pick the combination by 
        /// calling the PickLock method and passing in a reference to
        /// itself. The Safe will use its write-only Combination property
        /// to give the Locksmith the combination.
        /// </summary>
        /// <param name="lockpicker"></param>
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
}
