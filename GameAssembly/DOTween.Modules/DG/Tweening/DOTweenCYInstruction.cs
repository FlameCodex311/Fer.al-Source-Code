/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 60: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7420-7499

namespace DG.Tweening
{
	public static class DOTweenCYInstruction // TypeDefIndex: 7491
	{
		// Nested types
		public class WaitForCompletion : CustomYieldInstruction // TypeDefIndex: 7492
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x00000001822802A0-0x00000001822802E0 
	
			// Constructors
			public WaitForCompletion(Tween tween); // 0x00000001805A9650-0x00000001805A9680
		}
	
		public class WaitForRewind : CustomYieldInstruction // TypeDefIndex: 7493
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000182280400-0x0000000182280480 
	
			// Constructors
			public WaitForRewind(Tween tween); // 0x00000001805A9650-0x00000001805A9680
		}
	
		public class WaitForKill : CustomYieldInstruction // TypeDefIndex: 7494
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000182280320-0x0000000182280350 
	
			// Constructors
			public WaitForKill(Tween tween); // 0x00000001805A9650-0x00000001805A9680
		}
	
		public class WaitForElapsedLoops : CustomYieldInstruction // TypeDefIndex: 7495
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly int elapsedLoops; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x00000001822802E0-0x0000000182280320 
	
			// Constructors
			public WaitForElapsedLoops(Tween tween, int elapsedLoops); // 0x0000000180B57450-0x0000000180B57490
		}
	
		public class WaitForPosition : CustomYieldInstruction // TypeDefIndex: 7496
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly float position; // 0x18
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000182280390-0x0000000182280400 
	
			// Constructors
			public WaitForPosition(Tween tween, float position); // 0x0000000182280350-0x0000000182280390
		}
	
		public class WaitForStart : CustomYieldInstruction // TypeDefIndex: 7497
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get; } // 0x0000000182280480-0x00000001822804D0 
	
			// Constructors
			public WaitForStart(Tween tween); // 0x00000001805A9650-0x00000001805A9680
		}
	}
}
