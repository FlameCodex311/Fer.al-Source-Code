/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 61: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7586-7665

namespace DG.Tweening
{
	public static class DOTweenCYInstruction // TypeDefIndex: 7657
	{
		// Nested types
		public class WaitForCompletion : CustomYieldInstruction // TypeDefIndex: 7658
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF1790-0x0000000181FF17D0 
	
			// Constructors
			public WaitForCompletion(Tween tween); // 0x00000001803F3520-0x00000001803F3550
		}
	
		public class WaitForRewind : CustomYieldInstruction // TypeDefIndex: 7659
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF18E0-0x0000000181FF1960 
	
			// Constructors
			public WaitForRewind(Tween tween); // 0x00000001803F3520-0x00000001803F3550
		}
	
		public class WaitForKill : CustomYieldInstruction // TypeDefIndex: 7660
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF1810-0x0000000181FF1830 
	
			// Constructors
			public WaitForKill(Tween tween); // 0x00000001803F3520-0x00000001803F3550
		}
	
		public class WaitForElapsedLoops : CustomYieldInstruction // TypeDefIndex: 7661
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly int elapsedLoops; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF17D0-0x0000000181FF1810 
	
			// Constructors
			public WaitForElapsedLoops(Tween tween, int elapsedLoops); // 0x00000001803F4670-0x00000001803F46B0
		}
	
		public class WaitForPosition : CustomYieldInstruction // TypeDefIndex: 7662
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly float position; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF1870-0x0000000181FF18E0 
	
			// Constructors
			public WaitForPosition(Tween tween, float position); // 0x0000000181FF1830-0x0000000181FF1870
		}
	
		public class WaitForStart : CustomYieldInstruction // TypeDefIndex: 7663
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000181FF1960-0x0000000181FF19A0 
	
			// Constructors
			public WaitForStart(Tween tween); // 0x00000001803F3520-0x00000001803F3550
		}
	}
}
