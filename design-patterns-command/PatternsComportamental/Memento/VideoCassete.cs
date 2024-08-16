using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.PatternsComportamental.Memento
{
    public class VideoCassete
    {
        public void ExecutarAcaoVideo()
        {
            Originator originator = new Originator();
            originator.Estado = "play";

            Caretaker caretaker = new Caretaker();
            caretaker.AddSnapshot(originator.CreateSnapshot());

            originator.Estado = "pause";
            originator.Restore(caretaker.GetSnapShot());
        }
    }
}
