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
	public static class DOTweenModulePhysics2D // TypeDefIndex: 7437
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7438
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOMove>b__0(); // 0x000000018227EAA0-0x000000018227EAC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7439
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOMoveX>b__0(); // 0x000000018227EAA0-0x000000018227EAC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 7440
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOMoveY>b__0(); // 0x000000018227EAA0-0x000000018227EAC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 7441
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <DORotate>b__0(); // 0x000000018227F780-0x000000018227F7A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 7442
		{
			// Fields
			public Rigidbody2D target; // 0x10
			public float startPosY; // 0x18
			public bool offsetYSet; // 0x1C
			public float offsetY; // 0x20
			public Sequence s; // 0x28
			public Vector2 endValue; // 0x30
			public Tween yTween; // 0x38
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Vector2 <DOJump>b__0(); // 0x000000018227EAA0-0x000000018227EAC0
			internal void <DOJump>b__1(Vector2 x); // 0x000000018227F7A0-0x000000018227F7C0
			internal void <DOJump>b__2(); // 0x000000018227F7C0-0x000000018227F800
			internal Vector2 <DOJump>b__3(); // 0x000000018227EAA0-0x000000018227EAC0
			internal void <DOJump>b__4(Vector2 x); // 0x000000018227F7A0-0x000000018227F7C0
			internal void <DOJump>b__5(); // 0x000000018227F800-0x000000018227F960
		}
	
		// Extension methods
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x00741A09 */); // 0x0000000182277DE0-0x0000000182277F40
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false /* Metadata: 0x00741A0A */); // 0x0000000182277B00-0x0000000182277C70
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false /* Metadata: 0x00741A0B */); // 0x0000000182277C70-0x0000000182277DE0
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration); // 0x0000000182277F40-0x0000000182278080
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x00741A0C */); // 0x0000000182277790-0x0000000182277B00
	}
}
