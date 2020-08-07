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
using Rewired.ControllerExtensions;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal interface ISteamControllerInternal // TypeDefIndex: 6527
	{
		// Properties
		int MaxActionSourceCount { get; }
		bool IsConnected { get; }
	
		// Methods
		string GetActionSetName(ulong handle);
		string GetDigitalActionName(ulong handle);
		string GetAnalogActionName(ulong handle);
		ulong GetActionSetHandle(ref string actionSetName);
		ulong GetDigitalActionHandle(ref string actionName);
		ulong GetAnalogActionHandle(ref string actionName);
		bool GetDigitalActionValue(ulong actionHandle);
		bool GetDigitalActionValue(ref string actionName);
		Vector2 GetAnalogActionValue(ulong actionHandle);
		Vector2 GetAnalogActionValue(ref string actionName);
		bool SetActiveActionSet(ulong actionSetHandle);
		bool SetActiveActionSet(ref string actionSetName);
		ulong GetActiveActionSetHandle();
		string GetActiveActionSetName();
		void ShowBindingPanel();
		void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds);
		void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds);
		IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName);
		IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle);
		IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName);
		IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle);
	}
}
