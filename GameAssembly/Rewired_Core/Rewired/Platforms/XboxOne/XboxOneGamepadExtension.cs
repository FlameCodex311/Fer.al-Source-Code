/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.XboxOne
{
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 7099
	{
		// Fields
		private EqnErQJtoXnBimhhcZEPviHzgJU EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x30
	
		// Properties
		private Joystick joystick { get; } // 0x0000000180EB6D50-0x0000000180EB6D90 
		public int xboxOneUserId { get; } // 0x0000000180EB7080-0x0000000180EB71F0 
		public ulong xboxOneJoystickId { get; } // 0x0000000180EB6E20-0x0000000180EB7080 
		public int vibrationMotorCount { get; } // 0x0000000180EB6D90-0x0000000180EB6E20 
	
		// Nested types
		private class EqnErQJtoXnBimhhcZEPviHzgJU : IControllerExtensionSource // TypeDefIndex: 7100
		{
			// Fields
			public const int zGdbUshTycKAtYCpVcJXKunoKXo = 4; // Metadata: 0x007669A1
			public xcWyiIfNoFqFVFpAfvXHnUTXXPi NZEeeCgWyRqoyvxRZxYoteYRyHmo; // 0x10
			public readonly IXboxOneInputSource fdFATyDPtIlZRSsXTKMYVilUDtz; // 0x28
			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR; // 0x30
	
			// Constructors
			public EqnErQJtoXnBimhhcZEPviHzgJU(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibrationData); // 0x00000001811797B0-0x0000000181179810
		}
	
		// Constructors
		internal XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource); // 0x0000000180EB6BC0-0x0000000180EB6CD0
		private XboxOneGamepadExtension(XboxOneGamepadExtension source); // 0x0000000180EB6CD0-0x0000000180EB6D50
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180EB5CB0-0x0000000180EB5CD0
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x0000000180EB5EC0-0x0000000180EB5EE0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180EB6510-0x0000000180EB6530
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180EB5CD0-0x0000000180EB5EC0
		public float GetVibration(int motorIndex); // 0x0000000180EB5740-0x0000000180EB58A0
		public float GetVibration(XboxOneGamepadMotorType motor); // 0x0000000180EB5590-0x0000000180EB5740
		public void StopVibration(); // 0x0000000180EB6900-0x0000000180EB6A80
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel); // 0x0000000180EB61C0-0x0000000180EB61E0
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration); // 0x0000000180EB6200-0x0000000180EB6220
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors); // 0x0000000180EB61A0-0x0000000180EB61C0
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180EB6530-0x0000000180EB6880
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x0000000180EB61E0-0x0000000180EB6200
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors); // 0x0000000180EB6220-0x0000000180EB6510
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel); // 0x0000000180EB5EE0-0x0000000180EB61A0
		public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration); // 0x0000000180EB5AD0-0x0000000180EB5CB0
		internal override void UpdateData(UpdateLoopType param_0000f6c2); // 0x0000000180EB6A80-0x0000000180EB6BC0
		internal override void SourceUpdated(IControllerExtensionSource param_0000f6c3); // 0x0000000180EB6880-0x0000000180EB6900
		internal override Controller.Extension Clone(); // 0x0000000180EB53A0-0x0000000180EB5450
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x0000000180EB6A80-0x0000000180EB6BC0
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(XboxOneGamepadMotorType param_0000f6c4, float param_0000f6c5, float param_0000f6c6); // 0x0000000180EB58A0-0x0000000180EB5AD0
		private void FcTHFOwfYFXyJYzmCrbOHLnKiFX(); // 0x0000000180EB5450-0x0000000180EB5590
	}
}
