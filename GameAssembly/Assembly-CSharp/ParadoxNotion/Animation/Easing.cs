/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Animation
{
	public static class Easing // TypeDefIndex: 15948
	{
		// Fields
		private static Func<float, float, float, float>[] EaseFunctions; // 0x00
	
		// Constructors
		static Easing(); // 0x00000001806C8B00-0x00000001806C9970
	
		// Methods
		public static float Ease(EaseType type, float from, float to, float t); // 0x00000001806C6850-0x00000001806C6910
		public static Vector3 Ease(EaseType type, Vector3 from, Vector3 to, float t); // 0x00000001806C6590-0x00000001806C6700
		public static Quaternion Ease(EaseType type, Quaternion from, Quaternion to, float t); // 0x00000001806C6700-0x00000001806C6850
		public static Color Ease(EaseType type, Color from, Color to, float t); // 0x00000001806C6460-0x00000001806C6590
		public static float Linear(float from, float to, float t); // 0x00000001806C7FB0-0x00000001806C8030
		public static float QuadraticIn(float from, float to, float t); // 0x00000001806C8130-0x00000001806C81F0
		public static float QuadraticOut(float from, float to, float t); // 0x00000001806C81F0-0x00000001806C82C0
		public static float QuadraticInOut(float from, float to, float t); // 0x00000001806C8030-0x00000001806C8130
		public static float QuarticIn(float from, float to, float t); // 0x00000001806C83D0-0x00000001806C8490
		public static float QuarticOut(float from, float to, float t); // 0x00000001806C8490-0x00000001806C8570
		public static float QuarticInOut(float from, float to, float t); // 0x00000001806C82C0-0x00000001806C83D0
		public static float QuinticIn(float from, float to, float t); // 0x00000001806C8680-0x00000001806C8750
		public static float QuinticOut(float from, float to, float t); // 0x00000001806C8750-0x00000001806C8840
		public static float QuinticInOut(float from, float to, float t); // 0x00000001806C8570-0x00000001806C8680
		public static float CubicIn(float from, float to, float t); // 0x00000001806C6210-0x00000001806C62D0
		public static float CubicOut(float from, float to, float t); // 0x00000001806C62D0-0x00000001806C63B0
		public static float CubicInOut(float from, float to, float t); // 0x00000001806C6110-0x00000001806C6210
		public static float SinusoidalIn(float from, float to, float t); // 0x00000001806C8930-0x00000001806C8A20
		public static float SinusoidalOut(float from, float to, float t); // 0x00000001806C8A20-0x00000001806C8B00
		public static float SinusoidalInOut(float from, float to, float t); // 0x00000001806C8840-0x00000001806C8930
		public static float ExponentialIn(float from, float to, float t); // 0x00000001806C7010-0x00000001806C7130
		public static float ExponentialOut(float from, float to, float t); // 0x00000001806C7130-0x00000001806C7250
		public static float ExponentialInOut(float from, float to, float t); // 0x00000001806C6E50-0x00000001806C7010
		public static float CircularIn(float from, float to, float t); // 0x00000001806C5F20-0x00000001806C6010
		public static float CircularOut(float from, float to, float t); // 0x00000001806C6010-0x00000001806C6110
		public static float CircularInOut(float from, float to, float t); // 0x00000001806C5DC0-0x00000001806C5F20
		public static float ElasticIn(float from, float to, float t); // 0x00000001806C6B30-0x00000001806C6CC0
		public static float ElasticOut(float from, float to, float t); // 0x00000001806C6CC0-0x00000001806C6E50
		public static float ElasticInOut(float from, float to, float t); // 0x00000001806C6910-0x00000001806C6B30
		public static float BounceIn(float from, float to, float t); // 0x00000001806C5B80-0x00000001806C5C70
		public static float BounceOut(float from, float to, float t); // 0x00000001806C5C70-0x00000001806C5DC0
		public static float BounceInOut(float from, float to, float t); // 0x00000001806C5950-0x00000001806C5B80
		public static float BackIn(float from, float to, float t); // 0x00000001806C5790-0x00000001806C5860
		public static float BackOut(float from, float to, float t); // 0x00000001806C5860-0x00000001806C5950
		public static float BackInOut(float from, float to, float t); // 0x00000001806C5670-0x00000001806C5790
		public static Func<float, float, float, float> Function(EaseType type); // 0x00000001806C7250-0x00000001806C7FB0
	
		// Extension methods
		public static float Difference(this float f, float a, float b); // 0x00000001806C63B0-0x00000001806C6460
	}
}
