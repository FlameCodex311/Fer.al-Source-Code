/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public class TweenParams // TypeDefIndex: 5770
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
		public TweenParams(); // 0x000000018209B730-0x000000018209B870
		static TweenParams(); // 0x000000018209B5C0-0x000000018209B730
	
		// Methods
		public TweenParams Clear(); // 0x000000018209B0E0-0x000000018209B220
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x00763443 */); // 0x000000018209B290-0x000000018209B2A0
		public TweenParams SetId(object id); // 0x000000018209B470-0x000000018209B480
		public TweenParams SetTarget(object target); // 0x000000018209B520-0x000000018209B530
		public TweenParams SetLoops(int loops, LoopType? loopType = default); // 0x000000018209B480-0x000000018209B4F0
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default); // 0x000000018209B2D0-0x000000018209B3D0
		public TweenParams SetEase(AnimationCurve animCurve); // 0x000000018209B3D0-0x000000018209B470
		public TweenParams SetEase(EaseFunction customEase); // 0x000000018209B2B0-0x000000018209B2D0
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x00763444 */); // 0x000000018209B4F0-0x000000018209B500
		public TweenParams SetUpdate(bool isIndependentUpdate); // 0x000000018209B540-0x000000018209B5C0
		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x00763445 */); // 0x000000018209B530-0x000000018209B540
		public TweenParams OnStart(TweenCallback action); // 0x000000018209B250-0x000000018209B260
		public TweenParams OnPlay(TweenCallback action); // 0x000000018097E620-0x000000018097E630
		public TweenParams OnRewind(TweenCallback action); // 0x000000018209B240-0x000000018209B250
		public TweenParams OnUpdate(TweenCallback action); // 0x000000018209B270-0x000000018209B280
		public TweenParams OnStepComplete(TweenCallback action); // 0x000000018209B260-0x000000018209B270
		public TweenParams OnComplete(TweenCallback action); // 0x000000018209B220-0x000000018209B230
		public TweenParams OnKill(TweenCallback action); // 0x000000018209B230-0x000000018209B240
		public TweenParams OnWaypointChange(TweenCallback<int> action); // 0x000000018209B280-0x000000018209B290
		public TweenParams SetDelay(float delay); // 0x000000018209B2A0-0x000000018209B2B0
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x00763446 */); // 0x000000018209B500-0x000000018209B510
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x00763447 */); // 0x000000018209B510-0x000000018209B520
	}
}
