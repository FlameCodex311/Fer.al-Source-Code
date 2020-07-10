/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 60: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7420-7499

namespace DG.Tweening
{
	public static class DOTweenModuleSprite // TypeDefIndex: 7443
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7444
		{
			// Fields
			public SpriteRenderer target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Color <DOColor>b__0(); // 0x000000018227E9B0-0x000000018227E9F0
			internal void <DOColor>b__1(Color x); // 0x000000018227E9F0-0x000000018227EA20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7445
		{
			// Fields
			public SpriteRenderer target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Color <DOFade>b__0(); // 0x000000018227E9B0-0x000000018227E9F0
			internal void <DOFade>b__1(Color x); // 0x000000018227E9F0-0x000000018227EA20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 7446
		{
			// Fields
			public Color to; // 0x10
			public SpriteRenderer target; // 0x20
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Color <DOBlendableColor>b__0(); // 0x00000001803C0030-0x00000001803C0040
			internal void <DOBlendableColor>b__1(Color x); // 0x000000018227F6D0-0x000000018227F780
		}
	
		// Extension methods
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration); // 0x0000000182279730-0x0000000182279860
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration); // 0x0000000182279860-0x0000000182279990
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration); // 0x0000000182279990-0x0000000182279BE0
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration); // 0x0000000182279560-0x0000000182279730
	}
}
