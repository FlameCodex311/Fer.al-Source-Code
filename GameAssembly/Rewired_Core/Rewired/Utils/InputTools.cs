/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801D6540-0x00000001801D6590
	[CustomObfuscation] // 0x00000001801D6540-0x00000001801D6590
	internal static class InputTools // TypeDefIndex: 7045
	{
		// Methods
		public static float TransformAxis2DComponentValue(float value, float zero, float min, float max); // 0x00000001813EA160-0x00000001813EA370
		public static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001813E97F0-0x00000001813E9BC0
		public static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001813E9BC0-0x00000001813E9D50
		public static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone); // 0x00000001813E9060-0x00000001813E91A0
		public static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001813E93F0-0x00000001813E95A0
		private static bool HvBsEUkSycrBgoJGlGgyyXbXymY(AnimationCurve param_0000f215); // 0x00000001813E9E70-0x00000001813E9F40
		public static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve); // 0x00000001813E91A0-0x00000001813E93F0
		public static string FormatHardwareIdentifierString(string str); // 0x00000001813E9760-0x00000001813E97F0
		public static AxisRange InvertAxisRange(AxisRange axisRange); // 0x00000001813E9F40-0x00000001813E9FC0
		public static void CompareLastActiveController(Controller controller, ref Controller lastController, ref float lastTime); // 0x00000001813E9670-0x00000001813E9760
		public static bool IsMappableControllerElementType(object type); // 0x00000001813E9FC0-0x00000001813EA140
		public static bool IsMappableType(ControllerElementType type); // 0x00000001813EA140-0x00000001813EA150
		public static bool IsMappableType(ControllerTemplateElementType type); // 0x00000001813EA150-0x00000001813EA160
		public static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType); // 0x00000001813E9D50-0x00000001813E9E70
		public static float AxisToDigitalValue(float value); // 0x00000001813E9610-0x00000001813E9670
		public static float AxisToDigitalValue(float value, float threshold); // 0x00000001813E95A0-0x00000001813E9610
	}
}
