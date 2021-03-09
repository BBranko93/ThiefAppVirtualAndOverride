using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAppVirtualAndOverride
{
    class JewelThief : Locksmith
    {
        private string stolenJewels;

        /// <summary>
        /// JewelThief extends Locsmith and inherits
        /// the OpenSafe method and Combination
        /// property, but its ReturnContents method
        /// steals the jewels instead of returning them.
        /// </summary>
        /// <param name="safeContents"></param>
        /// <param name="owner"></param>
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
