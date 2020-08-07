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
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Platforms.PS4
{
	public class PS4ControllerExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 6821
	{
		// Fields
		private readonly TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x28
	
		// Properties
		private IPS4ControllerExtensionSource Source { get; } // 0x0000000180EAEDF0-0x0000000180EAEEA0 
		internal Joystick joystick { get; } // 0x0000000180EAEEA0-0x0000000180EAEEE0 
		public int userStatusCode { get; } // 0x0000000180EAF360-0x0000000180EAF430 
		public bool userIsPrimary { get; } // 0x0000000180EAF1D0-0x0000000180EAF290 
		public int userId { get; } // 0x0000000180EAF110-0x0000000180EAF1D0 
		public Color userColor { get; } // 0x0000000180EAEFB0-0x0000000180EAF110 
		public int userColorId { get; } // 0x0000000180EAEEE0-0x0000000180EAEFB0 
		public string userName { get; } // 0x0000000180EAF290-0x0000000180EAF360 
		public int vibrationMotorCount { get; } // 0x0000000180EAF430-0x0000000180EAF4F0 
	
		// Nested types
		internal class OYaRfyZvtooqbDymOVKnJBtChvU : IControllerExtensionSource // TypeDefIndex: 6822
		{
			// Fields
			public readonly IPS4ControllerExtensionSource EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x10
	
			// Constructors
			public OYaRfyZvtooqbDymOVKnJBtChvU(IPS4ControllerExtensionSource source); // 0x0000000180EACC10-0x0000000180EACC90
		}
	
		// Constructors
		internal PS4ControllerExtension(IPS4ControllerExtensionSource source); // 0x0000000180EAECE0-0x0000000180EAEDF0
		protected PS4ControllerExtension(PS4ControllerExtension source); // 0x0000000180EAEB70-0x0000000180EAECE0
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180EAE6B0-0x0000000180EAE780
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x0000000180EAE1D0-0x0000000180EAE1F0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180EAE690-0x0000000180EAE6B0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180EAE1F0-0x0000000180EAE690
		public float GetVibration(int motorIndex); // 0x0000000180EAD590-0x0000000180EAD6A0
		public void StopVibration(); // 0x0000000180EAE780-0x0000000180EAEA20
		public Vector3 GetAccelerometerValueRaw(); // 0x0000000180EACCF0-0x0000000180EACE60
		public Vector3 GetAccelerometerValue(); // 0x0000000180EACE60-0x0000000180EACFD0
		public Vector3 GetLastGyroscopeValueRaw(); // 0x0000000180EACFD0-0x0000000180EAD140
		public Vector3 GetLastGyroscopeValue(); // 0x0000000180EAD140-0x0000000180EAD2B0
		public Quaternion GetOrientationRaw(); // 0x0000000180EAD2B0-0x0000000180EAD420
		public Quaternion GetOrientation(); // 0x0000000180EAD420-0x0000000180EAD590
		public void ResetOrientation(); // 0x0000000180EAD900-0x0000000180EAD9C0
		public void SetMotionSensorState(bool enabled); // 0x0000000180EADFA0-0x0000000180EAE070
		public void SetTiltCorrectionState(bool enabled); // 0x0000000180EAE070-0x0000000180EAE1D0
		public void SetAngularVelocityDeadbandState(bool enabled); // 0x0000000180EAD9C0-0x0000000180EADAA0
		public void SetLightColor(Color color); // 0x0000000180EADAA0-0x0000000180EADBD0
		public void SetLightColor(float red, float green, float blue); // 0x0000000180EADEB0-0x0000000180EADFA0
		public void SetLightColor(float red, float green, float blue, float intensity); // 0x0000000180EADBD0-0x0000000180EADEB0
		public void ResetLight(); // 0x0000000180EAD840-0x0000000180EAD900
		internal override void UpdateData(UpdateLoopType param_0000e6f9); // 0x0000000180EAEA20-0x0000000180EAEB70
		internal override void SourceUpdated(IControllerExtensionSource param_0000e6fa); // 0x00000001803774A0-0x00000001803774B0
		internal override Controller.Extension Clone(); // 0x0000000180EACC90-0x0000000180EACCF0
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x0000000180EAEA20-0x0000000180EAEB70
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(int param_0000e6fb, float param_0000e6fc, float param_0000e6fd); // 0x0000000180EAD6A0-0x0000000180EAD840
	}
}
