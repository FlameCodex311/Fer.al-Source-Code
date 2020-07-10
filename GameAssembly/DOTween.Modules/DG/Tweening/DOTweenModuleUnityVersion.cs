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
	public static class DOTweenModuleUnityVersion // TypeDefIndex: 7488
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 7489
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOOffset>b__0(); // 0x000000018227FE10-0x000000018227FE40
			internal void <DOOffset>b__1(Vector2 x); // 0x000000018227FE40-0x000000018227FE70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 7490
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOTiling>b__0(); // 0x000000018227FF50-0x000000018227FF80
			internal void <DOTiling>b__1(Vector2 x); // 0x000000018227FF80-0x000000018227FFB0
		}
	
		// Extension methods
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration); // 0x000000018227D890-0x000000018227DAE0
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration); // 0x000000018227D620-0x000000018227D890
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction); // 0x000000018227DE20-0x000000018227DED0
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction); // 0x000000018227E120-0x000000018227E1D0
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction); // 0x000000018227DFA0-0x000000018227E050
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction); // 0x000000018227DED0-0x000000018227DFA0
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction); // 0x000000018227E050-0x000000018227E120
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction); // 0x000000018227E1D0-0x000000018227E280
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration); // 0x000000018227DAE0-0x000000018227DC80
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration); // 0x000000018227DC80-0x000000018227DE20
	}
}
