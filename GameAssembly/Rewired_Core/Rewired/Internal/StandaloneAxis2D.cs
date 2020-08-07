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
	[CustomClassObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	[CustomObfuscation] // 0x00000001801DE5D0-0x00000001801DE620
	internal sealed class StandaloneAxis2D // TypeDefIndex: 6604
	{
		// Fields
		[CustomObfuscation] // 0x00000001801F7470-0x00000001801F74D0
		[SerializeField] // 0x00000001801F7470-0x00000001801F74D0
		[Tooltip] // 0x00000001801F7470-0x00000001801F74D0
		private Axis2DCalibration _calibration; // 0x10
		[CustomObfuscation] // 0x00000001801F7890-0x00000001801F78F0
		[SerializeField] // 0x00000001801F7890-0x00000001801F78F0
		[Tooltip] // 0x00000001801F7890-0x00000001801F78F0
		private StandaloneAxis _xAxis; // 0x18
		[CustomObfuscation] // 0x00000001801F7B50-0x00000001801F7BB0
		[SerializeField] // 0x00000001801F7B50-0x00000001801F7BB0
		[Tooltip] // 0x00000001801F7B50-0x00000001801F7BB0
		private StandaloneAxis _yAxis; // 0x20
		private bool _allowEvents; // 0x28
		private ValueChangedEventHandler _ValueChangedEvent; // 0x30
		private ValueChangedEventHandler _RawValueChangedEvent; // 0x38
	
		// Properties
		public Axis2DCalibration calibration { get; } // 0x0000000180372440-0x0000000180372450 
		public StandaloneAxis xAxis { get; } // 0x0000000180372430-0x0000000180372440 
		public StandaloneAxis yAxis { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public Vector2 value { get; } // 0x0000000180EB40B0-0x0000000180EB4200 
		public Vector2 valuePrev { get; } // 0x0000000180EB3F30-0x0000000180EB40B0 
		public Vector2 valueDelta { get; } // 0x0000000180EB3D40-0x0000000180EB3F30 
		public Vector2 rawValue { get; } // 0x0000000180EB3C40-0x0000000180EB3CC0 
		public Vector2 rawValuePrev { get; } // 0x0000000180EB3BC0-0x0000000180EB3C40 
		public Vector2 rawValueDelta { get; } // 0x0000000180EB3AE0-0x0000000180EB3BC0 
		internal Vector2 rawZero { get; } // 0x0000000180EB3CC0-0x0000000180EB3D40 
	
		// Events
		private event ValueChangedEventHandler _ValueChangedEvent {
			add; // 0x0000000180EB3A20-0x0000000180EB3AE0
			remove; // 0x0000000180EB42A0-0x0000000180EB4380
		}
		public event ValueChangedEventHandler ValueChangedEvent {
			add; // 0x0000000180EB3A20-0x0000000180EB3AE0
			remove; // 0x0000000180EB42A0-0x0000000180EB4380
		}
		private event ValueChangedEventHandler _RawValueChangedEvent {
			add; // 0x0000000180EB3960-0x0000000180EB3A20
			remove; // 0x0000000180EB4200-0x0000000180EB42A0
		}
		public event ValueChangedEventHandler RawValueChangedEvent {
			add; // 0x0000000180EB3960-0x0000000180EB3A20
			remove; // 0x0000000180EB4200-0x0000000180EB42A0
		}
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate void ValueChangedEventHandler(Vector2 value); // TypeDefIndex: 6605; 0x0000000180EB50B0-0x0000000180EB53A0
	
		// Constructors
		internal StandaloneAxis2D(); // 0x0000000180EB38C0-0x0000000180EB3960
		internal StandaloneAxis2D(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x0000000180EB3800-0x0000000180EB38C0
	
		// Methods
		public void SetRawValue(float x, float y); // 0x0000000180EB34E0-0x0000000180EB35A0
		public void SetRawValue(Vector2 value); // 0x0000000180EB35A0-0x0000000180EB3660
		public void Clear(); // 0x0000000180EB2830-0x0000000180EB2B70
		internal void Initialize(); // 0x0000000180EB31F0-0x0000000180EB3390
		internal void Deinitialize(); // 0x0000000180EB2C90-0x0000000180EB2CA0
		private void EvalAndSendValueChangeEvents(); // 0x0000000180EB2CA0-0x0000000180EB2F20
		private void Subscribe(); // 0x0000000180EB31F0-0x0000000180EB3390
		private void Unsubscribe(); // 0x0000000180EB3660-0x0000000180EB3800
		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x0000000180EB30A0-0x0000000180EB31F0
		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis); // 0x0000000180EB2F20-0x0000000180EB30A0
		private void OnAxisValueChanged(float value); // 0x0000000180EB3470-0x0000000180EB34E0
		private void OnAxisRawValueChanged(float value); // 0x0000000180EB3390-0x0000000180EB3470
		internal static StandaloneAxis2D CreateRelative(); // 0x0000000180EB2B70-0x0000000180EB2C90
	}
}
