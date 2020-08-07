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
	public struct ControllerTemplateElementTarget // TypeDefIndex: 6139
	{
		// Fields
		private IControllerTemplateElement cHUCjEqvOBmDRNoaTiTRBWLjAMx; // 0x00
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x08
	
		// Properties
		public AxisRange axisRange { get; set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public ControllerTemplateElementType elementType { get; } // 0x00000001800C5900-0x00000001800C5950 
		public string descriptiveName { get; } // 0x00000001800C58F0-0x00000001800C5900 
		public IControllerTemplateElement element { get; set; } // 0x000000018001A8D0-0x000000018001A8E0 0x000000018001A8F0-0x000000018001A900
		public IControllerTemplate template { get; } // 0x00000001800C5950-0x00000001800C5B80 
		public bool hasTarget { get; } // 0x0000000180021550-0x0000000180021560 
	
		// Constructors
		internal ControllerTemplateElementTarget(IControllerTemplateElement element, AxisRange axisRange); // 0x00000001800C5870-0x00000001800C58F0
		public ControllerTemplateElementTarget(ControllerTemplateElementTarget other); // 0x00000001800212A0-0x00000001800212C0
	}
}
