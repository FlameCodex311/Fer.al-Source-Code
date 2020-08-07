/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Utils
{
	[EditorBrowsable] // 0x00000001801E4110-0x00000001801E4130
	public class ExternalTools : IExternalTools // TypeDefIndex: 9369
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get; set; } // 0x00000001820C5A30-0x00000001820C5A70 0x00000001820C5B90-0x00000001820C5BD0
		public bool isEditorPaused { get; } // 0x00000001803FD450-0x00000001803FD460 
		public bool UnityInput_IsTouchPressureSupported { get; } // 0x00000001820C5A20-0x00000001820C5A30 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent {
			add; // 0x00000001820C5900-0x00000001820C5980
			remove; // 0x00000001820C5A70-0x00000001820C5AF0
		}
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange {
			add; // 0x00000001820C5980-0x00000001820C5A20
			remove; // 0x00000001820C5AF0-0x00000001820C5B90
		}
	
		// Constructors
		public ExternalTools(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public void Destroy(); // 0x00000001803774A0-0x00000001803774B0
		public object GetPlatformInitializer(); // 0x00000001820C5200-0x00000001820C5210
		public string GetFocusedEditorWindowTitle(); // 0x00000001820C51C0-0x00000001820C5200
		public bool IsEditorSceneViewFocused(); // 0x0000000180380950-0x0000000180380960
		public bool LinuxInput_IsJoystickPreconfigured(string name); // 0x0000000180380950-0x0000000180380960
		public int XboxOneInput_GetUserIdForGamepad(uint id); // 0x000000018037DDC0-0x000000018037DDD0
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId); // 0x000000018037DDC0-0x000000018037DDD0
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId); // 0x0000000180380950-0x0000000180380960
		public string XboxOneInput_GetControllerType(ulong xboxControllerId); // 0x00000001820C58C0-0x00000001820C5900
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId); // 0x000000018037DDC0-0x000000018037DDD0
		public void XboxOne_Gamepad_UpdatePlugin(); // 0x00000001803774A0-0x00000001803774B0
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel); // 0x0000000180380950-0x0000000180380960
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS); // 0x00000001803774A0-0x00000001803774B0
		public Vector3 PS4Input_GetLastAcceleration(int id); // 0x00000001820C5210-0x00000001820C5280
		public Vector3 PS4Input_GetLastGyro(int id); // 0x00000001820C5280-0x00000001820C52F0
		public Vector4 PS4Input_GetLastOrientation(int id); // 0x00000001820C53D0-0x00000001820C5430
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id); // 0x00000001820C5430-0x00000001820C5460
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType); // 0x00000001820C5460-0x00000001820C5490
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadResetLightBar(int id); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_PadResetOrientation(int id); // 0x00000001803774A0-0x00000001803774B0
		public bool PS4Input_PadIsConnected(int id); // 0x0000000180380950-0x0000000180380960
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser); // 0x00000001803774A0-0x00000001803774B0
		public int PS4Input_GetDeviceClassForHandle(int handle); // 0x00000001807C4280-0x00000001807C4290
		public string PS4Input_GetDeviceClassString(int intValue); // 0x000000018037DDC0-0x000000018037DDD0
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles); // 0x000000018037DDC0-0x000000018037DDD0
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index); // 0x00000001820C52F0-0x00000001820C5360
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index); // 0x00000001820C5360-0x00000001820C53D0
		public int PS4Input_MoveGetButtons(int id, int index); // 0x000000018037DDC0-0x000000018037DDD0
		public int PS4Input_MoveGetAnalogButton(int id, int index); // 0x000000018037DDC0-0x000000018037DDD0
		public bool PS4Input_MoveIsConnected(int id, int index); // 0x0000000180380950-0x0000000180380960
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles); // 0x000000018037DDC0-0x000000018037DDD0
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles); // 0x000000018037DDC0-0x000000018037DDD0
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers); // 0x000000018037DDC0-0x000000018037DDD0
		public IntPtr PS4Input_MoveGetControllerInputForTracking(); // 0x00000001820C5490-0x00000001820C54C0
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation); // 0x00000001803774A0-0x00000001803774B0
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id); // 0x00000001820C54C0-0x00000001820C5530
		public Vector3 PS4Input_SpecialGetLastGyro(int id); // 0x00000001820C5530-0x00000001820C55A0
		public Vector4 PS4Input_SpecialGetLastOrientation(int id); // 0x00000001820C55A0-0x00000001820C5600
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles); // 0x000000018037DDC0-0x000000018037DDD0
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles); // 0x000000018037DDC0-0x000000018037DDD0
		public bool PS4Input_SpecialIsConnected(int id); // 0x0000000180380950-0x0000000180380960
		public void PS4Input_SpecialResetLightSphere(int id); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialResetOrientation(int id); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable); // 0x00000001803774A0-0x00000001803774B0
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor); // 0x00000001803774A0-0x00000001803774B0
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids); // 0x00000001820C5130-0x00000001820C51C0
		public int GetAndroidAPILevel(); // 0x00000001807C4280-0x00000001807C4290
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic); // 0x00000001820C5620-0x00000001820C5770
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value); // 0x00000001820C5770-0x00000001820C58C0
		public float UnityInput_GetTouchPressure(ref Touch touch); // 0x00000001820C5610-0x00000001820C5620
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch); // 0x00000001820C5600-0x00000001820C5610
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload); // 0x00000001820C4F80-0x00000001820C4FF0
		public Type[] GetControllerTemplateTypes(); // 0x00000001820C5090-0x00000001820C5130
		public Type[] GetControllerTemplateInterfaceTypes(); // 0x00000001820C4FF0-0x00000001820C5090
	}
}
