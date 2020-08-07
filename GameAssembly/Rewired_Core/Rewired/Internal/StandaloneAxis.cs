/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal sealed class StandaloneAxis // TypeDefIndex: 6599
	{
		// Fields
		[CustomObfuscation] // 0x00000001801F4610-0x00000001801F4690
		[Range] // 0x00000001801F4610-0x00000001801F4690
		[SerializeField] // 0x00000001801F4610-0x00000001801F4690
		[Tooltip] // 0x00000001801F4610-0x00000001801F4690
		private float _buttonActivationThreshold; // 0x10
		[CustomObfuscation] // 0x00000001801F4B60-0x00000001801F4BC0
		[SerializeField] // 0x00000001801F4B60-0x00000001801F4BC0
		[Tooltip] // 0x00000001801F4B60-0x00000001801F4BC0
		private AxisCalibration _calibration; // 0x18
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private float _valueRaw; // 0x20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private float _valueRawPrev; // 0x24
		private AxisValueChangedEventHandler dXAglJjpHkbNtdLxhsZnPZwJEng; // 0x28
		private AxisValueChangedEventHandler TaQyEdYwYVHQUwxJDzTbodieLtP; // 0x30
		private ButtonDownEventHandler OLmLRwxptWfeNuvRgDhkOVwWUsu; // 0x38
		private ButtonUpEventHandler gETnJjGtNYDZZudXLejAQtgkEQM; // 0x40
		private ButtonValueChangedEventHandler wFejUNCquyLBROLHKlxMOSVfUXM; // 0x48
		private ButtonDownEventHandler eCajIQOTOCtTifwJnxBRfZhyEtz; // 0x50
		private ButtonUpEventHandler tajjrYdwibecwImnKNvoVUyDgJzI; // 0x58
		private ButtonValueChangedEventHandler fUohedelHJVYiCjiMehPipaUDlv; // 0x60
	
		// Properties
		public float buttonActivationThreshold { get; set; } // 0x0000000180373AA0-0x0000000180373AB0 0x00000001809AA400-0x00000001809AA430
		public AxisCalibration calibration { get; private set; } // 0x0000000180372430-0x0000000180372440 0x00000001809A9B20-0x00000001809A9B30
		public float valueRaw { get; private set; } // 0x0000000180373AF0-0x0000000180373B00 0x00000001809A9B90-0x00000001809A9BD0
		public float valueRawPrev { get; private set; } // 0x000000018090BD10-0x000000018090BD20 0x00000001809AA430-0x00000001809AA470
		public float valueRawDelta { get; } // 0x00000001809AA190-0x00000001809AA1A0 
		public float value { get; } // 0x00000001809AA1A0-0x00000001809AA1C0 
		public float valuePrev { get; } // 0x00000001809AA170-0x00000001809AA190 
		public float valueDelta { get; } // 0x00000001809AA100-0x00000001809AA170 
		public bool rawButtonValue { get; } // 0x00000001809AA050-0x00000001809AA060 
		public bool rawButtonValuePrev { get; } // 0x00000001809AA040-0x00000001809AA050 
		public bool buttonValue { get; } // 0x00000001809A9FE0-0x00000001809AA040 
		public bool buttonValuePrev { get; } // 0x00000001809A9F80-0x00000001809A9FE0 
		internal float rawMin { get; } // 0x00000001809AA0B0-0x00000001809AA0E0 
		internal float rawMax { get; } // 0x00000001809AA060-0x00000001809AA0B0 
		internal float rawZero { get; } // 0x00000001809AA0E0-0x00000001809AA100 
	
		// Events
		private event AxisValueChangedEventHandler _AxisValueChangedEvent {
			add; // 0x00000001809A9BD0-0x00000001809A9C70
			remove; // 0x00000001809A9130-0x00000001809A91F0
		}
		public event AxisValueChangedEventHandler AxisValueChangedEvent {
			add; // 0x00000001809A9BD0-0x00000001809A9C70
			remove; // 0x00000001809A9130-0x00000001809A91F0
		}
		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent {
			add; // 0x00000001809A8F90-0x00000001809A9060
			remove; // 0x00000001809A9E00-0x00000001809A9EA0
		}
		public event AxisValueChangedEventHandler RawAxisValueChangedEvent {
			add; // 0x00000001809A8F90-0x00000001809A9060
			remove; // 0x00000001809A9E00-0x00000001809A9EA0
		}
		private event ButtonDownEventHandler _ButtonDownEvent {
			add; // 0x00000001809A8EA0-0x00000001809A8F90
			remove; // 0x00000001809A9EA0-0x00000001809A9F80
		}
		public event ButtonDownEventHandler ButtonDownEvent {
			add; // 0x00000001809A8EA0-0x00000001809A8F90
			remove; // 0x00000001809A9EA0-0x00000001809A9F80
		}
		private event ButtonUpEventHandler _ButtonUpEvent {
			add; // 0x00000001809A9060-0x00000001809A9130
			remove; // 0x00000001809AA260-0x00000001809AA340
		}
		public event ButtonUpEventHandler ButtonUpEvent {
			add; // 0x00000001809A9060-0x00000001809A9130
			remove; // 0x00000001809AA260-0x00000001809AA340
		}
		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent {
			add; // 0x00000001809A9980-0x00000001809A9A60
			remove; // 0x00000001809A91F0-0x00000001809A92D0
		}
		public event ButtonValueChangedEventHandler ButtonValueChangedEvent {
			add; // 0x00000001809A9980-0x00000001809A9A60
			remove; // 0x00000001809A91F0-0x00000001809A92D0
		}
		private event ButtonDownEventHandler _RawButtonDownEvent {
			add; // 0x00000001809A9A60-0x00000001809A9B20
			remove; // 0x00000001809AA1C0-0x00000001809AA260
		}
		public event ButtonDownEventHandler RawButtonDownEvent {
			add; // 0x00000001809A9A60-0x00000001809A9B20
			remove; // 0x00000001809AA1C0-0x00000001809AA260
		}
		private event ButtonUpEventHandler _RawButtonUpEvent {
			add; // 0x00000001809A9C70-0x00000001809A9D30
			remove; // 0x00000001809AA340-0x00000001809AA400
		}
		public event ButtonUpEventHandler RawButtonUpEvent {
			add; // 0x00000001809A9C70-0x00000001809A9D30
			remove; // 0x00000001809AA340-0x00000001809AA400
		}
		private event ButtonValueChangedEventHandler _RawButtonValueChangedEvent {
			add; // 0x00000001809A9D30-0x00000001809A9E00
			remove; // 0x00000001809A98C0-0x00000001809A9980
		}
		public event ButtonValueChangedEventHandler RawButtonValueChangedEvent {
			add; // 0x00000001809A9D30-0x00000001809A9E00
			remove; // 0x00000001809A98C0-0x00000001809A9980
		}
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate void AxisValueChangedEventHandler(float value); // TypeDefIndex: 6600; 0x0000000180869B60-0x0000000180869E50
	
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate void ButtonValueChangedEventHandler(bool value); // TypeDefIndex: 6601; 0x0000000180E9DBE0-0x0000000180E9DE60
	
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate void ButtonDownEventHandler(); // TypeDefIndex: 6602; 0x00000001803FE8A0-0x00000001803FEA40
	
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate void ButtonUpEventHandler(); // TypeDefIndex: 6603; 0x00000001803FE8A0-0x00000001803FEA40
	
		// Constructors
		internal StandaloneAxis(); // 0x00000001809A9B30-0x00000001809A9B90
	
		// Methods
		public void SetRawValue(float value); // 0x00000001809A92D0-0x00000001809A98C0
		public void Clear(); // 0x00000001809A8DD0-0x00000001809A8E00
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static StandaloneAxis CreateRelative(); // 0x00000001809A8E00-0x00000001809A8EA0
	}
}
