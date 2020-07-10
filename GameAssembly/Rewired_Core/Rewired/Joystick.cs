/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public class Joystick : ControllerWithAxes // TypeDefIndex: 5926
	{
		// Fields
		private const int LEFT_MOTOR_INDEX = 0; // Metadata: 0x0072F6A8
		private const int RIGHT_MOTOR_INDEX = 1; // Metadata: 0x0072F6AC
		private IInputManagerJoystickPublic _sourceJoystick; // 0x148
		private readonly JoystickType[] _joystickTypes; // 0x150
		private readonly ReadOnlyCollection<JoystickType> _joystickTypes_readOnly; // 0x158
		private readonly bool _supportsVibration; // 0x160
		private readonly bool _supportsLocalVibration; // 0x161
		private readonly bool _supportsVoice; // 0x162
		private readonly int _localVibrationMotorCount; // 0x164
		private readonly float[] _localVibrationMotorValues; // 0x168
		private readonly TimerAbs[] _localVibrationStopTimers; // 0x170
		private readonly int _hatCount; // 0x178
		private readonly Hat[] _hats; // 0x180
		private readonly ReadOnlyCollection<Hat> hats_readOnly; // 0x188
	
		// Properties
		internal IList<JoystickType> joystickTypes { get; } // 0x000000018062B1F0-0x000000018062B2A0 
		public long? systemId { get; } // 0x000000018062B350-0x000000018062B4B0 
		public int unityId { get; } // 0x000000018062B4B0-0x000000018062B580 
		public override Guid deviceInstanceGuid { get; } // 0x000000018062AF00-0x000000018062B070 
		public bool supportsVibration { get; } // 0x000000018062B2A0-0x000000018062B350 
		public float vibrationLeftMotor { get; set; } // 0x000000018062B580-0x000000018062B7D0 0x000000018062BA50-0x000000018062BC10
		public float vibrationRightMotor { get; set; } // 0x000000018062B8F0-0x000000018062BA40 0x000000018062BC10-0x000000018062BD90
		public int vibrationMotorCount { get; } // 0x000000018062B7D0-0x000000018062B8F0 
		public int hatCount { get; } // 0x000000018062B0D0-0x000000018062B1A0 
		public IList<Hat> Hats { get; } // 0x000000018062AE10-0x000000018062AEC0 
		internal int inputManagerId { get; } // 0x000000018062B1A0-0x000000018062B1F0 
		internal HardwareControllerMapIdentifier hardwareJoystickMapIdentifier { get; } // 0x000000018062B070-0x000000018062B0D0 
	
		// Constructors
		internal Joystick(BridgedController controller); // 0x0000000180629E10-0x000000018062A5D0
		private Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x000000018062A810-0x000000018062AE10
	
		// Methods
		internal bool IsType(JoystickType joystickType); // 0x00000001806282A0-0x00000001806283E0
		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData(); // 0x0000000180627FF0-0x0000000180628120
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x0000000180628C30-0x0000000180628D00
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x00000001806286F0-0x00000001806289E0
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180628D20-0x0000000180628D40
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x00000001806289E0-0x0000000180628A00
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180628D00-0x0000000180628D20
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180628A00-0x0000000180628C30
		public float GetVibration(int motorIndex); // 0x0000000180628120-0x00000001806282A0
		public void StopVibration(); // 0x0000000180628D40-0x0000000180629060
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x0000000180629A10-0x0000000180629C40
		internal void UpdateControllerInfo(UpdateControllerInfoEventArgs args); // 0x00000001806296D0-0x0000000180629A10
		internal void UpdateControllerInfo(BridgedController controller); // 0x0000000180629390-0x00000001806296D0
		private void UpdateControllerInfo(IInputManagerJoystickPublic joystick); // 0x0000000180629060-0x0000000180629390
		internal override void Clear(); // 0x0000000180627B60-0x0000000180627B80
		protected override void Disconnected(); // 0x0000000180627D00-0x0000000180627F10
		private void CheckVibrationTimeout(); // 0x0000000180627A20-0x0000000180627B60
		private void SetLocalVibration(int motorIndex, float motorLevel, float motorDuration, bool stopOtherMotors, bool updateNow); // 0x00000001806283E0-0x00000001806286F0
		private void UpdateLocalControllerVibration(); // 0x0000000180629C40-0x0000000180629E10
		private void StopAllVibration(); // 0x00000001803581E0-0x00000001803581F0
		internal static int CompareById_Ascending(Joystick a, Joystick b); // 0x0000000180627B80-0x0000000180627D00
	}
}
