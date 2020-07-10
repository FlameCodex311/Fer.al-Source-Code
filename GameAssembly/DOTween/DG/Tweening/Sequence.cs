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

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public sealed class Sequence : Tween // TypeDefIndex: 5533
	{
		// Fields
		internal readonly List<Tween> sequencedTweens; // 0x118
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x120
		internal float lastTweenInsertTime; // 0x128
	
		// Constructors
		internal Sequence(); // 0x0000000180C3E980-0x0000000180C3EA30
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, Tween t); // 0x0000000180C3DF90-0x0000000180C3E210
		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition); // 0x0000000180C3DD00-0x0000000180C3DE60
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval); // 0x0000000180C3D7D0-0x0000000180C3D810
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval); // 0x0000000180C3DE60-0x0000000180C3DF90
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition); // 0x0000000180C3DC20-0x0000000180C3DD00
		internal override void Reset(); // 0x0000000180C3E550-0x0000000180C3E5D0
		internal override bool Validate(); // 0x0000000180C3E890-0x0000000180C3E980
		internal override bool Startup(); // 0x0000000180C3E880-0x0000000180C3E890
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice); // 0x0000000180C3D7B0-0x0000000180C3D7D0
		internal static void Setup(Sequence s); // 0x0000000180C3E5D0-0x0000000180C3E720
		internal static bool DoStartup(Sequence s); // 0x0000000180C3E210-0x0000000180C3E4F0
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode); // 0x0000000180C3D810-0x0000000180C3DC20
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x0072E6CA */); // 0x0000000180C3CF60-0x0000000180C3D7B0
		private static void StableSortSequencedObjs(List<ABSSequentiable> list); // 0x0000000180C3E720-0x0000000180C3E880
		private static bool IsAnyCallbackSet(Sequence s); // 0x0000000180C3E4F0-0x0000000180C3E550
	}
}
