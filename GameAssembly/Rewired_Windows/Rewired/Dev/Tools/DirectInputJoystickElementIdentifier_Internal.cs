/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Libraries.SharpDX.DirectInput;
using Rewired.Platforms;
using Rewired.Utils.Classes.Utility;

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

namespace Rewired.Dev.Tools
{
	internal sealed class DirectInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 8517
	{
		// Fields
		private GUIText text; // 0x10
		private string textBuffer; // 0x18
		private int currentDeviceId; // 0x20
		private DirectInput GPmLgdQQlgLidwdHkXEIaVlTCCA; // 0x28
		private SlQJAJyPmnQOiXQNEoKZMinAMhO uOngPHAGiEcguaqBrhxOlGdhSTAO; // 0x30
		private Guid deviceInstanceGuid; // 0x38
		private IList<AWARuLKFrIKzIKknTkXdungFUra> ehFHwSOiqwwdIKxglarzKVHRGdz; // 0x48
		private IList<AWARuLKFrIKzIKknTkXdungFUra> iiQlPCDfPhZnhPkHEqkMfGrrkKo; // 0x50
		private bool showAllDevices; // 0x58
		private bool refreshNow; // 0x59
		private bool ready; // 0x5A
		private int rawDeviceCount; // 0x5C
		private TimerRealTime cEsxSKeemeADmVePpHfVxMflGqu; // 0x60
	
		// Constructors
		public DirectInputJoystickElementIdentifier_Internal(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public void Initialize(GUIText text); // 0x0000000180379F20-0x0000000180379F30
		public void Start(); // 0x0000000180822410-0x0000000180822730
		public void Update(); // 0x00000001808227D0-0x0000000180824240
		private void UpdateDeviceList(); // 0x0000000180822740-0x00000001808227D0
		private void SystemDeviceConnected(); // 0x0000000180822730-0x0000000180822740
		private void SystemDeviceDisconnected(); // 0x0000000180822730-0x0000000180822740
		private void Refresh(); // 0x0000000180822380-0x0000000180822410
		private void Clear(); // 0x0000000180822090-0x0000000180822110
		private void Log(string key, object value); // 0x0000000180822110-0x0000000180822360
		private int ddeAaEoPBwfkDXGlLfHOkRXUPnOG(DirectInputAxis param_000116a7, eShRWneHfEMQNulXAssvRrsrPZg param_000116a8); // 0x0000000180824240-0x0000000180824760
		private float NormalizeAxis(int value); // 0x00000001804247F0-0x0000000180424860
		public void OnDestroy(); // 0x0000000180822360-0x0000000180822380
	}
}
