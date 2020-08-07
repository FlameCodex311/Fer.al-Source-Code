/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class InputSourceWrapper<T> : IInputSource // TypeDefIndex: 5928
	{
		// Fields
		private T JEVAvDAWidJhVxFUpAPvixPZmfz;
		private bool vEblpmllYIOuQHCXVghuIpihdSG;
	
		// Properties
		public T source { get; }
	
		// Events
		public event Action DeviceChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		public InputSourceWrapper(T source);
	
		// Methods
		public void SystemDeviceConnected();
		public void SystemDeviceDisconnected();
		public void Update();
		public void UpdateDevices(UpdateLoopType updateLoop);
		public void UpdateFinished();
		public IList<TJoy> GetJoysticks<TJoy>()
			where TJoy : class;
		public void Dispose();
		~InputSourceWrapper();
		protected virtual void Dispose(bool disposing);
	}
}
