/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801CE700-0x00000001801CE750
	[CustomObfuscation] // 0x00000001801CE700-0x00000001801CE750
	internal interface IInputSource : IDisposable // TypeDefIndex: 5927
	{
		// Events
		event Action DeviceChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void SystemDeviceConnected();
		void SystemDeviceDisconnected();
		void Update();
		void UpdateDevices(UpdateLoopType updateLoop);
		void UpdateFinished();
		IList<TJoy> GetJoysticks<TJoy>()
			where TJoy : class;
	}
}
