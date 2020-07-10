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

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

namespace Rewired.Dev.Tools
{
	internal sealed class RawInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 8352
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
		public RawInputJoystickElementIdentifier_Internal(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public void Initialize(GUIText text); // 0x000000018041E1F0-0x000000018041E2E0
		public void Start(); // 0x000000018041E890-0x000000018041EBA0
		public void Update(); // 0x000000018041EC00-0x0000000180421EE0
		public void OnDestroy(); // 0x000000018041E7C0-0x000000018041E810
		private void UpdateDeviceList(); // 0x000000018041EBB0-0x000000018041EC00
		private void SystemDeviceConnected(); // 0x000000018041EBA0-0x000000018041EBB0
		private void SystemDeviceDisconnected(); // 0x000000018041EBA0-0x000000018041EBB0
		private void Refresh(); // 0x000000018041E810-0x000000018041E890
		private void Clear(); // 0x000000018041E170-0x000000018041E1F0
		private void Log(string key, object value); // 0x000000018041E550-0x000000018041E7C0
		private void LogSet(string label, object value); // 0x000000018041E2E0-0x000000018041E550
		private int ddeAaEoPBwfkDXGlLfHOkRXUPnOG(RawInputAxis param_0001140b, int param_0001140c, BqTcaSBfRalwQgsDFLQDaNyqXcCt param_0001140d); // 0x0000000180421EE0-0x0000000180421F70
		private float NormalizeAxis(int value); // 0x0000000180375960-0x00000001803759D0
	}
}
