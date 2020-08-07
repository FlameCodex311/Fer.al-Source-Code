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
	public sealed class ControllerStatusChangedEventArgs : EventArgs // TypeDefIndex: 5883
	{
		// Fields
		private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x10
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x18
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x1C
	
		// Properties
		public string name { get; } // 0x0000000180372440-0x0000000180372450 
		public int controllerId { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public ControllerType controllerType { get; } // 0x00000001803FB770-0x00000001803FB780 
		public Controller controller { get; } // 0x000000018153C6A0-0x000000018153C780 
	
		// Constructors
		public ControllerStatusChangedEventArgs(string name, int uniqueId, ControllerType controllerType); // 0x000000018153C610-0x000000018153C6A0
	}
}
