/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public class EaseFactory // TypeDefIndex: 5682
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 5683
		{
			// Fields
			public float motionDelay; // 0x10
			public EaseFunction customEase; // 0x18
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018179AF90-0x000000018179B010
		}
	
		// Constructors
		public EaseFactory(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default); // 0x000000018178D850-0x000000018178D8E0
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve); // 0x000000018178D7C0-0x000000018178D850
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase); // 0x000000018178D8E0-0x000000018178D990
	}
}
