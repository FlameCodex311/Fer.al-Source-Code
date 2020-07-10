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
	public static class DOVirtual // TypeDefIndex: 5520
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 5521
		{
			// Fields
			public float val; // 0x10
			public TweenCallback<float> onVirtualUpdate; // 0x18
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <Float>b__0(); // 0x0000000180493360-0x0000000180493370
			internal void <Float>b__1(float x); // 0x0000000180BD7F10-0x0000000180BD7F20
			internal void <Float>b__2(); // 0x0000000180BD7F20-0x0000000180BD7F70
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate); // 0x0000000180BC93C0-0x0000000180BC9520
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType); // 0x0000000180BC9280-0x0000000180BC9350
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot); // 0x0000000180BC9090-0x0000000180BC9160
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x0000000180BC9350-0x0000000180BC93C0
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve); // 0x0000000180BC9160-0x0000000180BC9280
		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x0072E5A5 */); // 0x0000000180BC8F60-0x0000000180BC9090
	}
}
