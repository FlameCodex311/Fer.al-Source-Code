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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ControllerExtensions
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class SteamControllerExtension : Controller.Extension // TypeDefIndex: 5924
	{
		// Fields
		private UyxIImwbEVkthHNahEltiXwAzOS EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
	
		// Properties
		private Joystick joystick { get; } // 0x000000018045F560-0x000000018045F5A0 
		internal ISteamControllerInternal internalController { get; } // 0x000000018045F540-0x000000018045F560 
	
		// Nested types
		private class UyxIImwbEVkthHNahEltiXwAzOS : IControllerExtensionSource // TypeDefIndex: 5925
		{
			// Fields
			public readonly ISteamControllerInternal TdwgvaqqNXhCxnZXEasmIqaGgzD; // 0x10
	
			// Constructors
			public UyxIImwbEVkthHNahEltiXwAzOS(ISteamControllerInternal internalController); // 0x000000018037D3F0-0x000000018037D420
		}
	
		// Constructors
		internal SteamControllerExtension(ISteamControllerInternal internalController); // 0x000000018045F4D0-0x000000018045F540
		private SteamControllerExtension(SteamControllerExtension source); // 0x000000018045A5E0-0x000000018045A640
	
		// Methods
		public ulong GetActionSetHandle(string actionSetName); // 0x000000018045DC00-0x000000018045DD40
		public ulong GetAnalogActionHandle(string actionName); // 0x000000018045E0B0-0x000000018045E1F0
		public ulong GetDigitalActionHandle(string actionName); // 0x000000018045E800-0x000000018045E940
		public string GetActionSetName(ulong actionSetHandle); // 0x000000018045DD40-0x000000018045DE30
		public string GetAnalogActionName(ulong actionHandle); // 0x000000018045E1F0-0x000000018045E2E0
		public string GetDigitalActionName(ulong actionHandle); // 0x000000018045E940-0x000000018045EA30
		public Vector2 GetAnalogActionValue(string actionName); // 0x000000018045E530-0x000000018045E690
		public Vector2 GetAnalogActionValue(ulong actionHandle); // 0x000000018045E690-0x000000018045E800
		public bool GetDigitalActionValue(string actionName); // 0x000000018045ED60-0x000000018045EEA0
		public bool GetDigitalActionValue(ulong actionHandle); // 0x000000018045EC80-0x000000018045ED60
		public bool SetActiveActionSet(ulong actionSetHandle); // 0x000000018045EEA0-0x000000018045EF80
		public bool SetActiveActionSet(string actionSetName); // 0x000000018045EF80-0x000000018045F0C0
		public ulong GetActiveActionSetHandle(); // 0x000000018045DE30-0x000000018045DF70
		public string GetActiveActionSetName(); // 0x000000018045DF70-0x000000018045E0B0
		public void ShowBindingPanel(); // 0x000000018045F380-0x000000018045F450
		public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds); // 0x000000018045F0C0-0x000000018045F220
		public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds); // 0x000000018045F220-0x000000018045F380
		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName); // 0x000000018045EA30-0x000000018045EB90
		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle); // 0x000000018045EB90-0x000000018045EC80
		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName); // 0x000000018045E3D0-0x000000018045E530
		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle); // 0x000000018045E2E0-0x000000018045E3D0
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x00000001803581E0-0x00000001803581F0
		internal override void SourceUpdated(IControllerExtensionSource source); // 0x000000018045F450-0x000000018045F4D0
		internal override Controller.Extension Clone(); // 0x000000018045DB70-0x000000018045DC00
		private void ItdhavHGXcUkAhyjaCFbIXENJheh(); // 0x00000001803581E0-0x00000001803581F0
	}
}
