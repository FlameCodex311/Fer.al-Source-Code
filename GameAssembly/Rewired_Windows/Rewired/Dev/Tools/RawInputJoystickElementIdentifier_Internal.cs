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
using Rewired.Platforms;

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

namespace Rewired.Dev.Tools
{
	internal sealed class RawInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 8518
	{
		// Fields
		private GUIText text; // 0x10
		private string textBuffer; // 0x18
		private int currentDeviceId; // 0x20
		private cYlAfcdADTAvQlmuxaJgtYKFWccL VWJOXOMpXWfVyKpvXKaAPfAuhHw; // 0x28
		private jthDIAoCHabfPhfENmcAOLMgmdT uOngPHAGiEcguaqBrhxOlGdhSTAO; // 0x30
		private Guid deviceInstanceGuid; // 0x38
		private IList<jthDIAoCHabfPhfENmcAOLMgmdT> ehFHwSOiqwwdIKxglarzKVHRGdz; // 0x48
		private bool showAllDevices; // 0x50
		private bool refreshNow; // 0x51
		private bool ready; // 0x52
		private string[] axisNames; // 0x58
		private int[] axisValues; // 0x60
	
		// Constructors
		public RawInputJoystickElementIdentifier_Internal(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public void Initialize(GUIText text); // 0x0000000180829E00-0x0000000180829EF0
		public void Start(); // 0x000000018082A460-0x000000018082A770
		public void Update(); // 0x000000018082A7D0-0x000000018082D870
		public void OnDestroy(); // 0x000000018082A390-0x000000018082A3E0
		private void UpdateDeviceList(); // 0x000000018082A780-0x000000018082A7D0
		private void SystemDeviceConnected(); // 0x000000018082A770-0x000000018082A780
		private void SystemDeviceDisconnected(); // 0x000000018082A770-0x000000018082A780
		private void Refresh(); // 0x000000018082A3E0-0x000000018082A460
		private void Clear(); // 0x0000000180829D80-0x0000000180829E00
		private void Log(string key, object value); // 0x000000018082A140-0x000000018082A390
		private void LogSet(string label, object value); // 0x0000000180829EF0-0x000000018082A140
		private int ddeAaEoPBwfkDXGlLfHOkRXUPnOG(RawInputAxis param_000116af, int param_000116b0, BqTcaSBfRalwQgsDFLQDaNyqXcCt param_000116b1); // 0x000000018082D870-0x000000018082D900
		private float NormalizeAxis(int value); // 0x00000001804247F0-0x0000000180424860
	}
}
