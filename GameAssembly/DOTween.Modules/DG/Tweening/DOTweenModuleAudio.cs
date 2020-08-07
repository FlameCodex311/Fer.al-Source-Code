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

// Image 61: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7586-7665

namespace DG.Tweening
{
	public static class DOTweenModuleAudio // TypeDefIndex: 7587
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7588
		{
			// Fields
			public AudioSource target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <DOFade>b__0(); // 0x0000000181FEFF50-0x0000000181FEFF70
			internal void <DOFade>b__1(float x); // 0x0000000181FEFF90-0x0000000181FEFFB0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7589
		{
			// Fields
			public AudioSource target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <DOPitch>b__0(); // 0x0000000181FF02F0-0x0000000181FF0310
			internal void <DOPitch>b__1(float x); // 0x0000000181FF0310-0x0000000181FF0330
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 7590
		{
			// Fields
			public AudioMixer target; // 0x10
			public string floatName; // 0x18
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <DOSetFloat>b__0(); // 0x0000000181FF08D0-0x0000000181FF0910
			internal void <DOSetFloat>b__1(float x); // 0x0000000181FF0910-0x0000000181FF0940
		}
	
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration); // 0x0000000181FE8550-0x0000000181FE86A0
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration); // 0x0000000181FE8850-0x0000000181FE8980
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration); // 0x0000000181FE8B60-0x0000000181FE8C90
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false /* Metadata: 0x007766C7 */); // 0x0000000181FE84E0-0x0000000181FE8550
		public static int DOKill(this AudioMixer target, bool complete = false /* Metadata: 0x007766C8 */); // 0x0000000181FE8780-0x0000000181FE87F0
		public static int DOFlip(this AudioMixer target); // 0x0000000181FE86A0-0x0000000181FE8700
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false /* Metadata: 0x007766C9 */); // 0x0000000181FE8700-0x0000000181FE8780
		public static int DOPause(this AudioMixer target); // 0x0000000181FE87F0-0x0000000181FE8850
		public static int DOPlay(this AudioMixer target); // 0x0000000181FE8A40-0x0000000181FE8AA0
		public static int DOPlayBackwards(this AudioMixer target); // 0x0000000181FE8980-0x0000000181FE89E0
		public static int DOPlayForward(this AudioMixer target); // 0x0000000181FE89E0-0x0000000181FE8A40
		public static int DORestart(this AudioMixer target); // 0x0000000181FE8AA0-0x0000000181FE8B00
		public static int DORewind(this AudioMixer target); // 0x0000000181FE8B00-0x0000000181FE8B60
		public static int DOSmoothRewind(this AudioMixer target); // 0x0000000181FE8C90-0x0000000181FE8CF0
		public static int DOTogglePause(this AudioMixer target); // 0x0000000181FE8CF0-0x0000000181FE8D50
	}
}
