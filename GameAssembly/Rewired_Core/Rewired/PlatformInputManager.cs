/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	internal abstract class PlatformInputManager // TypeDefIndex: 5907
	{
		// Fields
		protected Action<BridgedController> _DeviceConnectedEvent; // 0x10
		protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent; // 0x18
		protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent; // 0x20
		protected Action _SystemDeviceConnectedEvent; // 0x28
		protected Action _SystemDeviceDisconnectedEvent; // 0x30
	
		// Properties
		public abstract int deviceCount { get; }
		public abstract PlatformInputManager primaryInputManager { get; }
		public abstract IInputSource inputSource { get; }
		public abstract InputSource inputSourceType { get; }
	
		// Events
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public event Action<BridgedController> DeviceConnectedEvent {
			add; // 0x0000000180EB2330-0x0000000180EB23B0
			remove; // 0x0000000180EB25B0-0x0000000180EB2630
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent {
			add; // 0x0000000180EB23B0-0x0000000180EB2430
			remove; // 0x0000000180EB2630-0x0000000180EB26B0
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent {
			add; // 0x0000000180EB2530-0x0000000180EB25B0
			remove; // 0x0000000180EB27B0-0x0000000180EB2830
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public event Action SystemDeviceConnectedEvent {
			add; // 0x0000000180EB2430-0x0000000180EB24B0
			remove; // 0x0000000180EB26B0-0x0000000180EB2730
		}
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public event Action SystemDeviceDisconnectedEvent {
			add; // 0x0000000180EB24B0-0x0000000180EB2530
			remove; // 0x0000000180EB2730-0x0000000180EB27B0
		}
	
		// Constructors
		protected PlatformInputManager(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void Initialize();
		public abstract void Update(UpdateLoopType currentUpdateLoop);
		public abstract void OnDestroy();
		public abstract void SystemDeviceConnected();
		public abstract void SystemDeviceDisconnected();
		public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);
		public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();
		public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);
		public abstract IUnifiedMouseSource GetUnifiedMouseSource();
		public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();
	}
}
