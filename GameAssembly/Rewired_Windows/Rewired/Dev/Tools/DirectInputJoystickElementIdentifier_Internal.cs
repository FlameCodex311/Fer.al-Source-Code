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

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

namespace Rewired.Dev.Tools
{
	internal sealed class DirectInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 8351
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
		public DirectInputJoystickElementIdentifier_Internal(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public void Initialize(GUIText text); // 0x000000018036B1E0-0x000000018036B1F0
		public void Start(); // 0x0000000180416420-0x0000000180416750
		public void Update(); // 0x00000001804167F0-0x0000000180418360
		private void UpdateDeviceList(); // 0x0000000180416760-0x00000001804167F0
		private void SystemDeviceConnected(); // 0x0000000180416750-0x0000000180416760
		private void SystemDeviceDisconnected(); // 0x0000000180416750-0x0000000180416760
		private void Refresh(); // 0x0000000180416390-0x0000000180416420
		private void Clear(); // 0x0000000180416080-0x0000000180416100
		private void Log(string key, object value); // 0x0000000180416100-0x0000000180416370
		private int ddeAaEoPBwfkDXGlLfHOkRXUPnOG(DirectInputAxis param_00011403, eShRWneHfEMQNulXAssvRrsrPZg param_00011404); // 0x0000000180418360-0x00000001804188E0
		private float NormalizeAxis(int value); // 0x0000000180375960-0x00000001803759D0
		public void OnDestroy(); // 0x0000000180416370-0x0000000180416390
	}
}
