/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class Interp // TypeDefIndex: 9772
	{
		// Constructors
		public Interp(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static float Float(float t, InterpolationMode mode); // 0x000000018201CF00-0x000000018201D610
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode); // 0x000000018201E020-0x000000018201E150
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed); // 0x000000018201DA40-0x000000018201DB40
		private static float None(float t, float b, float c); // 0x000000018201DB40-0x000000018201DB50
		private static float InOutCubic(float t, float b, float c); // 0x000000018201D820-0x000000018201D850
		private static float InOutQuintic(float t, float b, float c); // 0x000000018201D850-0x000000018201D8A0
		private static float InQuintic(float t, float b, float c); // 0x000000018201D980-0x000000018201D9A0
		private static float InQuartic(float t, float b, float c); // 0x000000018201D960-0x000000018201D980
		private static float InCubic(float t, float b, float c); // 0x000000018201D640-0x000000018201D660
		private static float InQuadratic(float t, float b, float c); // 0x000000018201D950-0x000000018201D960
		private static float OutQuintic(float t, float b, float c); // 0x000000018201DF20-0x000000018201DF90
		private static float OutQuartic(float t, float b, float c); // 0x000000018201DEC0-0x000000018201DF20
		private static float OutCubic(float t, float b, float c); // 0x000000018201DC20-0x000000018201DC60
		private static float OutInCubic(float t, float b, float c); // 0x000000018201DE40-0x000000018201DE80
		private static float OutInQuartic(float t, float b, float c); // 0x000000018201DE80-0x000000018201DEC0
		private static float BackInCubic(float t, float b, float c); // 0x000000018201CE70-0x000000018201CEA0
		private static float BackInQuartic(float t, float b, float c); // 0x000000018201CEA0-0x000000018201CF00
		private static float OutBackCubic(float t, float b, float c); // 0x000000018201DB50-0x000000018201DB90
		private static float OutBackQuartic(float t, float b, float c); // 0x000000018201DB90-0x000000018201DBE0
		private static float OutElasticSmall(float t, float b, float c); // 0x000000018201DCD0-0x000000018201DD40
		private static float OutElasticBig(float t, float b, float c); // 0x000000018201DC60-0x000000018201DCD0
		private static float InElasticSmall(float t, float b, float c); // 0x000000018201D6C0-0x000000018201D720
		private static float InElasticBig(float t, float b, float c); // 0x000000018201D660-0x000000018201D6C0
		private static float InSine(float t, float b, float c); // 0x000000018201D9A0-0x000000018201DA40
		private static float OutSine(float t, float b, float c); // 0x000000018201DF90-0x000000018201E020
		private static float InOutSine(float t, float b, float c); // 0x000000018201D8A0-0x000000018201D950
		private static float InElastic(float t, float b, float c); // 0x000000018201D720-0x000000018201D820
		private static float OutElastic(float t, float b, float c); // 0x000000018201DD40-0x000000018201DE40
		private static float InBack(float t, float b, float c); // 0x000000018201D610-0x000000018201D640
		private static float OutBack(float t, float b, float c); // 0x000000018201DBE0-0x000000018201DC20
	}
}
