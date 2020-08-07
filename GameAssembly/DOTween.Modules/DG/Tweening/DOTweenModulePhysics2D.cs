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
	public static class DOTweenModulePhysics2D // TypeDefIndex: 7603
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 7604
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOMove>b__0(); // 0x0000000181FEFFB0-0x0000000181FEFFD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 7605
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOMoveX>b__0(); // 0x0000000181FEFFB0-0x0000000181FEFFD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 7606
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOMoveY>b__0(); // 0x0000000181FEFFB0-0x0000000181FEFFD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 7607
		{
			// Fields
			public Rigidbody2D target; // 0x10
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <DORotate>b__0(); // 0x0000000181FF0C80-0x0000000181FF0CA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 7608
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
			public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Vector2 <DOJump>b__0(); // 0x0000000181FEFFB0-0x0000000181FEFFD0
			internal void <DOJump>b__1(Vector2 x); // 0x0000000181FF0CA0-0x0000000181FF0CC0
			internal void <DOJump>b__2(); // 0x0000000181FF0CC0-0x0000000181FF0D00
			internal Vector2 <DOJump>b__3(); // 0x0000000181FEFFB0-0x0000000181FEFFD0
			internal void <DOJump>b__4(Vector2 x); // 0x0000000181FF0CA0-0x0000000181FF0CC0
			internal void <DOJump>b__5(); // 0x0000000181FF0D00-0x0000000181FF0E60
		}
	
		// Extension methods
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x007766F7 */); // 0x0000000181FE9390-0x0000000181FE94F0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false /* Metadata: 0x007766F8 */); // 0x0000000181FE90B0-0x0000000181FE9220
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false /* Metadata: 0x007766F9 */); // 0x0000000181FE9220-0x0000000181FE9390
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration); // 0x0000000181FE94F0-0x0000000181FE9630
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x007766FA */); // 0x0000000181FE8D50-0x0000000181FE90B0
	}
}
