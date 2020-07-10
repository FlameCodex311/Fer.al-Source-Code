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
	public sealed class ControllerStatusChangedEventArgs : EventArgs // TypeDefIndex: 5724
	{
		// Fields
		private string MYcWDFnyndJzsFpKvFFizAMuaiT; // 0x10
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x18
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x1C
	
		// Properties
		public string name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public int controllerId { get; } // 0x0000000180367710-0x0000000180367720 
		public ControllerType controllerType { get; } // 0x000000018037E420-0x000000018037E430 
		public Controller controller { get; } // 0x0000000180A87230-0x0000000180A87310 
	
		// Constructors
		public ControllerStatusChangedEventArgs(string name, int uniqueId, ControllerType controllerType); // 0x0000000180A871A0-0x0000000180A87230
	}
}
