﻿/*
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
	public sealed class ControllerAssignmentChangedEventArgs : EventArgs // TypeDefIndex: 5884
	{
		// Fields
		private bool rBokgqdrsZuLZsBTVapGfihGpbU; // 0x10
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x14
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x18
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x1C
	
		// Properties
		public bool state { get; } // 0x00000001803FD450-0x00000001803FD460 
		public Controller controller { get; } // 0x00000001808C4280-0x00000001808C4360 
		public Player player { get; } // 0x00000001808C4360-0x00000001808C4440 
	
		// Constructors
		internal ControllerAssignmentChangedEventArgs(int playerId, int controllerId, ControllerType controllerType, bool state); // 0x00000001808C41F0-0x00000001808C4280
	}
}
