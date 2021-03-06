﻿/*
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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public class Joystick : ControllerWithAxes // TypeDefIndex: 6085
	{
		// Fields
		private const int LEFT_MOTOR_INDEX = 0; // Metadata: 0x00764345
		private const int RIGHT_MOTOR_INDEX = 1; // Metadata: 0x00764349
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
		internal IList<JoystickType> joystickTypes { get; } // 0x0000000180EA2CD0-0x0000000180EA2D80 
		public long? systemId { get; } // 0x0000000180EA2E30-0x0000000180EA2F90 
		public int unityId { get; } // 0x0000000180EA2F90-0x0000000180EA3050 
		public override Guid deviceInstanceGuid { get; } // 0x0000000180EA29E0-0x0000000180EA2B50 
		public bool supportsVibration { get; } // 0x0000000180EA2D80-0x0000000180EA2E30 
		public float vibrationLeftMotor { get; set; } // 0x0000000180EA3050-0x0000000180EA32A0 0x0000000180EA3500-0x0000000180EA36B0
		public float vibrationRightMotor { get; set; } // 0x0000000180EA33B0-0x0000000180EA3500 0x0000000180EA36B0-0x0000000180EA3830
		public int vibrationMotorCount { get; } // 0x0000000180EA32A0-0x0000000180EA33B0 
		public int hatCount { get; } // 0x0000000180EA2BB0-0x0000000180EA2C80 
		public IList<Hat> Hats { get; } // 0x0000000180EA28F0-0x0000000180EA29A0 
		internal int inputManagerId { get; } // 0x0000000180EA2C80-0x0000000180EA2CD0 
		internal HardwareControllerMapIdentifier hardwareJoystickMapIdentifier { get; } // 0x0000000180EA2B50-0x0000000180EA2BB0 
	
		// Constructors
		internal Joystick(BridgedController controller); // 0x0000000180EA1940-0x0000000180EA20F0
		private Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater); // 0x0000000180EA2320-0x0000000180EA28F0
	
		// Methods
		internal bool IsType(JoystickType joystickType); // 0x0000000180E9FE40-0x0000000180E9FF70
		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData(); // 0x0000000180E9FB90-0x0000000180E9FCC0
		public void SetVibration(float leftMotorLevel, float rightMotorLevel); // 0x0000000180EA07B0-0x0000000180EA0880
		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration); // 0x0000000180EA0270-0x0000000180EA0560
		public void SetVibration(int motorIndex, float motorLevel); // 0x0000000180EA08A0-0x0000000180EA08C0
		public void SetVibration(int motorIndex, float motorLevel, float duration); // 0x0000000180EA0560-0x0000000180EA0580
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors); // 0x0000000180EA0880-0x0000000180EA08A0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors); // 0x0000000180EA0580-0x0000000180EA07B0
		public float GetVibration(int motorIndex); // 0x0000000180E9FCC0-0x0000000180E9FE40
		public void StopVibration(); // 0x0000000180EA08C0-0x0000000180EA0BE0
		internal override void UpdateData(UpdateLoopType updateLoop); // 0x0000000180EA1560-0x0000000180EA1780
		internal void UpdateControllerInfo(UpdateControllerInfoEventArgs args); // 0x0000000180EA1230-0x0000000180EA1560
		internal void UpdateControllerInfo(BridgedController controller); // 0x0000000180EA0F00-0x0000000180EA1230
		private void UpdateControllerInfo(IInputManagerJoystickPublic joystick); // 0x0000000180EA0BE0-0x0000000180EA0F00
		internal override void Clear(); // 0x0000000180E9F710-0x0000000180E9F730
		protected override void Disconnected(); // 0x0000000180E9F8B0-0x0000000180E9FAC0
		private void CheckVibrationTimeout(); // 0x0000000180E9F5D0-0x0000000180E9F710
		private void SetLocalVibration(int motorIndex, float motorLevel, float motorDuration, bool stopOtherMotors, bool updateNow); // 0x0000000180E9FF70-0x0000000180EA0270
		private void UpdateLocalControllerVibration(); // 0x0000000180EA1780-0x0000000180EA1940
		private void StopAllVibration(); // 0x00000001803774A0-0x00000001803774B0
		internal static int CompareById_Ascending(Joystick a, Joystick b); // 0x0000000180E9F730-0x0000000180E9F8B0
	}
}
