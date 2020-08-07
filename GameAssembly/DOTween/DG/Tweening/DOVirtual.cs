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
	public static class DOVirtual // TypeDefIndex: 5679
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 5680
		{
			// Fields
			public float val; // 0x10
			public TweenCallback<float> onVirtualUpdate; // 0x18
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <Float>b__0(); // 0x0000000180373AA0-0x0000000180373AB0
			internal void <Float>b__1(float x); // 0x0000000180373AB0-0x0000000180373AC0
			internal void <Float>b__2(); // 0x000000018179AF40-0x000000018179AF90
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate); // 0x000000018178C980-0x000000018178CAE0
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType); // 0x000000018178C840-0x000000018178C910
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot); // 0x000000018178C650-0x000000018178C720
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x000000018178C910-0x000000018178C980
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve); // 0x000000018178C720-0x000000018178C840
		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x00763242 */); // 0x000000018178C520-0x000000018178C650
	}
}
