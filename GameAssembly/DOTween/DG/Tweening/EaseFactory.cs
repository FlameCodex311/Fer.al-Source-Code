/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public class EaseFactory // TypeDefIndex: 5523
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 5524
		{
			// Fields
			public float motionDelay; // 0x10
			public EaseFunction customEase; // 0x18
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000180BD7F70-0x0000000180BD7FF0
		}
	
		// Constructors
		public EaseFactory(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default); // 0x0000000180BCA2F0-0x0000000180BCA380
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve); // 0x0000000180BCA260-0x0000000180BCA2F0
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase); // 0x0000000180BCA380-0x0000000180BCA430
	}
}
