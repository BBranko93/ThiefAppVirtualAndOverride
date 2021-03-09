using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAppVirtualAndOverride
{
    class Locksmith
    {
        /// <summary>
        /// The Lockamitha OpenSafe method picks the lock,
        /// opens the safe, and then calls ReturnContents
        /// to get the valuables safely back to the owner.
        /// </summary>
        /// <param name="safe"></param>
        /// <param name="owner"></param>
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }

        public string Combination { private get; set; }

        protected  virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
