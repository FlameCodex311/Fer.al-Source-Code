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
using Rewired.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ControllerExtensions
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class SteamControllerExtension : Controller.Extension // TypeDefIndex: 6083
	{
		// Fields
		private UyxIImwbEVkthHNahEltiXwAzOS EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
	
		// Properties
		private Joystick joystick { get; } // 0x00000001808E5DD0-0x00000001808E5E10 
		internal ISteamControllerInternal internalController { get; } // 0x00000001808AE6A0-0x00000001808AE6C0 
	
		// Nested types
		private class UyxIImwbEVkthHNahEltiXwAzOS : IControllerExtensionSource // TypeDefIndex: 6084
		{
			// Fields
			public readonly ISteamControllerInternal TdwgvaqqNXhCxnZXEasmIqaGgzD; // 0x10
	
			// Constructors
			public UyxIImwbEVkthHNahEltiXwAzOS(ISteamControllerInternal internalController); // 0x0000000180400150-0x0000000180400180
		}
	
		// Constructors
		internal SteamControllerExtension(ISteamControllerInternal internalController); // 0x00000001808E5D60-0x00000001808E5DD0
		private SteamControllerExtension(SteamControllerExtension source); // 0x00000001808E1090-0x00000001808E10F0
	
		// Methods
		public ulong GetActionSetHandle(string actionSetName); // 0x00000001808E44B0-0x00000001808E45F0
		public ulong GetAnalogActionHandle(string actionName); // 0x00000001808E4950-0x00000001808E4A90
		public ulong GetDigitalActionHandle(string actionName); // 0x00000001808E50A0-0x00000001808E51E0
		public string GetActionSetName(ulong actionSetHandle); // 0x00000001808E45F0-0x00000001808E46E0
		public string GetAnalogActionName(ulong actionHandle); // 0x00000001808E4A90-0x00000001808E4B80
		public string GetDigitalActionName(ulong actionHandle); // 0x00000001808E51E0-0x00000001808E52D0
		public Vector2 GetAnalogActionValue(string actionName); // 0x00000001808E4DD0-0x00000001808E4F30
		public Vector2 GetAnalogActionValue(ulong actionHandle); // 0x00000001808E4F30-0x00000001808E50A0
		public bool GetDigitalActionValue(string actionName); // 0x00000001808E5600-0x00000001808E5740
		public bool GetDigitalActionValue(ulong actionHandle); // 0x00000001808E5520-0x00000001808E5600
		public bool SetActiveActionSet(ulong actionSetHandle); // 0x00000001808E5740-0x00000001808E5820
		public bool SetActiveActionSet(string actionSetName); // 0x00000001808E5820-0x00000001808E5960
		public ulong GetActiveActionSetHandle(); // 0x00000001808E46E0-0x00000001808E4810
		public string GetActiveActionSetName(); // 0x00000001808E4810-0x00000001808E4950
		public void ShowBindingPanel(); // 0x00000001808E5C10-0x00000001808E5CE0
		public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds); // 0x00000001808E5960-0x00000001808E5AB0
		public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds); // 0x00000001808E5AB0-0x00000001808E5C10
		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName); // 0x00000001808E52D0-0x00000001808E5430
		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle); // 0x00000001808E5430-0x00000001808E5520
		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName); // 0x00000001808E4C70-0x00000001808E4DD0
		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle); // 0x00000001808E4B80-0x00000001808E4C70
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x00000001803774A0-0x00000001803774B0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x00000001808E5CE0-0x00000001808E5D60
		internal override Controller.Extension Clone(); // 0x00000001808E4420-0x00000001808E44B0
		private void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001803774A0-0x00000001803774B0
	}
}
