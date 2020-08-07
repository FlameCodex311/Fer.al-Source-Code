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
	public static class DOTweenModuleUnityVersion // TypeDefIndex: 7654
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 7655
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOOffset>b__0(); // 0x0000000181FF1300-0x0000000181FF1330
			internal void <DOOffset>b__1(Vector2 x); // 0x0000000181FF1330-0x0000000181FF1360
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 7656
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOTiling>b__0(); // 0x0000000181FF1440-0x0000000181FF1470
			internal void <DOTiling>b__1(Vector2 x); // 0x0000000181FF1470-0x0000000181FF14A0
		}
	
		// Extension methods
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration); // 0x0000000181FEEE00-0x0000000181FEF040
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration); // 0x0000000181FEEBA0-0x0000000181FEEE00
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction); // 0x0000000181FEF360-0x0000000181FEF410
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction); // 0x0000000181FEF650-0x0000000181FEF700
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction); // 0x0000000181FEF4D0-0x0000000181FEF580
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction); // 0x0000000181FEF410-0x0000000181FEF4D0
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction); // 0x0000000181FEF580-0x0000000181FEF650
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction); // 0x0000000181FEF700-0x0000000181FEF7B0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration); // 0x0000000181FEF040-0x0000000181FEF1D0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration); // 0x0000000181FEF1D0-0x0000000181FEF360
	}
}
