using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEditorNotUpdating
{
    public class CustomDataFactory : TypeDescriptorFactory
    {
        private readonly EventTriggerer _eventTriggerer;

        public CustomDataFactory(EventTriggerer eventTriggerer)
        {
            _eventTriggerer = eventTriggerer ?? throw new ArgumentNullException(nameof(eventTriggerer));
        }

        protected override IPropertyModel CreatePropertyModel(object target, PropertyDescriptor propertyDescriptor, IDataFactoryRequest request)
        {
            return new CustomPropertyModel(target,propertyDescriptor,_eventTriggerer);
        }
    }
}
