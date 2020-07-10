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
	public struct ControllerElementTarget // TypeDefIndex: 5981
	{
		// Fields
		private Controller.Element cHUCjEqvOBmDRNoaTiTRBWLjAMx; // 0x00
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x08
	
		// Properties
		public int elementIdentifierId { get; } // 0x0000000180004C00-0x0000000180004C20 
		public AxisRange axisRange { get; set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public bool hasTarget { get; } // 0x0000000180004C40-0x0000000180004C50 
		public ControllerElementType elementType { get; } // 0x0000000180004C20-0x0000000180004C30 
		public string descriptiveName { get; } // 0x0000000180004AD0-0x0000000180004C00 
		public Controller controller { get; } // 0x0000000180004AC0-0x0000000180004AD0 
		public Controller.Element element { get; set; } // 0x0000000180004C30-0x0000000180004C40 0x0000000180004C60-0x0000000180004C90
	
		// Constructors
		public ControllerElementTarget(ActionElementMap actionElementMap); // 0x0000000180004AA0-0x0000000180004AB0
		public ControllerElementTarget(ControllerElementTarget other); // 0x0000000180004980-0x00000001800049A0
		public ControllerElementTarget(IControllerElementTarget other); // 0x00000001800049A0-0x0000000180004AA0
	
		// Methods
		public static implicit operator ControllerElementTarget(ActionElementMap actionElementMap); // 0x000000018043E6E0-0x000000018043E820
	}
}
