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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Platforms.PS4
{
	public class PS4ControllerExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 6662
	{
		// Fields
		private readonly TimerAbs[] zwGFQivJGqQqYnlLUPZoSosDQVj; // 0x28
	
		// Properties
		private IPS4ControllerExtensionSource Source { get; } // 0x0000000180637580-0x0000000180637630 
		internal Joystick joystick { get; } // 0x0000000180637630-0x0000000180637670 
		public int userStatusCode { get; } // 0x0000000180637B10-0x0000000180637BE0 
		public bool userIsPrimary { get; } // 0x0000000180637970-0x0000000180637A40 
		public int userId { get; } // 0x00000001806378A0-0x0000000180637970 
		public Color userColor { get; } // 0x0000000180637740-0x00000001806378A0 
		public int userColorId { get; } // 0x0000000180637670-0x0000000180637740 
		public string userName { get; } // 0x0000000180637A40-0x0000000180637B10 
		public int vibrationMotorCount { get; } // 0x0000000180637BE0-0x0000000180637CB0 
	
		// Nested types
		internal class OYaRfyZvtooqbDymOVKnJBtChvU : IControllerExtensionSource // TypeDefIndex: 6663
		{
			// Fields
			public readonly IPS4ControllerExtensionSource EWvxEcokoAEStdCudJqOMgkHwwyD; // 0x10
	
			// Constructors
			public OYaRfyZvtooqbDymOVKnJBtChvU(IPS4ControllerExtensionSource source); // 0x0000000180635320-0x00000001806353A0
		}
	
		// Constructors
		internal PS4ControllerExtension(IPS4ControllerExtensionSource source); // 0x0000000180637470-0x0000000180637580
		protected PS4ControllerExtension(PS4ControllerExtension source); // 0x0000000180637300-0x0000000180637470
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180636E30-0x0000000180636F00
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x0000000180636940-0x0000000180636960
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180636E10-0x0000000180636E30
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180636960-0x0000000180636E10
		public float GetVibration(int motorIndex); // 0x0000000180635CE0-0x0000000180635DF0
		public void StopVibration(); // 0x0000000180636F00-0x00000001806371B0
		public Vector3 GetAccelerometerValueRaw(); // 0x0000000180635400-0x0000000180635580
		public Vector3 GetAccelerometerValue(); // 0x0000000180635580-0x0000000180635700
		public Vector3 GetLastGyroscopeValueRaw(); // 0x0000000180635700-0x0000000180635880
		public Vector3 GetLastGyroscopeValue(); // 0x0000000180635880-0x0000000180635A00
		public Quaternion GetOrientationRaw(); // 0x0000000180635A00-0x0000000180635B70
		public Quaternion GetOrientation(); // 0x0000000180635B70-0x0000000180635CE0
		public void ResetOrientation(); // 0x0000000180636060-0x0000000180636120
		public void SetMotionSensorState(bool enabled); // 0x0000000180636700-0x00000001806367E0
		public void SetTiltCorrectionState(bool enabled); // 0x00000001806367E0-0x0000000180636940
		public void SetAngularVelocityDeadbandState(bool enabled); // 0x0000000180636120-0x0000000180636200
		public void SetLightColor(Color color); // 0x0000000180636200-0x0000000180636330
		public void SetLightColor(float red, float green, float blue); // 0x0000000180636610-0x0000000180636700
		public void SetLightColor(float red, float green, float blue, float intensity); // 0x0000000180636330-0x0000000180636610
		public void ResetLight(); // 0x0000000180635FA0-0x0000000180636060
		internal override void UpdateData(UpdateLoopType param_0000e489); // 0x00000001806371B0-0x0000000180637300
		internal override void SourceUpdated(IControllerExtensionSource param_0000e48a); // 0x00000001803581E0-0x00000001803581F0
		internal override Controller.Extension Clone(); // 0x00000001806353A0-0x0000000180635400
		private void mWMaDNGJIyzNYllidjlJnePaxMDR(); // 0x00000001806371B0-0x0000000180637300
		private void NkodnkKMvxPXugZCqkaWDsqVwYA(int param_0000e48b, float param_0000e48c, float param_0000e48d); // 0x0000000180635DF0-0x0000000180635FA0
	}
}
