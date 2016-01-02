using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04_Student
{
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs eventArgs);

    public class PropertyChangedEventArgs
    {
        
        public PropertyChangedEventArgs(string propertyName,dynamic oldValue, dynamic newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }

        public dynamic OldValue { get; set; }

        public dynamic NewValue { get; set; }
    }
}
