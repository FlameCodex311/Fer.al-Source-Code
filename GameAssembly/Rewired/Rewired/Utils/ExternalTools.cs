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

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Utils
{
	[EditorBrowsable] // 0x00000001800B6700-0x00000001800B6720
	public class ExternalTools : IExternalTools // TypeDefIndex: 9203
	{
		// Fields
		private static Func<object> _getPlatformInitializerDelegate; // 0x00
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<uint, bool> XboxOneInput_OnGamepadStateChange; // 0x20
	
		// Properties
		public static Func<object> getPlatformInitializerDelegate { get; set; } // 0x0000000181BBD4C0-0x0000000181BBD500 0x0000000181BBD620-0x0000000181BBD660
		public bool isEditorPaused { get; } // 0x0000000180375540-0x0000000180375550 
		public bool UnityInput_IsTouchPressureSupported { get; } // 0x0000000181BBD4B0-0x0000000181BBD4C0 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent {
			add; // 0x0000000181BBD390-0x0000000181BBD410
			remove; // 0x0000000181BBD500-0x0000000181BBD580
		}
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange {
			add; // 0x0000000181BBD410-0x0000000181BBD4B0
			remove; // 0x0000000181BBD580-0x0000000181BBD620
		}
	
		// Constructors
		public ExternalTools(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public void Destroy(); // 0x00000001803581E0-0x00000001803581F0
		public object GetPlatformInitializer(); // 0x0000000181BBCC70-0x0000000181BBCC80
		public string GetFocusedEditorWindowTitle(); // 0x0000000181BBCC30-0x0000000181BBCC70
		public bool IsEditorSceneViewFocused(); // 0x00000001803C28F0-0x00000001803C2900
		public bool LinuxInput_IsJoystickPreconfigured(string name); // 0x00000001803C28F0-0x00000001803C2900
		public int XboxOneInput_GetUserIdForGamepad(uint id); // 0x000000018035FCC0-0x000000018035FCD0
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId); // 0x000000018035FCC0-0x000000018035FCD0
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId); // 0x00000001803C28F0-0x00000001803C2900
		public string XboxOneInput_GetControllerType(ulong xboxControllerId); // 0x0000000181BBD350-0x0000000181BBD390
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId); // 0x000000018035FCC0-0x000000018035FCD0
		public void XboxOne_Gamepad_UpdatePlugin(); // 0x00000001803581E0-0x00000001803581F0
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel); // 0x00000001803C28F0-0x00000001803C2900
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS); // 0x00000001803581E0-0x00000001803581F0
		public Vector3 PS4Input_GetLastAcceleration(int id); // 0x0000000181BBCC80-0x0000000181BBCCF0
		public Vector3 PS4Input_GetLastGyro(int id); // 0x0000000181BBCCF0-0x0000000181BBCD60
		public Vector4 PS4Input_GetLastOrientation(int id); // 0x0000000181BBCE40-0x0000000181BBCEA0
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id); // 0x0000000181BBCEA0-0x0000000181BBCED0
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType); // 0x0000000181BBCED0-0x0000000181BBCF00
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadResetLightBar(int id); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_PadResetOrientation(int id); // 0x00000001803581E0-0x00000001803581F0
		public bool PS4Input_PadIsConnected(int id); // 0x00000001803C28F0-0x00000001803C2900
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser); // 0x00000001803581E0-0x00000001803581F0
		public int PS4Input_GetDeviceClassForHandle(int handle); // 0x00000001805F5E50-0x00000001805F5E60
		public string PS4Input_GetDeviceClassString(int intValue); // 0x000000018035FCC0-0x000000018035FCD0
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles); // 0x000000018035FCC0-0x000000018035FCD0
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index); // 0x0000000181BBCD60-0x0000000181BBCDD0
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index); // 0x0000000181BBCDD0-0x0000000181BBCE40
		public int PS4Input_MoveGetButtons(int id, int index); // 0x000000018035FCC0-0x000000018035FCD0
		public int PS4Input_MoveGetAnalogButton(int id, int index); // 0x000000018035FCC0-0x000000018035FCD0
		public bool PS4Input_MoveIsConnected(int id, int index); // 0x00000001803C28F0-0x00000001803C2900
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles); // 0x000000018035FCC0-0x000000018035FCD0
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles); // 0x000000018035FCC0-0x000000018035FCD0
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers); // 0x000000018035FCC0-0x000000018035FCD0
		public IntPtr PS4Input_MoveGetControllerInputForTracking(); // 0x0000000181BBCF00-0x0000000181BBCF30
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation); // 0x00000001803581E0-0x00000001803581F0
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id); // 0x0000000181BBCF30-0x0000000181BBCFA0
		public Vector3 PS4Input_SpecialGetLastGyro(int id); // 0x0000000181BBCFA0-0x0000000181BBD010
		public Vector4 PS4Input_SpecialGetLastOrientation(int id); // 0x0000000181BBD010-0x0000000181BBD070
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles); // 0x000000018035FCC0-0x000000018035FCD0
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles); // 0x000000018035FCC0-0x000000018035FCD0
		public bool PS4Input_SpecialIsConnected(int id); // 0x00000001803C28F0-0x00000001803C2900
		public void PS4Input_SpecialResetLightSphere(int id); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialResetOrientation(int id); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable); // 0x00000001803581E0-0x00000001803581F0
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor); // 0x00000001803581E0-0x00000001803581F0
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids); // 0x0000000181BBCBA0-0x0000000181BBCC30
		public int GetAndroidAPILevel(); // 0x00000001805F5E50-0x00000001805F5E60
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic); // 0x0000000181BBD090-0x0000000181BBD1F0
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value); // 0x0000000181BBD1F0-0x0000000181BBD350
		public float UnityInput_GetTouchPressure(ref Touch touch); // 0x0000000181BBD080-0x0000000181BBD090
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch); // 0x0000000181BBD070-0x0000000181BBD080
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload); // 0x0000000181BBC9F0-0x0000000181BBCA60
		public Type[] GetControllerTemplateTypes(); // 0x0000000181BBCB00-0x0000000181BBCBA0
		public Type[] GetControllerTemplateInterfaceTypes(); // 0x0000000181BBCA60-0x0000000181BBCB00
	}
}
