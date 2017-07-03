using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyServiceSample
{
 
        public enum DeviceOrientations
        {
            Undefined,
            Landscape,
            Portrait
        }

        public interface IDeviceOrientation
        {
            DeviceOrientations GetOrientation();
        }
    
}
