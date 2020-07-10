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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes // TypeDefIndex: 5930
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
		public Vector2 screenPosition { get; } // 0x0000000180635240-0x0000000180635320 
		public Vector2 screenPositionPrev { get; } // 0x0000000180635160-0x0000000180635240 
		public Vector2 screenPositionDelta { get; } // 0x0000000180635030-0x0000000180635160 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180634F40-0x0000000180635030 
	
		// Constructors
		internal Mouse(string name, IUnifiedMouseSource source); // 0x0000000180634B70-0x0000000180634E20
		private Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180634E20-0x0000000180634F40
	
		// Methods
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x0000000180634AF0-0x0000000180634B70
		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId); // 0x0000000180634260-0x0000000180634840
		internal override void Clear(); // 0x00000001806341A0-0x0000000180634260
		internal override bool SetEnabled(bool state); // 0x00000001806349C0-0x0000000180634AF0
		private void RecordMouseScreenPosition(); // 0x0000000180634840-0x00000001806349C0
	}
}
