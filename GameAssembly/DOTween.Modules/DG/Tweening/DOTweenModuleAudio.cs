/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Audio;

// Image 60: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7420-7499

namespace DG.Tweening
{
	public static class DOTweenModuleAudio // TypeDefIndex: 7421
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7422
		{
			// Fields
			public AudioSource target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <DOFade>b__0(); // 0x000000018227EA40-0x000000018227EA60
			internal void <DOFade>b__1(float x); // 0x000000018227EA80-0x000000018227EAA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7423
		{
			// Fields
			public AudioSource target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <DOPitch>b__0(); // 0x000000018227EDE0-0x000000018227EE00
			internal void <DOPitch>b__1(float x); // 0x000000018227EE00-0x000000018227EE20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 7424
		{
			// Fields
			public AudioMixer target; // 0x10
			public string floatName; // 0x18
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <DOSetFloat>b__0(); // 0x000000018227F3C0-0x000000018227F400
			internal void <DOSetFloat>b__1(float x); // 0x000000018227F400-0x000000018227F430
		}
	
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration); // 0x0000000182276F90-0x00000001822770E0
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration); // 0x0000000182277290-0x00000001822773C0
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration); // 0x00000001822775A0-0x00000001822776D0
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false /* Metadata: 0x007419D9 */); // 0x0000000182276F20-0x0000000182276F90
		public static int DOKill(this AudioMixer target, bool complete = false /* Metadata: 0x007419DA */); // 0x00000001822771C0-0x0000000182277230
		public static int DOFlip(this AudioMixer target); // 0x00000001822770E0-0x0000000182277140
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false /* Metadata: 0x007419DB */); // 0x0000000182277140-0x00000001822771C0
		public static int DOPause(this AudioMixer target); // 0x0000000182277230-0x0000000182277290
		public static int DOPlay(this AudioMixer target); // 0x0000000182277480-0x00000001822774E0
		public static int DOPlayBackwards(this AudioMixer target); // 0x00000001822773C0-0x0000000182277420
		public static int DOPlayForward(this AudioMixer target); // 0x0000000182277420-0x0000000182277480
		public static int DORestart(this AudioMixer target); // 0x00000001822774E0-0x0000000182277540
		public static int DORewind(this AudioMixer target); // 0x0000000182277540-0x00000001822775A0
		public static int DOSmoothRewind(this AudioMixer target); // 0x00000001822776D0-0x0000000182277730
		public static int DOTogglePause(this AudioMixer target); // 0x0000000182277730-0x0000000182277790
	}
}
