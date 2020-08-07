/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ControllerExtensions
{
	public sealed class DualShock4Extension : Controller.Extension, IDualShock4Extension // TypeDefIndex: 6075
	{
		// Fields
		private CCARidKdkHWupJlanLcBYGeGRlz JEVAvDAWidJhVxFUpAPvixPZmfz; // 0x28
		private bool fgNnLmrmmahxmiDfYojqjhBnGlga; // 0x30
		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x38
	
		// Properties
		private Joystick joystick { get; } // 0x00000001808E0250-0x00000001808E0290 
		public int vibrationMotorCount { get; } // 0x00000001808E0730-0x00000001808E07E0 
		public float lightColorRed { get; set; } // 0x00000001808E04B0-0x00000001808E0590 0x00000001808E0A90-0x00000001808E0BA0
		public float lightColorGreen { get; set; } // 0x00000001808E03B0-0x00000001808E04B0 0x00000001808E0970-0x00000001808E0A90
		public float lightColorBlue { get; set; } // 0x00000001808E0290-0x00000001808E03B0 0x00000001808E0900-0x00000001808E0970
		public int maxTouches { get; } // 0x00000001808E0590-0x00000001808E0660 
		public int touchCount { get; } // 0x00000001808E0660-0x00000001808E0730 
		public float batteryLevel { get; } // 0x00000001808E0180-0x00000001808E0250 
	
		// Nested types
		private class CCARidKdkHWupJlanLcBYGeGRlz : IControllerExtensionSource // TypeDefIndex: 6076
		{
			// Fields
			public readonly IDriver_DualShock4 pLSlGvFkDOedcZzLNmTZIETLroL; // 0x10
			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR; // 0x18
			public readonly int zGdbUshTycKAtYCpVcJXKunoKXo; // 0x1C
	
			// Constructors
			public CCARidKdkHWupJlanLcBYGeGRlz(IDriver_DualShock4 driver, bool supportsVibration, int vibrationMotorCount); // 0x00000001808BDFE0-0x00000001808BE030
		}
	
		// Constructors
		internal DualShock4Extension(IDriver_DualShock4 driver); // 0x00000001808E0070-0x00000001808E0180
		private DualShock4Extension(DualShock4Extension source); // 0x00000001808DFED0-0x00000001808E0070
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x00000001808DF2C0-0x00000001808DF2E0
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x00000001808DF2E0-0x00000001808DF300
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x00000001808DF280-0x00000001808DF2A0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x00000001808DF340-0x00000001808DF540
		public float GetVibration(int motorIndex); // 0x00000001808DDD60-0x00000001808DDF20
		public void StopVibration(); // 0x00000001808DFB40-0x00000001808DFD20
		public float GetVibration(DualShock4MotorType motor); // 0x00000001808DDB80-0x00000001808DDD60
		public void SetVibration(DualShock4MotorType motor, float motorLevel); // 0x00000001808DF2A0-0x00000001808DF2C0
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration); // 0x00000001808DF260-0x00000001808DF280
		public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors); // 0x00000001808DF300-0x00000001808DF320
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x00000001808DF540-0x00000001808DF8C0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x00000001808DF320-0x00000001808DF340
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x00000001808DEFF0-0x00000001808DF260
		public Color GetLightColor(); // 0x00000001808DCD00-0x00000001808DCEC0
		public void SetLightColor(Color color); // 0x00000001808DEA40-0x00000001808DED70
		public void SetLightColor(float red, float green, float blue); // 0x00000001808DE920-0x00000001808DEA40
		public void SetLightColor(float red, float green, float blue, float intensity); // 0x00000001808DE620-0x00000001808DE920
		public void SetLightFlash(float onDuration, float offDuration); // 0x00000001808DED70-0x00000001808DEFF0
		public void StopLightFlash(); // 0x00000001808DF960-0x00000001808DFB40
		public Vector3 GetAccelerometerValueRaw(); // 0x00000001808DC2A0-0x00000001808DC400
		public Vector3 GetAccelerometerValue(); // 0x00000001808DC400-0x00000001808DC560
		public Vector3 GetLastGyroscopeValueRaw(); // 0x00000001808DC900-0x00000001808DCB00
		public Vector3 GetLastGyroscopeValue(); // 0x00000001808DCB00-0x00000001808DCD00
		public Vector3 GetGyroscopeValueRaw(); // 0x00000001808DC560-0x00000001808DC700
		public Vector3 GetGyroscopeValue(); // 0x00000001808DC700-0x00000001808DC900
		public Quaternion GetOrientation(); // 0x00000001808DCEC0-0x00000001808DD0B0
		public void ResetOrientation(); // 0x00000001808DE350-0x00000001808DE420
		public int GetTouchId(int index); // 0x00000001808DD0B0-0x00000001808DD290
		public bool GetTouchPosition(int index, out Vector2 position); // 0x00000001808DD9A0-0x00000001808DDB80
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x00000001808DD740-0x00000001808DD9A0
		public bool GetTouchPositionAbsolute(int index, out Vector2 position); // 0x00000001808DD4E0-0x00000001808DD740
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position); // 0x00000001808DD290-0x00000001808DD4E0
		public bool IsTouching(int index); // 0x00000001808DE050-0x00000001808DE190
		public bool IsTouchingByTouchId(int touchId); // 0x00000001808DDF20-0x00000001808DE050
		Vector3 IDualShock4Extension.GetGyroscopeValue(); // 0x00000001808DE5F0-0x00000001808DE620
		Vector3 IDualShock4Extension.GetGyroscopeValueRaw(); // 0x00000001808DE420-0x00000001808DE5F0
		internal override void UpdateData(UpdateLoopType param_0000cc8c); // 0x00000001808DFD20-0x00000001808DFED0
		internal override void SourceUpdated(IControllerExtensionSource param_0000cc8d); // 0x00000001808DF8C0-0x00000001808DF960
		internal override Controller.Extension Clone(); // 0x00000001808DC240-0x00000001808DC2A0
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x00000001808E07E0-0x00000001808E0900
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(DualShock4MotorType param_0000cc8e, float param_0000cc8f, float param_0000cc90); // 0x00000001808DE190-0x00000001808DE350
	}
}
