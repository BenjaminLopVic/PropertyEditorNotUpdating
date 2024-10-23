using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEditorNotUpdating
{
    internal class CustomPropertyModel : PropertyDescriptorPropertyModel
    {
        public CustomPropertyModel(object target, PropertyDescriptor propertyDescriptor, EventTriggerer eventTriggerer) : base(target, propertyDescriptor)
        {
            eventTriggerer.EventTriggered += EventTriggerer_EventTriggered;
        }

        private void EventTriggerer_EventTriggered(object sender, EventArgs e)
        {
            NotifyPropertyChanged(nameof(Value));
        }

        protected override object ValueCore
        {
            get
            {
                return base.ValueCore;
            }
            set
            {
                base.ValueCore = value;
            }
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
        }
    }
}
