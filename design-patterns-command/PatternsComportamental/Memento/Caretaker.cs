using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Memento
{
    public class Caretaker
    {
        private SnapShot _snapShot;

        public void AddSnapshot(SnapShot snapShot)
        {
            _snapShot = snapShot;
        }

        public SnapShot GetSnapShot()
        {
            return _snapShot;
        }
    }
}
