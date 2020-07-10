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
	[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	internal sealed class StandaloneAxis2D // TypeDefIndex: 6445
	{
		// Fields
		[CustomObfuscation] // 0x0000000180159EC0-0x0000000180159F20
		[SerializeField] // 0x0000000180159EC0-0x0000000180159F20
		[Tooltip] // 0x0000000180159EC0-0x0000000180159F20
		private Axis2DCalibration _calibration; // 0x10
		[CustomObfuscation] // 0x000000018015A1E0-0x000000018015A240
		[SerializeField] // 0x000000018015A1E0-0x000000018015A240
		[Tooltip] // 0x000000018015A1E0-0x000000018015A240
		private StandaloneAxis _xAxis; // 0x18
		[CustomObfuscation] // 0x000000018015A630-0x000000018015A690
		[SerializeField] // 0x000000018015A630-0x000000018015A690
		[Tooltip] // 0x000000018015A630-0x000000018015A690
		private StandaloneAxis _yAxis; // 0x20
		private bool _allowEvents; // 0x28
		private ValueChangedEventHandler _ValueChangedEvent; // 0x30
		private ValueChangedEventHandler _RawValueChangedEvent; // 0x38
	
		// Properties
		public Axis2DCalibration calibration { get; } // 0x000000018036AC80-0x000000018036AC90 
		public StandaloneAxis xAxis { get; } // 0x000000018038B150-0x000000018038B160 
		public StandaloneAxis yAxis { get; } // 0x000000018036AC70-0x000000018036AC80 
		public Vector2 value { get; } // 0x000000018063C960-0x000000018063CAB0 
		public Vector2 valuePrev { get; } // 0x000000018063C7E0-0x000000018063C960 
		public Vector2 valueDelta { get; } // 0x000000018063C5F0-0x000000018063C7E0 
		public Vector2 rawValue { get; } // 0x000000018063C4F0-0x000000018063C570 
		public Vector2 rawValuePrev { get; } // 0x000000018063C470-0x000000018063C4F0 
		public Vector2 rawValueDelta { get; } // 0x000000018063C390-0x000000018063C470 
		internal Vector2 rawZero { get; } // 0x000000018063C570-0x000000018063C5F0 
	
		// Events
		private event ValueChangedEventHandler _ValueChangedEvent {
			add; // 0x000000018063C2D0-0x000000018063C390
			remove; // 0x000000018063CB50-0x000000018063CC30
		}
		public event ValueChangedEventHandler ValueChangedEvent {
			add; // 0x000000018063C2D0-0x000000018063C390
			remove; // 0x000000018063CB50-0x000000018063CC30
		}
		private event ValueChangedEventHandler _RawValueChangedEvent {
			add; // 0x000000018063C210-0x000000018063C2D0
			remove; // 0x000000018063CAB0-0x000000018063CB50
		}
		public event ValueChangedEventHandler RawValueChangedEvent {
			add; // 0x000000018063C210-0x000000018063C2D0
			remove; // 0x000000018063CAB0-0x000000018063CB50
		}
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate void ValueChangedEventHandler(Vector2 value); // TypeDefIndex: 6446; 0x000000018063D980-0x000000018063DC30
	
		// Constructors
		internal StandaloneAxis2D(); // 0x000000018063C170-0x000000018063C210
		internal StandaloneAxis2D(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x000000018063C0B0-0x000000018063C170
	
		// Methods
		public void SetRawValue(float x, float y); // 0x000000018063BD80-0x000000018063BE40
		public void SetRawValue(Vector2 value); // 0x000000018063BE40-0x000000018063BF00
		public void Clear(); // 0x000000018063B0A0-0x000000018063B3E0
		internal void Initialize(); // 0x000000018063BA70-0x000000018063BC20
		internal void Deinitialize(); // 0x000000018063B510-0x000000018063B520
		private void EvalAndSendValueChangeEvents(); // 0x000000018063B520-0x000000018063B7A0
		private void Subscribe(); // 0x000000018063BA70-0x000000018063BC20
		private void Unsubscribe(); // 0x000000018063BF00-0x000000018063C0B0
		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x000000018063B920-0x000000018063BA70
		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x000000018063B7A0-0x000000018063B920
		private void OnAxisValueChanged(float value); // 0x000000018063BD00-0x000000018063BD80
		private void OnAxisRawValueChanged(float value); // 0x000000018063BC20-0x000000018063BD00
		internal static StandaloneAxis2D CreateRelative(); // 0x000000018063B3E0-0x000000018063B510
	}
}
