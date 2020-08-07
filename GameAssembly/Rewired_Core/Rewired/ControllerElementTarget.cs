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
	public struct ControllerElementTarget // TypeDefIndex: 6140
	{
		// Fields
		private Controller.Element cHUCjEqvOBmDRNoaTiTRBWLjAMx; // 0x00
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x08
	
		// Properties
		public int elementIdentifierId { get; } // 0x0000000180021520-0x0000000180021540 
		public AxisRange axisRange { get; set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public bool hasTarget { get; } // 0x0000000180021550-0x0000000180021560 
		public ControllerElementType elementType { get; } // 0x0000000180021540-0x0000000180021550 
		public string descriptiveName { get; } // 0x00000001800213F0-0x0000000180021520 
		public Controller controller { get; } // 0x00000001800213E0-0x00000001800213F0 
		public Controller.Element element { get; set; } // 0x000000018001A8D0-0x000000018001A8E0 0x000000018001A8F0-0x000000018001A900
	
		// Constructors
		public ControllerElementTarget(ActionElementMap actionElementMap); // 0x00000001800213C0-0x00000001800213D0
		public ControllerElementTarget(ControllerElementTarget other); // 0x00000001800212A0-0x00000001800212C0
		public ControllerElementTarget(IControllerElementTarget other); // 0x00000001800212C0-0x00000001800213C0
	
		// Methods
		public static implicit operator ControllerElementTarget(ActionElementMap actionElementMap); // 0x00000001808C53B0-0x00000001808C54F0
	}
}
