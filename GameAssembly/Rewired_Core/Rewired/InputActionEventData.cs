/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	public struct InputActionEventData // TypeDefIndex: 5726
	{
		// Fields
		private zIBZUXVBIXDNaGmrbGkXcVJJDbVo OjFvNRLLeJOYsVMpbpASyJOpHAj; // 0x00
		private InputActionEventType SuZfpjmuXAepVKHPGcgfhdcfzsD; // 0x08
		public readonly int playerId; // 0x0C
		public readonly int actionId; // 0x10
		public readonly UpdateLoopType updateLoop; // 0x14
	
		// Properties
		public InputActionEventType eventType { get; internal set; } // 0x0000000180004AB0-0x0000000180004AC0 0x0000000180004C50-0x0000000180004C60
		public Player player { get; } // 0x000000018000B9D0-0x000000018000BAD0 
		public string actionName { get; } // 0x000000018000B8C0-0x000000018000B9D0 
		public string actionDescriptiveName { get; } // 0x000000018000B7B0-0x000000018000B8C0 
	
		// Constructors
		internal InputActionEventData(zIBZUXVBIXDNaGmrbGkXcVJJDbVo vc, int playerId, int actionId, UpdateLoopType updateLoop); // 0x000000018000B790-0x000000018000B7B0
	
		// Methods
		public float GetAxis(); // 0x000000018000ADB0-0x000000018000ADD0
		public float GetAxisPrev(); // 0x000000018000AC70-0x000000018000AC90
		public float GetAxisDelta(); // 0x000000018000AC50-0x000000018000AC70
		public float GetAxisTimeActive(); // 0x000000018000AD70-0x000000018000AD90
		public float GetAxisTimeInactive(); // 0x000000018000AD90-0x000000018000ADB0
		public float GetAxisRaw(); // 0x000000018000AD50-0x000000018000AD70
		public float GetAxisRawDelta(); // 0x000000018000ACD0-0x000000018000ACF0
		public float GetAxisRawPrev(); // 0x000000018000ACF0-0x000000018000AD10
		public float GetAxisRawTimeActive(); // 0x000000018000AD10-0x000000018000AD30
		public float GetAxisRawTimeInactive(); // 0x000000018000AD30-0x000000018000AD50
		public AxisCoordinateMode GetAxisCoordinateMode(); // 0x000000018000AC30-0x000000018000AC50
		public AxisCoordinateMode GetAxisCoordinateModePrev(); // 0x000000018000AC10-0x000000018000AC30
		public AxisCoordinateMode GetAxisRawCoordinateMode(); // 0x000000018000ACB0-0x000000018000ACD0
		public AxisCoordinateMode GetAxisRawCoordinateModePrev(); // 0x000000018000AC90-0x000000018000ACB0
		public bool GetButton(); // 0x000000018000B130-0x000000018000B150
		public bool GetButtonPrev(); // 0x000000018000AF10-0x000000018000AF30
		public bool GetButtonDown(); // 0x000000018000AE90-0x000000018000AEB0
		public bool GetButtonUp(); // 0x000000018000B110-0x000000018000B130
		public bool GetButtonSinglePressHold(); // 0x000000018000AFD0-0x000000018000AFF0
		public bool GetButtonSinglePressDown(); // 0x000000018000AFB0-0x000000018000AFD0
		public bool GetButtonSinglePressUp(); // 0x000000018000AFF0-0x000000018000B010
		public bool GetButtonDoublePressDown(); // 0x000000018000ADD0-0x000000018000ADF0
		public bool GetButtonDoublePressDown(float speed); // 0x000000018000ADF0-0x000000018000AE10
		public bool GetButtonDoublePressHold(); // 0x000000018000AE30-0x000000018000AE50
		public bool GetButtonDoublePressHold(float speed); // 0x000000018000AE10-0x000000018000AE30
		public bool GetButtonDoublePressUp(); // 0x000000018000AE70-0x000000018000AE90
		public bool GetButtonDoublePressUp(float speed); // 0x000000018000AE50-0x000000018000AE70
		public bool GetButtonTimedPress(float time); // 0x000000018000B0C0-0x000000018000B0F0
		public bool GetButtonTimedPress(float time, float expireIn); // 0x000000018000B0F0-0x000000018000B110
		public bool GetButtonTimedPressDown(float time); // 0x000000018000B050-0x000000018000B070
		public bool GetButtonTimedPressUp(float time); // 0x000000018000B070-0x000000018000B0A0
		public bool GetButtonTimedPressUp(float time, float expireIn); // 0x000000018000B0A0-0x000000018000B0C0
		public bool GetButtonShortPress(); // 0x000000018000AF90-0x000000018000AFB0
		public bool GetButtonShortPressDown(); // 0x000000018000AF50-0x000000018000AF70
		public bool GetButtonShortPressUp(); // 0x000000018000AF70-0x000000018000AF90
		public bool GetButtonLongPress(); // 0x000000018000AEF0-0x000000018000AF10
		public bool GetButtonLongPressDown(); // 0x000000018000AEB0-0x000000018000AED0
		public bool GetButtonLongPressUp(); // 0x000000018000AED0-0x000000018000AEF0
		public bool GetButtonRepeating(); // 0x000000018000AF30-0x000000018000AF50
		public float GetButtonTimePressed(); // 0x000000018000B010-0x000000018000B030
		public float GetButtonTimeUnpressed(); // 0x000000018000B030-0x000000018000B050
		public bool GetNegativeButton(); // 0x000000018000B550-0x000000018000B570
		public bool GetNegativeButtonPrev(); // 0x000000018000B330-0x000000018000B350
		public bool GetNegativeButtonDown(); // 0x000000018000B2B0-0x000000018000B2D0
		public bool GetNegativeButtonUp(); // 0x000000018000B530-0x000000018000B550
		public bool GetNegativeButtonSinglePressHold(); // 0x000000018000B3F0-0x000000018000B410
		public bool GetNegativeButtonSinglePressDown(); // 0x000000018000B3D0-0x000000018000B3F0
		public bool GetNegativeButtonSinglePressUp(); // 0x000000018000B410-0x000000018000B430
		public bool GetNegativeButtonDoublePressDown(); // 0x000000018000B1F0-0x000000018000B210
		public bool GetNegativeButtonDoublePressDown(float speed); // 0x000000018000B210-0x000000018000B230
		public bool GetNegativeButtonDoublePressHold(); // 0x000000018000B250-0x000000018000B270
		public bool GetNegativeButtonDoublePressHold(float speed); // 0x000000018000B230-0x000000018000B250
		public bool GetNegativeButtonDoublePressUp(); // 0x000000018000B290-0x000000018000B2B0
		public bool GetNegativeButtonDoublePressUp(float speed); // 0x000000018000B270-0x000000018000B290
		public bool GetNegativeButtonTimedPress(float time); // 0x000000018000B4E0-0x000000018000B510
		public bool GetNegativeButtonTimedPress(float time, float expireIn); // 0x000000018000B510-0x000000018000B530
		public bool GetNegativeButtonTimedPressDown(float time); // 0x000000018000B470-0x000000018000B490
		public bool GetNegativeButtonTimedPressUp(float time); // 0x000000018000B490-0x000000018000B4C0
		public bool GetNegativeButtonTimedPressUp(float time, float expireIn); // 0x000000018000B4C0-0x000000018000B4E0
		public bool GetNegativeButtonShortPress(); // 0x000000018000B3B0-0x000000018000B3D0
		public bool GetNegativeButtonShortPressDown(); // 0x000000018000B370-0x000000018000B390
		public bool GetNegativeButtonShortPressUp(); // 0x000000018000B390-0x000000018000B3B0
		public bool GetNegativeButtonLongPress(); // 0x000000018000B310-0x000000018000B330
		public bool GetNegativeButtonLongPressDown(); // 0x000000018000B2D0-0x000000018000B2F0
		public bool GetNegativeButtonLongPressUp(); // 0x000000018000B2F0-0x000000018000B310
		public bool GetNegativeButtonRepeating(); // 0x000000018000B350-0x000000018000B370
		public float GetNegativeButtonTimePressed(); // 0x000000018000B430-0x000000018000B450
		public float GetNegativeButtonTimeUnpressed(); // 0x000000018000B450-0x000000018000B470
		public IList<InputActionSourceData> GetCurrentInputSources(); // 0x000000018000B150-0x000000018000B1F0
		public bool IsCurrentInputSource(ControllerType controllerType); // 0x000000018000B620-0x000000018000B6D0
		public bool IsCurrentInputSource(ControllerType controllerType, int controllerId); // 0x000000018000B6D0-0x000000018000B790
		public bool IsCurrentInputSource(Controller controller); // 0x000000018000B570-0x000000018000B620
	}
}
