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
	public abstract class ControllerMapSaveData // TypeDefIndex: 6662
	{
		// Fields
		protected Controller _controller; // 0x10
		protected ControllerMap _map; // 0x18
		internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
		// Properties
		public ControllerMap map { get; } // 0x000000018149E4F0-0x000000018149E590 
		public int categoryId { get; } // 0x000000018149DFE0-0x000000018149E090 
		public int layoutId { get; } // 0x000000018149E2D0-0x000000018149E380 
		public Type mapType { get; } // 0x000000018149E440-0x000000018149E4F0 
		public string mapTypeString { get; } // 0x000000018149E380-0x000000018149E440 
		public Controller controller { get; } // 0x000000018149E230-0x000000018149E2D0 
		public ControllerType controllerType { get; } // 0x000000018149E180-0x000000018149E230 
		public string controllerHardwareIdentifier { get; } // 0x000000018149E090-0x000000018149E180 
	
		// Constructors
		internal ControllerMapSaveData(Controller controller, ControllerMap map); // 0x000000018149DF10-0x000000018149DFE0
	
		// Methods
		public T GetMap<T>()
			where T : ControllerMap;
		internal static T AQMpZVIIXTyemnHtIDPtxhINdLN<T>(Controller param_0000db35, ControllerMap param_0000db36)
			where T : ControllerMapSaveData;
		internal static ControllerMapSaveData AQMpZVIIXTyemnHtIDPtxhINdLN(Controller param_0000db37, ControllerMap param_0000db38); // 0x000000018149DC20-0x000000018149DF10
	}
}
