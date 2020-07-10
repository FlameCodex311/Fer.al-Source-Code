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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ControllerExtensions
{
	public sealed class DualShock4Extension : Controller.Extension, IDualShock4Extension // TypeDefIndex: 5916
	{
		// Fields
		private CCARidKdkHWupJlanLcBYGeGRlz JEVAvDAWidJhVxFUpAPvixPZmfz; // 0x28
		private bool fgNnLmrmmahxmiDfYojqjhBnGlga; // 0x30
		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x38
	
		// Properties
		private Joystick joystick { get; } // 0x0000000180459760-0x00000001804597A0 
		public int vibrationMotorCount { get; } // 0x0000000180459C50-0x0000000180459D10 
		public float lightColorRed { get; set; } // 0x00000001804599D0-0x0000000180459AB0 0x0000000180459FE0-0x000000018045A0F0
		public float lightColorGreen { get; set; } // 0x00000001804598C0-0x00000001804599D0 0x0000000180459EC0-0x0000000180459FE0
		public float lightColorBlue { get; set; } // 0x00000001804597A0-0x00000001804598C0 0x0000000180459E40-0x0000000180459EC0
		public int maxTouches { get; } // 0x0000000180459AB0-0x0000000180459B80 
		public int touchCount { get; } // 0x0000000180459B80-0x0000000180459C50 
		public float batteryLevel { get; } // 0x0000000180459690-0x0000000180459760 
	
		// Nested types
		private class CCARidKdkHWupJlanLcBYGeGRlz : IControllerExtensionSource // TypeDefIndex: 5917
		{
			// Fields
			public readonly IDriver_DualShock4 pLSlGvFkDOedcZzLNmTZIETLroL; // 0x10
			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR; // 0x18
			public readonly int zGdbUshTycKAtYCpVcJXKunoKXo; // 0x1C
	
			// Constructors
			public CCARidKdkHWupJlanLcBYGeGRlz(IDriver_DualShock4 driver, bool supportsVibration, int vibrationMotorCount); // 0x0000000180436D80-0x0000000180436DD0
		}
	
		// Constructors
		internal DualShock4Extension(IDriver_DualShock4 driver); // 0x0000000180459580-0x0000000180459690
		private DualShock4Extension(DualShock4Extension source); // 0x00000001804593D0-0x0000000180459580
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180458780-0x00000001804587A0
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x00000001804587A0-0x00000001804587C0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180458740-0x0000000180458760
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180458800-0x0000000180458A00
		public float GetVibration(int motorIndex); // 0x0000000180457360-0x0000000180457530
		public void StopVibration(); // 0x0000000180459020-0x0000000180459210
		public float GetVibration(DualShock4MotorType motor); // 0x0000000180457180-0x0000000180457360
		public void SetVibration(DualShock4MotorType motor, float motorLevel); // 0x0000000180458760-0x0000000180458780
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration); // 0x0000000180458720-0x0000000180458740
		public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors); // 0x00000001804587C0-0x00000001804587E0
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180458A00-0x0000000180458D90
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x00000001804587E0-0x0000000180458800
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x00000001804584A0-0x0000000180458720
		public Color GetLightColor(); // 0x00000001804562F0-0x00000001804564C0
		public void SetLightColor(Color color); // 0x0000000180457EE0-0x0000000180458210
		public void SetLightColor(float red, float green, float blue); // 0x0000000180457DC0-0x0000000180457EE0
		public void SetLightColor(float red, float green, float blue, float intensity); // 0x0000000180457AB0-0x0000000180457DC0
		public void SetLightFlash(float onDuration, float offDuration); // 0x0000000180458210-0x00000001804584A0
		public void StopLightFlash(); // 0x0000000180458E30-0x0000000180459020
		public Vector3 GetAccelerometerValueRaw(); // 0x0000000180455880-0x00000001804559E0
		public Vector3 GetAccelerometerValue(); // 0x00000001804559E0-0x0000000180455B40
		public Vector3 GetLastGyroscopeValueRaw(); // 0x0000000180455EF0-0x00000001804560F0
		public Vector3 GetLastGyroscopeValue(); // 0x00000001804560F0-0x00000001804562F0
		public Vector3 GetGyroscopeValueRaw(); // 0x0000000180455B40-0x0000000180455CF0
		public Vector3 GetGyroscopeValue(); // 0x0000000180455CF0-0x0000000180455EF0
		public Quaternion GetOrientation(); // 0x00000001804564C0-0x00000001804566B0
		public void ResetOrientation(); // 0x0000000180457980-0x0000000180457A50
		public int GetTouchId(int index); // 0x00000001804566B0-0x0000000180456890
		public bool GetTouchPosition(int index, out Vector2 position); // 0x0000000180456FA0-0x0000000180457180
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x0000000180456D40-0x0000000180456FA0
		public bool GetTouchPositionAbsolute(int index, out Vector2 position); // 0x0000000180456AE0-0x0000000180456D40
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position); // 0x0000000180456890-0x0000000180456AE0
		public bool IsTouching(int index); // 0x0000000180457660-0x00000001804577B0
		public bool IsTouchingByTouchId(int touchId); // 0x0000000180457530-0x0000000180457660
		Vector3 IDualShock4Extension.GetGyroscopeValue(); // 0x0000000180457A80-0x0000000180457AB0
		Vector3 IDualShock4Extension.GetGyroscopeValueRaw(); // 0x0000000180457A50-0x0000000180457A80
		internal override void UpdateData(UpdateLoopType param_0000ca1c); // 0x0000000180459210-0x00000001804593D0
		internal override void SourceUpdated(IControllerExtensionSource param_0000ca1d); // 0x0000000180458D90-0x0000000180458E30
		internal override Controller.Extension Clone(); // 0x0000000180455820-0x0000000180455880
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x0000000180459D10-0x0000000180459E40
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(DualShock4MotorType param_0000ca1e, float param_0000ca1f, float param_0000ca20); // 0x00000001804577B0-0x0000000180457980
	}
}
