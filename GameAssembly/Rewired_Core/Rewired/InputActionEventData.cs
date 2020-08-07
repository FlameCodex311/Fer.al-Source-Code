/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	public struct InputActionEventData // TypeDefIndex: 5885
	{
		// Fields
		private zIBZUXVBIXDNaGmrbGkXcVJJDbVo OjFvNRLLeJOYsVMpbpASyJOpHAj; // 0x00
		private InputActionEventType SuZfpjmuXAepVKHPGcgfhdcfzsD; // 0x08
		public readonly int playerId; // 0x0C
		public readonly int actionId; // 0x10
		public readonly UpdateLoopType updateLoop; // 0x14
	
		// Properties
		public InputActionEventType eventType { get; internal set; } // 0x00000001800213D0-0x00000001800213E0 0x0000000180021560-0x0000000180021590
		public Player player { get; } // 0x00000001800A4140-0x00000001800A4240 
		public string actionName { get; } // 0x00000001800A4030-0x00000001800A4140 
		public string actionDescriptiveName { get; } // 0x00000001800A3F20-0x00000001800A4030 
	
		// Constructors
		internal InputActionEventData(zIBZUXVBIXDNaGmrbGkXcVJJDbVo vc, int playerId, int actionId, UpdateLoopType updateLoop); // 0x00000001800A3F00-0x00000001800A3F20
	
		// Methods
		public float GetAxis(); // 0x00000001800A3520-0x00000001800A3540
		public float GetAxisPrev(); // 0x00000001800A33E0-0x00000001800A3400
		public float GetAxisDelta(); // 0x00000001800A33C0-0x00000001800A33E0
		public float GetAxisTimeActive(); // 0x00000001800A34E0-0x00000001800A3500
		public float GetAxisTimeInactive(); // 0x00000001800A3500-0x00000001800A3520
		public float GetAxisRaw(); // 0x00000001800A34C0-0x00000001800A34E0
		public float GetAxisRawDelta(); // 0x00000001800A3440-0x00000001800A3460
		public float GetAxisRawPrev(); // 0x00000001800A3460-0x00000001800A3480
		public float GetAxisRawTimeActive(); // 0x00000001800A3480-0x00000001800A34A0
		public float GetAxisRawTimeInactive(); // 0x00000001800A34A0-0x00000001800A34C0
		public AxisCoordinateMode GetAxisCoordinateMode(); // 0x00000001800A33A0-0x00000001800A33C0
		public AxisCoordinateMode GetAxisCoordinateModePrev(); // 0x00000001800A3380-0x00000001800A33A0
		public AxisCoordinateMode GetAxisRawCoordinateMode(); // 0x00000001800A3420-0x00000001800A3440
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(); // 0x00000001800A3400-0x00000001800A3420
		public bool GetButton(); // 0x00000001800A38A0-0x00000001800A38C0
		public bool GetButtonPrev(); // 0x00000001800A3680-0x00000001800A36A0
		public bool GetButtonDown(); // 0x00000001800A3600-0x00000001800A3620
		public bool GetButtonUp(); // 0x00000001800A3880-0x00000001800A38A0
		public bool GetButtonSinglePressHold(); // 0x00000001800A3740-0x00000001800A3760
		public bool GetButtonSinglePressDown(); // 0x00000001800A3720-0x00000001800A3740
		public bool GetButtonSinglePressUp(); // 0x00000001800A3760-0x00000001800A3780
		public bool GetButtonDoublePressDown(); // 0x00000001800A3540-0x00000001800A3560
		public bool GetButtonDoublePressDown(float speed); // 0x00000001800A3560-0x00000001800A3580
		public bool GetButtonDoublePressHold(); // 0x00000001800A35A0-0x00000001800A35C0
		public bool GetButtonDoublePressHold(float speed); // 0x00000001800A3580-0x00000001800A35A0
		public bool GetButtonDoublePressUp(); // 0x00000001800A35E0-0x00000001800A3600
		public bool GetButtonDoublePressUp(float speed); // 0x00000001800A35C0-0x00000001800A35E0
		public bool GetButtonTimedPress(float time); // 0x00000001800A3830-0x00000001800A3860
		public bool GetButtonTimedPress(float time, float expireIn); // 0x00000001800A3860-0x00000001800A3880
		public bool GetButtonTimedPressDown(float time); // 0x00000001800A37C0-0x00000001800A37E0
		public bool GetButtonTimedPressUp(float time); // 0x00000001800A37E0-0x00000001800A3810
		public bool GetButtonTimedPressUp(float time, float expireIn); // 0x00000001800A3810-0x00000001800A3830
		public bool GetButtonShortPress(); // 0x00000001800A3700-0x00000001800A3720
		public bool GetButtonShortPressDown(); // 0x00000001800A36C0-0x00000001800A36E0
		public bool GetButtonShortPressUp(); // 0x00000001800A36E0-0x00000001800A3700
		public bool GetButtonLongPress(); // 0x00000001800A3660-0x00000001800A3680
		public bool GetButtonLongPressDown(); // 0x00000001800A3620-0x00000001800A3640
		public bool GetButtonLongPressUp(); // 0x00000001800A3640-0x00000001800A3660
		public bool GetButtonRepeating(); // 0x00000001800A36A0-0x00000001800A36C0
		public float GetButtonTimePressed(); // 0x00000001800A3780-0x00000001800A37A0
		public float GetButtonTimeUnpressed(); // 0x00000001800A37A0-0x00000001800A37C0
		public bool GetNegativeButton(); // 0x00000001800A3CC0-0x00000001800A3CE0
		public bool GetNegativeButtonPrev(); // 0x00000001800A3AA0-0x00000001800A3AC0
		public bool GetNegativeButtonDown(); // 0x00000001800A3A20-0x00000001800A3A40
		public bool GetNegativeButtonUp(); // 0x00000001800A3CA0-0x00000001800A3CC0
		public bool GetNegativeButtonSinglePressHold(); // 0x00000001800A3B60-0x00000001800A3B80
		public bool GetNegativeButtonSinglePressDown(); // 0x00000001800A3B40-0x00000001800A3B60
		public bool GetNegativeButtonSinglePressUp(); // 0x00000001800A3B80-0x00000001800A3BA0
		public bool GetNegativeButtonDoublePressDown(); // 0x00000001800A3960-0x00000001800A3980
		public bool GetNegativeButtonDoublePressDown(float speed); // 0x00000001800A3980-0x00000001800A39A0
		public bool GetNegativeButtonDoublePressHold(); // 0x00000001800A39C0-0x00000001800A39E0
		public bool GetNegativeButtonDoublePressHold(float speed); // 0x00000001800A39A0-0x00000001800A39C0
		public bool GetNegativeButtonDoublePressUp(); // 0x00000001800A3A00-0x00000001800A3A20
		public bool GetNegativeButtonDoublePressUp(float speed); // 0x00000001800A39E0-0x00000001800A3A00
		public bool GetNegativeButtonTimedPress(float time); // 0x00000001800A3C50-0x00000001800A3C80
		public bool GetNegativeButtonTimedPress(float time, float expireIn); // 0x00000001800A3C80-0x00000001800A3CA0
		public bool GetNegativeButtonTimedPressDown(float time); // 0x00000001800A3BE0-0x00000001800A3C00
		public bool GetNegativeButtonTimedPressUp(float time); // 0x00000001800A3C00-0x00000001800A3C30
		public bool GetNegativeButtonTimedPressUp(float time, float expireIn); // 0x00000001800A3C30-0x00000001800A3C50
		public bool GetNegativeButtonShortPress(); // 0x00000001800A3B20-0x00000001800A3B40
		public bool GetNegativeButtonShortPressDown(); // 0x00000001800A3AE0-0x00000001800A3B00
		public bool GetNegativeButtonShortPressUp(); // 0x00000001800A3B00-0x00000001800A3B20
		public bool GetNegativeButtonLongPress(); // 0x00000001800A3A80-0x00000001800A3AA0
		public bool GetNegativeButtonLongPressDown(); // 0x00000001800A3A40-0x00000001800A3A60
		public bool GetNegativeButtonLongPressUp(); // 0x00000001800A3A60-0x00000001800A3A80
		public bool GetNegativeButtonRepeating(); // 0x00000001800A3AC0-0x00000001800A3AE0
		public float GetNegativeButtonTimePressed(); // 0x00000001800A3BA0-0x00000001800A3BC0
		public float GetNegativeButtonTimeUnpressed(); // 0x00000001800A3BC0-0x00000001800A3BE0
		public IList<InputActionSourceData> GetCurrentInputSources(); // 0x00000001800A38C0-0x00000001800A3960
		public bool IsCurrentInputSource(ControllerType controllerType); // 0x00000001800A3D90-0x00000001800A3E40
		public bool IsCurrentInputSource(ControllerType controllerType, int controllerId); // 0x00000001800A3E40-0x00000001800A3F00
		public bool IsCurrentInputSource(Controller controller); // 0x00000001800A3CE0-0x00000001800A3D90
	}
}
