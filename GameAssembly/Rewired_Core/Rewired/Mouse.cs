/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes // TypeDefIndex: 6089
	{
		// Fields
		private TimerAbs mouseAxisPollingTimer; // 0x148
		private float[] cumulativeMousePollingAxes; // 0x150
		private Vector2 _screenPosition; // 0x158
		private Vector2 _screenPositionPrev; // 0x160
		private int _lastScreenPositionUpdateFrame; // 0x168
		private readonly IUnifiedMouseSource _source; // 0x170
		private static Guid s_deviceInstanceGuid; // 0x00
	
		// Properties
		public Vector2 screenPosition { get; } // 0x0000000180EACB30-0x0000000180EACC10 
		public Vector2 screenPositionPrev { get; } // 0x0000000180EACA50-0x0000000180EACB30 
		public Vector2 screenPositionDelta { get; } // 0x0000000180EAC920-0x0000000180EACA50 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180EAC830-0x0000000180EAC920 
	
		// Constructors
		internal Mouse(string name, IUnifiedMouseSource source); // 0x0000000180EAC460-0x0000000180EAC710
		private Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180EAC710-0x0000000180EAC830
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x0000000180EAC3E0-0x0000000180EAC460
		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId); // 0x0000000180EABB70-0x0000000180EAC130
		internal override void Clear(); // 0x0000000180EABAB0-0x0000000180EABB70
		internal override bool SetEnabled(bool state); // 0x0000000180EAC2B0-0x0000000180EAC3E0
		private void RecordMouseScreenPosition(); // 0x0000000180EAC130-0x0000000180EAC2B0
	}
}
