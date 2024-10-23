using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEditorNotUpdating
{
    public class EventTriggerer
    {
        public event EventHandler EventTriggered;

        public void Trigger()
        {
            EventTriggered?.Invoke(this, EventArgs.Empty);
        }
    }
}
