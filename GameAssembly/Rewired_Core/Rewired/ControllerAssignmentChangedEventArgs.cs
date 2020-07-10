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
	public sealed class ControllerAssignmentChangedEventArgs : EventArgs // TypeDefIndex: 5725
	{
		// Fields
		private bool rBokgqdrsZuLZsBTVapGfihGpbU; // 0x10
		private int qInCCRhldamcdoUHmMSlSCAIgFUz; // 0x14
		private int tiHDqwuWnAypLNJNoTzBctdWRZt; // 0x18
		private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi; // 0x1C
	
		// Properties
		public bool state { get; } // 0x0000000180375540-0x0000000180375550 
		public Controller controller { get; } // 0x000000018043D550-0x000000018043D630 
		public Player player { get; } // 0x000000018043D630-0x000000018043D710 
	
		// Constructors
		internal ControllerAssignmentChangedEventArgs(int playerId, int controllerId, ControllerType controllerType, bool state); // 0x000000018043D4C0-0x000000018043D550
	}
}
