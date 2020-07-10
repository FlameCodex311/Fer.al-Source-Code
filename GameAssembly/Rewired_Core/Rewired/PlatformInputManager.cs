/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal abstract class PlatformInputManager // TypeDefIndex: 5748
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public event Action<BridgedController> DeviceConnectedEvent {
			add; // 0x000000018063ABA0-0x000000018063AC20
			remove; // 0x000000018063AE20-0x000000018063AEA0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent {
			add; // 0x000000018063AC20-0x000000018063ACA0
			remove; // 0x000000018063AEA0-0x000000018063AF20
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent {
			add; // 0x000000018063ADA0-0x000000018063AE20
			remove; // 0x000000018063B020-0x000000018063B0A0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public event Action SystemDeviceConnectedEvent {
			add; // 0x000000018063ACA0-0x000000018063AD20
			remove; // 0x000000018063AF20-0x000000018063AFA0
		}
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public event Action SystemDeviceDisconnectedEvent {
			add; // 0x000000018063AD20-0x000000018063ADA0
			remove; // 0x000000018063AFA0-0x000000018063B020
		}
	
		// Constructors
		protected PlatformInputManager(); // 0x000000018036B6C0-0x000000018036B6D0
	
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
