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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.XboxOne
{
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 6940
	{
		// Fields
		private EqnErQJtoXnBimhhcZEPviHzgJU EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x28
		private TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x30
	
		// Properties
		private Joystick joystick { get; } // 0x000000018063F650-0x000000018063F690 
		public int xboxOneUserId { get; } // 0x000000018063F990-0x000000018063FB00 
		public ulong xboxOneJoystickId { get; } // 0x000000018063F720-0x000000018063F990 
		public int vibrationMotorCount { get; } // 0x000000018063F690-0x000000018063F720 
	
		// Nested types
		private class EqnErQJtoXnBimhhcZEPviHzgJU : IControllerExtensionSource // TypeDefIndex: 6941
		{
			// Fields
			public const int zGdbUshTycKAtYCpVcJXKunoKXo = 4; // Metadata: 0x00731D04
			public xcWyiIfNoFqFVFpAfvXHnUTXXPi NZEeeCgWyRqoyvxRZxYoteYRyHmo; // 0x10
			public readonly IXboxOneInputSource fdFATyDPtIlZRSsXTKMYVilUDtz; // 0x28
			public readonly bool kSrtaAGsebkQowBSfdkRuELNUCR; // 0x30
	
			// Constructors
			public EqnErQJtoXnBimhhcZEPviHzgJU(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibrationData); // 0x000000018083F910-0x000000018083F970
		}
	
		// Constructors
		internal XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource); // 0x000000018063F4B0-0x000000018063F5D0
		private XboxOneGamepadExtension(XboxOneGamepadExtension source); // 0x000000018063F5D0-0x000000018063F650
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x000000018063E550-0x000000018063E570
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x000000018063E760-0x000000018063E780
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x000000018063EDD0-0x000000018063EDF0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x000000018063E570-0x000000018063E760
		public float GetVibration(int motorIndex); // 0x000000018063DFD0-0x000000018063E130
		public float GetVibration(XboxOneGamepadMotorType motor); // 0x000000018063DE20-0x000000018063DFD0
		public void StopVibration(); // 0x000000018063F1D0-0x000000018063F360
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel); // 0x000000018063EA70-0x000000018063EA90
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration); // 0x000000018063EAB0-0x000000018063EAD0
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors); // 0x000000018063EA50-0x000000018063EA70
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors); // 0x000000018063EDF0-0x000000018063F150
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x000000018063EA90-0x000000018063EAB0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors); // 0x000000018063EAD0-0x000000018063EDD0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel); // 0x000000018063E780-0x000000018063EA50
		public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration); // 0x000000018063E370-0x000000018063E550
		internal override void UpdateData(UpdateLoopType param_0000f452); // 0x000000018063F360-0x000000018063F4B0
		internal override void SourceUpdated(IControllerExtensionSource param_0000f453); // 0x000000018063F150-0x000000018063F1D0
		internal override Controller.Extension Clone(); // 0x000000018063DC30-0x000000018063DCE0
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x000000018063F360-0x000000018063F4B0
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(XboxOneGamepadMotorType param_0000f454, float param_0000f455, float param_0000f456); // 0x000000018063E130-0x000000018063E370
		private void FcTHFOwfYFXyJYzmCrbOHLnKiFX(); // 0x000000018063DCE0-0x000000018063DE20
	}
}
