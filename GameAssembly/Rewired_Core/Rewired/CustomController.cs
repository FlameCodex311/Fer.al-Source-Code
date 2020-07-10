/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class CustomController : ControllerWithAxes // TypeDefIndex: 5913
	{
		// Fields
		private int _sourceControllerId; // 0x148
		private Func<int, float> axisUpdateCallback; // 0x150
		private Func<int, bool> buttonUpdateCallback; // 0x158
		private bool useUpdateCallbacks; // 0x160
		private Guid _deviceInstanceGuid; // 0x164
	
		// Properties
		public int sourceControllerId { get; } // 0x0000000180A98E90-0x0000000180A98EA0 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180A98DB0-0x0000000180A98E90 
	
		// Constructors
		internal CustomController(eExMuzfIDGIulMIOGUxgcGelxtQ data); // 0x0000000180A98C30-0x0000000180A98DB0
		private CustomController(int controllerId, int sourceControllerId, Guid hardwareTypeGuid, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180A988D0-0x0000000180A98C30
	
		// Methods
		internal void FillData(); // 0x0000000180A97990-0x0000000180A97BD0
		public void SetAxisValue(int index, float value); // 0x0000000180A97E90-0x0000000180A98030
		public void SetAxisValue(string elementName, float value); // 0x0000000180A98030-0x0000000180A98210
		public void SetAxisValueById(int elementId, float value); // 0x0000000180A97CB0-0x0000000180A97E90
		public void SetButtonValue(int index, bool value); // 0x0000000180A98500-0x0000000180A986B0
		public void SetButtonValue(string elementName, bool value); // 0x0000000180A986B0-0x0000000180A988D0
		public void SetButtonValueById(int elementId, bool value); // 0x0000000180A98310-0x0000000180A98500
		public void SetAxisUpdateCallback(Func<int, float> callback); // 0x0000000180A97BD0-0x0000000180A97CB0
		public void SetButtonUpdateCallback(Func<int, bool> callback); // 0x0000000180A98210-0x0000000180A98310
		public void ClearAxisValue(int index); // 0x0000000180A972A0-0x0000000180A97480
		public void ClearAxisValue(string elementName); // 0x0000000180A97100-0x0000000180A972A0
		public void ClearAxisValueById(int elementId); // 0x0000000180A96F70-0x0000000180A97100
		public void ClearButtonValue(int index); // 0x0000000180A977A0-0x0000000180A97990
		public void ClearButtonValue(string elementName); // 0x0000000180A97620-0x0000000180A977A0
		public void ClearButtonValueById(int elementId); // 0x0000000180A97480-0x0000000180A97620
	}
}
