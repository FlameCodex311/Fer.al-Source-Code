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
	public abstract class ControllerMapSaveData // TypeDefIndex: 6503
	{
		// Fields
		protected Controller _controller; // 0x10
		protected ControllerMap _map; // 0x18
		internal readonly int vSShldFHkaZKEuThltrSgFmPfc; // 0x20
	
		// Properties
		public ControllerMap map { get; } // 0x00000001809FEF70-0x00000001809FF010 
		public int categoryId { get; } // 0x00000001809FEA60-0x00000001809FEB10 
		public int layoutId { get; } // 0x00000001809FED50-0x00000001809FEE00 
		public Type mapType { get; } // 0x00000001809FEEC0-0x00000001809FEF70 
		public string mapTypeString { get; } // 0x00000001809FEE00-0x00000001809FEEC0 
		public Controller controller { get; } // 0x00000001809FECB0-0x00000001809FED50 
		public ControllerType controllerType { get; } // 0x00000001809FEC00-0x00000001809FECB0 
		public string controllerHardwareIdentifier { get; } // 0x00000001809FEB10-0x00000001809FEC00 
	
		// Constructors
		internal ControllerMapSaveData(Controller controller, ControllerMap map); // 0x00000001809FE990-0x00000001809FEA60
	
		// Methods
		public T GetMap<T>()
			where T : ControllerMap;
		internal static T AQMpZVIIXTyemnHtIDPtxhINdLN<T>(Controller param_0000d8c5, ControllerMap param_0000d8c6)
			where T : ControllerMapSaveData;
		internal static ControllerMapSaveData AQMpZVIIXTyemnHtIDPtxhINdLN(Controller param_0000d8c7, ControllerMap param_0000d8c8); // 0x00000001809FE6A0-0x00000001809FE990
	}
}
