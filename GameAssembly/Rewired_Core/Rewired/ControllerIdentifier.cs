/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct ControllerIdentifier // TypeDefIndex: 5733
	{
		// Fields
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x00
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x04
		private Guid OYSjChAEXTYpiFBMHycpqxKbEmz; // 0x08
		private string OdSoWXsumyESESqfPIKsgkcfXAR; // 0x18
		private Guid HQfpOGFaxPuxONqxAeTQxVlmeig; // 0x20
	
		// Properties
		public int controllerId { get; set; } // 0x0000000180004180-0x0000000180004190 0x0000000180004650-0x0000000180004660
		public ControllerType controllerType { get; set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public Guid hardwareTypeGuid { get; set; } // 0x0000000180004CB0-0x0000000180004CC0 0x0000000180004CF0-0x0000000180004F50
		public string hardwareIdentifier { get; set; } // 0x0000000180002430-0x00000001800024A0 0x0000000180004CE0-0x0000000180004CF0
		public Guid deviceInstanceGuid { get; set; } // 0x0000000180004CA0-0x0000000180004CB0 0x0000000180004CD0-0x0000000180004CE0
		public static ControllerIdentifier Blank { get; } // 0x000000018043E820-0x000000018043E840 
	
		// Constructors
		internal ControllerIdentifier(Controller controller); // 0x0000000180004C90-0x0000000180004CA0
	}
}
