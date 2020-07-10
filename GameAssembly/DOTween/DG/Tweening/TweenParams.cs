/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public class TweenParams // TypeDefIndex: 5611
	{
		// Fields
		public static readonly TweenParams Params; // 0x00
		internal object id; // 0x10
		internal object target; // 0x18
		internal UpdateType updateType; // 0x20
		internal bool isIndependentUpdate; // 0x24
		internal TweenCallback onStart; // 0x28
		internal TweenCallback onPlay; // 0x30
		internal TweenCallback onRewind; // 0x38
		internal TweenCallback onUpdate; // 0x40
		internal TweenCallback onStepComplete; // 0x48
		internal TweenCallback onComplete; // 0x50
		internal TweenCallback onKill; // 0x58
		internal TweenCallback<int> onWaypointChange; // 0x60
		internal bool isRecyclable; // 0x68
		internal bool isSpeedBased; // 0x69
		internal bool autoKill; // 0x6A
		internal int loops; // 0x6C
		internal LoopType loopType; // 0x70
		internal float delay; // 0x74
		internal bool isRelative; // 0x78
		internal Ease easeType; // 0x7C
		internal EaseFunction customEase; // 0x80
		internal float easeOvershootOrAmplitude; // 0x88
		internal float easePeriod; // 0x8C
	
		// Constructors
		public TweenParams(); // 0x0000000180DD0C40-0x0000000180DD0D80
		static TweenParams(); // 0x0000000180DD0AD0-0x0000000180DD0C40
	
		// Methods
		public TweenParams Clear(); // 0x0000000180DD05E0-0x0000000180DD0720
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x0072E7A6 */); // 0x0000000180DD07A0-0x0000000180DD07B0
		public TweenParams SetId(object id); // 0x0000000180DD0980-0x0000000180DD0990
		public TweenParams SetTarget(object target); // 0x0000000180DD0A30-0x0000000180DD0A40
		public TweenParams SetLoops(int loops, LoopType? loopType = default); // 0x0000000180DD0990-0x0000000180DD0A00
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default); // 0x0000000180DD07E0-0x0000000180DD08E0
		public TweenParams SetEase(AnimationCurve animCurve); // 0x0000000180DD08E0-0x0000000180DD0980
		public TweenParams SetEase(EaseFunction customEase); // 0x0000000180DD07C0-0x0000000180DD07E0
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x0072E7A7 */); // 0x0000000180DD0A00-0x0000000180DD0A10
		public TweenParams SetUpdate(bool isIndependentUpdate); // 0x0000000180DD0A50-0x0000000180DD0AD0
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x0072E7A8 */); // 0x0000000180DD0A40-0x0000000180DD0A50
		public TweenParams OnStart(TweenCallback action); // 0x0000000180DD0760-0x0000000180DD0770
		public TweenParams OnPlay(TweenCallback action); // 0x0000000180DD0740-0x0000000180DD0750
		public TweenParams OnRewind(TweenCallback action); // 0x0000000180DD0750-0x0000000180DD0760
		public TweenParams OnUpdate(TweenCallback action); // 0x0000000180DD0780-0x0000000180DD0790
		public TweenParams OnStepComplete(TweenCallback action); // 0x0000000180DD0770-0x0000000180DD0780
		public TweenParams OnComplete(TweenCallback action); // 0x0000000180DD0720-0x0000000180DD0730
		public TweenParams OnKill(TweenCallback action); // 0x0000000180DD0730-0x0000000180DD0740
		public TweenParams OnWaypointChange(TweenCallback<int> action); // 0x0000000180DD0790-0x0000000180DD07A0
		public TweenParams SetDelay(float delay); // 0x0000000180DD07B0-0x0000000180DD07C0
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x0072E7A9 */); // 0x0000000180DD0A10-0x0000000180DD0A20
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x0072E7AA */); // 0x0000000180DD0A20-0x0000000180DD0A30
	}
}
