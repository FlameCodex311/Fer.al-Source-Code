/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct ControllerIdentifier // TypeDefIndex: 5892
	{
		// Fields
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x00
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x04
		private Guid OYSjChAEXTYpiFBMHycpqxKbEmz; // 0x08
		private string OdSoWXsumyESESqfPIKsgkcfXAR; // 0x18
		private Guid HQfpOGFaxPuxONqxAeTQxVlmeig; // 0x20
	
		// Properties
		public int controllerId { get; set; } // 0x0000000180004EC0-0x0000000180004ED0 0x0000000180007630-0x0000000180007640
		public ControllerType controllerType { get; set; } // 0x0000000180003CA0-0x0000000180003FD0 0x00000001800215B0-0x00000001800215C0
		public Guid hardwareTypeGuid { get; set; } // 0x0000000180006C40-0x0000000180006C50 0x0000000180006C90-0x0000000180006CA0
		public string hardwareIdentifier { get; set; } // 0x0000000180003250-0x0000000180003270 0x00000001800215D0-0x0000000180021790
		public Guid deviceInstanceGuid { get; set; } // 0x00000001800215A0-0x00000001800215B0 0x00000001800215C0-0x00000001800215D0
		public static ControllerIdentifier Blank { get; } // 0x00000001808C54F0-0x00000001808C5510 
	
		// Constructors
		internal ControllerIdentifier(Controller controller); // 0x0000000180021590-0x00000001800215A0
	}
}
