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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal sealed class StandaloneAxis // TypeDefIndex: 6440
	{
		// Fields
		[CustomObfuscation] // 0x0000000180158DA0-0x0000000180158E20
		[Range] // 0x0000000180158DA0-0x0000000180158E20
		[SerializeField] // 0x0000000180158DA0-0x0000000180158E20
		[Tooltip] // 0x0000000180158DA0-0x0000000180158E20
		private float _buttonActivationThreshold; // 0x10
		[CustomObfuscation] // 0x00000001801590C0-0x0000000180159120
		[SerializeField] // 0x00000001801590C0-0x0000000180159120
		[Tooltip] // 0x00000001801590C0-0x0000000180159120
		private AxisCalibration _calibration; // 0x18
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private float _valueRaw; // 0x20
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
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
		public float buttonActivationThreshold { get; set; } // 0x0000000180493360-0x0000000180493370 0x0000000180493820-0x0000000180493850
		public AxisCalibration calibration { get; private set; } // 0x000000018038B150-0x000000018038B160 0x0000000180492F00-0x0000000180492F10
		public float valueRaw { get; private set; } // 0x0000000180487DA0-0x0000000180487DB0 0x0000000180492F70-0x0000000180492FB0
		public float valueRawPrev { get; private set; } // 0x00000001804935B0-0x00000001804935C0 0x0000000180493850-0x0000000180493890
		public float valueRawDelta { get; } // 0x00000001804935A0-0x00000001804935B0 
		public float value { get; } // 0x00000001804935C0-0x00000001804935E0 
		public float valuePrev { get; } // 0x0000000180493580-0x00000001804935A0 
		public float valueDelta { get; } // 0x0000000180493510-0x0000000180493580 
		public bool rawButtonValue { get; } // 0x0000000180493460-0x0000000180493470 
		public bool rawButtonValuePrev { get; } // 0x0000000180493450-0x0000000180493460 
		public bool buttonValue { get; } // 0x00000001804933E0-0x0000000180493450 
		public bool buttonValuePrev { get; } // 0x0000000180493370-0x00000001804933E0 
		internal float rawMin { get; } // 0x00000001804934C0-0x00000001804934F0 
		internal float rawMax { get; } // 0x0000000180493470-0x00000001804934C0 
		internal float rawZero { get; } // 0x00000001804934F0-0x0000000180493510 
	
		// Events
		private event AxisValueChangedEventHandler _AxisValueChangedEvent {
			add; // 0x0000000180492FB0-0x0000000180493050
			remove; // 0x0000000180492500-0x00000001804925C0
		}
		public event AxisValueChangedEventHandler AxisValueChangedEvent {
			add; // 0x0000000180492FB0-0x0000000180493050
			remove; // 0x0000000180492500-0x00000001804925C0
		}
		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent {
			add; // 0x0000000180492360-0x0000000180492430
			remove; // 0x00000001804931E0-0x0000000180493280
		}
		public event AxisValueChangedEventHandler RawAxisValueChangedEvent {
			add; // 0x0000000180492360-0x0000000180492430
			remove; // 0x00000001804931E0-0x0000000180493280
		}
		private event ButtonDownEventHandler _ButtonDownEvent {
			add; // 0x0000000180492270-0x0000000180492360
			remove; // 0x0000000180493280-0x0000000180493360
		}
		public event ButtonDownEventHandler ButtonDownEvent {
			add; // 0x0000000180492270-0x0000000180492360
			remove; // 0x0000000180493280-0x0000000180493360
		}
		private event ButtonUpEventHandler _ButtonUpEvent {
			add; // 0x0000000180492430-0x0000000180492500
			remove; // 0x0000000180493680-0x0000000180493760
		}
		public event ButtonUpEventHandler ButtonUpEvent {
			add; // 0x0000000180492430-0x0000000180492500
			remove; // 0x0000000180493680-0x0000000180493760
		}
		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent {
			add; // 0x0000000180492D60-0x0000000180492E40
			remove; // 0x00000001804925C0-0x00000001804926A0
		}
		public event ButtonValueChangedEventHandler ButtonValueChangedEvent {
			add; // 0x0000000180492D60-0x0000000180492E40
			remove; // 0x00000001804925C0-0x00000001804926A0
		}
		private event ButtonDownEventHandler _RawButtonDownEvent {
			add; // 0x0000000180492E40-0x0000000180492F00
			remove; // 0x00000001804935E0-0x0000000180493680
		}
		public event ButtonDownEventHandler RawButtonDownEvent {
			add; // 0x0000000180492E40-0x0000000180492F00
			remove; // 0x00000001804935E0-0x0000000180493680
		}
		private event ButtonUpEventHandler _RawButtonUpEvent {
			add; // 0x0000000180493050-0x0000000180493110
			remove; // 0x0000000180493760-0x0000000180493820
		}
		public event ButtonUpEventHandler RawButtonUpEvent {
			add; // 0x0000000180493050-0x0000000180493110
			remove; // 0x0000000180493760-0x0000000180493820
		}
		private event ButtonValueChangedEventHandler _RawButtonValueChangedEvent {
			add; // 0x0000000180493110-0x00000001804931E0
			remove; // 0x0000000180492CA0-0x0000000180492D60
		}
		public event ButtonValueChangedEventHandler RawButtonValueChangedEvent {
			add; // 0x0000000180493110-0x00000001804931E0
			remove; // 0x0000000180492CA0-0x0000000180492D60
		}
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate void AxisValueChangedEventHandler(float value); // TypeDefIndex: 6441; 0x0000000180480520-0x00000001804807C0
	
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate void ButtonValueChangedEventHandler(bool value); // TypeDefIndex: 6442; 0x0000000180625FD0-0x0000000180626220
	
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate void ButtonDownEventHandler(); // TypeDefIndex: 6443; 0x00000001804C7D50-0x00000001804C7EF0
	
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate void ButtonUpEventHandler(); // TypeDefIndex: 6444; 0x00000001804C7D50-0x00000001804C7EF0
	
		// Constructors
		internal StandaloneAxis(); // 0x0000000180492F10-0x0000000180492F70
	
		// Methods
		public void SetRawValue(float value); // 0x00000001804926A0-0x0000000180492CA0
		public void Clear(); // 0x00000001804921A0-0x00000001804921D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal static StandaloneAxis CreateRelative(); // 0x00000001804921D0-0x0000000180492270
	}
}
