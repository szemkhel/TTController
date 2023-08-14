using System;
using System.Collections.Generic;
using System.Linq;
using TTController.Common.Plugin;

namespace TTController.Plugin.SwafanTrioController
{
    public class SwafanTrioControllerDefinition : IControllerDefinition
    {
        public string Name => "Swafan Trio";
        public int VendorId => 0x264a;
        public IEnumerable<int> ProductIds => new[] { 0x232B, 0x232C, 0x232D };
        public int PortCount => 5;
        public Type ControllerProxyType => typeof(SwafanTrioControllerProxy);
    }
}