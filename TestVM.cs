using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEditorNotUpdating
{
    public class TestVM : ObservableObject
    {
        private bool boolValue =false;
        private int intValue =0;
        public string StringProperty 
        {
            get => DateTime.Now.ToString("hh:mm:ss");
            set => OnPropertyChanged(nameof(StringProperty));
        }

        [Editor(typeof(CustomStringPropertyEditor), typeof(PropertyEditor))]
        public string StringPropertyWithCustomPropertyEditor
        {
            get => DateTime.Now.ToString("hh:mm:ss");
            set => OnPropertyChanged(nameof(StringPropertyWithCustomPropertyEditor));
        }

        public int IntProperty 
        {
            get => intValue++;
            set => OnPropertyChanged(nameof(IntProperty));
        }

        [Editor(typeof(CustomIntPropertyEditor), typeof(PropertyEditor))]
        public int IntPropertyWithCustomPropertyEditor
        {
            get => intValue++;
            set => OnPropertyChanged(nameof(IntPropertyWithCustomPropertyEditor));
        }


        public bool BoolProperty 
        { 
            get
            {
                boolValue = !boolValue;
                return boolValue;
            }
            set => OnPropertyChanged(nameof(BoolProperty));
        }
    }
}
