/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class Interp // TypeDefIndex: 9318
	{
		// Constructors
		public Interp(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static float Float(float t, InterpolationMode mode); // 0x0000000182281610-0x0000000182281D20
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode); // 0x0000000182282730-0x0000000182282860
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed); // 0x0000000182282150-0x0000000182282250
		private static float None(float t, float b, float c); // 0x0000000182282250-0x0000000182282260
		private static float InOutCubic(float t, float b, float c); // 0x0000000182281F30-0x0000000182281F60
		private static float InOutQuintic(float t, float b, float c); // 0x0000000182281F60-0x0000000182281FB0
		private static float InQuintic(float t, float b, float c); // 0x0000000182282090-0x00000001822820B0
		private static float InQuartic(float t, float b, float c); // 0x0000000182282070-0x0000000182282090
		private static float InCubic(float t, float b, float c); // 0x0000000182281D50-0x0000000182281D70
		private static float InQuadratic(float t, float b, float c); // 0x0000000182282060-0x0000000182282070
		private static float OutQuintic(float t, float b, float c); // 0x0000000182282630-0x00000001822826A0
		private static float OutQuartic(float t, float b, float c); // 0x00000001822825D0-0x0000000182282630
		private static float OutCubic(float t, float b, float c); // 0x0000000182282330-0x0000000182282370
		private static float OutInCubic(float t, float b, float c); // 0x0000000182282550-0x0000000182282590
		private static float OutInQuartic(float t, float b, float c); // 0x0000000182282590-0x00000001822825D0
		private static float BackInCubic(float t, float b, float c); // 0x0000000182281580-0x00000001822815B0
		private static float BackInQuartic(float t, float b, float c); // 0x00000001822815B0-0x0000000182281610
		private static float OutBackCubic(float t, float b, float c); // 0x0000000182282260-0x00000001822822A0
		private static float OutBackQuartic(float t, float b, float c); // 0x00000001822822A0-0x00000001822822F0
		private static float OutElasticSmall(float t, float b, float c); // 0x00000001822823E0-0x0000000182282450
		private static float OutElasticBig(float t, float b, float c); // 0x0000000182282370-0x00000001822823E0
		private static float InElasticSmall(float t, float b, float c); // 0x0000000182281DD0-0x0000000182281E30
		private static float InElasticBig(float t, float b, float c); // 0x0000000182281D70-0x0000000182281DD0
		private static float InSine(float t, float b, float c); // 0x00000001822820B0-0x0000000182282150
		private static float OutSine(float t, float b, float c); // 0x00000001822826A0-0x0000000182282730
		private static float InOutSine(float t, float b, float c); // 0x0000000182281FB0-0x0000000182282060
		private static float InElastic(float t, float b, float c); // 0x0000000182281E30-0x0000000182281F30
		private static float OutElastic(float t, float b, float c); // 0x0000000182282450-0x0000000182282550
		private static float InBack(float t, float b, float c); // 0x0000000182281D20-0x0000000182281D50
		private static float OutBack(float t, float b, float c); // 0x00000001822822F0-0x0000000182282330
	}
}
