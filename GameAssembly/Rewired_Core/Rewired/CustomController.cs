/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class CustomController : ControllerWithAxes // TypeDefIndex: 6072
	{
		// Fields
		private int _sourceControllerId; // 0x148
		private Func<int, float> axisUpdateCallback; // 0x150
		private Func<int, bool> buttonUpdateCallback; // 0x158
		private bool useUpdateCallbacks; // 0x160
		private Guid _deviceInstanceGuid; // 0x164
	
		// Properties
		public int sourceControllerId { get; } // 0x00000001810600E0-0x00000001810600F0 
		public override Guid deviceInstanceGuid { get; } // 0x000000018154DDF0-0x000000018154DED0 
	
		// Constructors
		internal CustomController(eExMuzfIDGIulMIOGUxgcGelxtQ data); // 0x000000018154DC70-0x000000018154DDF0
		private CustomController(int controllerId, int sourceControllerId, Guid hardwareTypeGuid, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x000000018154D920-0x000000018154DC70
	
		// Methods
		internal void FillData(); // 0x000000018154CA20-0x000000018154CC50
		public void SetAxisValue(int index, float value); // 0x000000018154CF00-0x000000018154D0A0
		public void SetAxisValue(string elementName, float value); // 0x000000018154D0A0-0x000000018154D270
		public void SetAxisValueById(int elementId, float value); // 0x000000018154CD30-0x000000018154CF00
		public void SetButtonValue(int index, bool value); // 0x000000018154D550-0x000000018154D700
		public void SetButtonValue(string elementName, bool value); // 0x000000018154D700-0x000000018154D920
		public void SetButtonValueById(int elementId, bool value); // 0x000000018154D370-0x000000018154D550
		public void SetAxisUpdateCallback(Func<int, float> callback); // 0x000000018154CC50-0x000000018154CD30
		public void SetButtonUpdateCallback(Func<int, bool> callback); // 0x000000018154D270-0x000000018154D370
		public void ClearAxisValue(int index); // 0x000000018154C350-0x000000018154C520
		public void ClearAxisValue(string elementName); // 0x000000018154C1B0-0x000000018154C350
		public void ClearAxisValueById(int elementId); // 0x000000018154C020-0x000000018154C1B0
		public void ClearButtonValue(int index); // 0x000000018154C840-0x000000018154CA20
		public void ClearButtonValue(string elementName); // 0x000000018154C6C0-0x000000018154C840
		public void ClearButtonValueById(int elementId); // 0x000000018154C520-0x000000018154C6C0
	}
}
