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
	public struct ControllerTemplateElementTarget // TypeDefIndex: 5980
	{
		// Fields
		private IControllerTemplateElement cHUCjEqvOBmDRNoaTiTRBWLjAMx; // 0x00
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR; // 0x08
	
		// Properties
		public AxisRange axisRange { get; set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public ControllerTemplateElementType elementType { get; } // 0x000000018001A780-0x000000018001A7D0 
		public string descriptiveName { get; } // 0x000000018001A770-0x000000018001A780 
		public IControllerTemplateElement element { get; set; } // 0x0000000180004C30-0x0000000180004C40 0x0000000180004C60-0x0000000180004C90
		public IControllerTemplate template { get; } // 0x000000018001A7D0-0x000000018001AAF0 
		public bool hasTarget { get; } // 0x0000000180004C40-0x0000000180004C50 
	
		// Constructors
		internal ControllerTemplateElementTarget(IControllerTemplateElement element, AxisRange axisRange); // 0x000000018001A6E0-0x000000018001A770
		public ControllerTemplateElementTarget(ControllerTemplateElementTarget other); // 0x0000000180004980-0x00000001800049A0
	}
}
