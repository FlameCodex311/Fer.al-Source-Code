/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public sealed class Sequence : Tween // TypeDefIndex: 5692
	{
		// Fields
		internal readonly List<Tween> sequencedTweens; // 0x118
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x120
		internal float lastTweenInsertTime; // 0x128
	
		// Constructors
		internal Sequence(); // 0x00000001818C0D10-0x00000001818C0DC0
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, Tween t); // 0x00000001818C0350-0x00000001818C05D0
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition); // 0x00000001818C00D0-0x00000001818C0230
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval); // 0x00000001818BFBC0-0x00000001818BFC00
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval); // 0x00000001818C0230-0x00000001818C0350
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition); // 0x00000001818C0000-0x00000001818C00D0
		internal override void Reset(); // 0x00000001818C0900-0x00000001818C0980
		internal override bool Validate(); // 0x00000001818C0C30-0x00000001818C0D10
		internal override bool Startup(); // 0x00000001818C0C20-0x00000001818C0C30
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice); // 0x00000001818BFBA0-0x00000001818BFBC0
		internal static void Setup(Sequence s); // 0x00000001818C0980-0x00000001818C0AD0
		internal static bool DoStartup(Sequence s); // 0x00000001818C05D0-0x00000001818C08A0
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode); // 0x00000001818BFC00-0x00000001818C0000
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x00763367 */); // 0x00000001818BF370-0x00000001818BFBA0
		private static void StableSortSequencedObjs(List<ABSSequentiable> list); // 0x00000001818C0AD0-0x00000001818C0C20
		private static bool IsAnyCallbackSet(Sequence s); // 0x00000001818C08A0-0x00000001818C0900
	}
}
