/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 61: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7586-7665

namespace DG.Tweening
{
	public static class DOTweenModuleSprite // TypeDefIndex: 7609
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7610
		{
			// Fields
			public SpriteRenderer target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Color <DOColor>b__0(); // 0x0000000181FEFEC0-0x0000000181FEFF00
			internal void <DOColor>b__1(Color x); // 0x0000000181FEFF00-0x0000000181FEFF30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7611
		{
			// Fields
			public SpriteRenderer target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Color <DOFade>b__0(); // 0x0000000181FEFEC0-0x0000000181FEFF00
			internal void <DOFade>b__1(Color x); // 0x0000000181FEFF00-0x0000000181FEFF30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 7612
		{
			// Fields
			public Color to; // 0x10
			public SpriteRenderer target; // 0x20
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Color <DOBlendableColor>b__0(); // 0x0000000180619460-0x0000000180619470
			internal void <DOBlendableColor>b__1(Color x); // 0x0000000181FF0BD0-0x0000000181FF0C80
		}
	
		// Extension methods
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration); // 0x0000000181FEACE0-0x0000000181FEAE10
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration); // 0x0000000181FEAE10-0x0000000181FEAF40
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration); // 0x0000000181FEAF40-0x0000000181FEB180
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration); // 0x0000000181FEAB10-0x0000000181FEACE0
	}
}
