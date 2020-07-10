/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public abstract class Tween : ABSSequentiable // TypeDefIndex: 5614
	{
		// Fields
		public float timeScale; // 0x28
		public bool isBackwards; // 0x2C
		public object id; // 0x30
		public string stringId; // 0x38
		public int intId; // 0x40
		public object target; // 0x48
		internal UpdateType updateType; // 0x50
		internal bool isIndependentUpdate; // 0x54
		public TweenCallback onPlay; // 0x58
		public TweenCallback onPause; // 0x60
		public TweenCallback onRewind; // 0x68
		public TweenCallback onUpdate; // 0x70
		public TweenCallback onStepComplete; // 0x78
		public TweenCallback onComplete; // 0x80
		public TweenCallback onKill; // 0x88
		public TweenCallback<int> onWaypointChange; // 0x90
		internal bool isFrom; // 0x98
		internal bool isBlendable; // 0x99
		internal bool isRecyclable; // 0x9A
		internal bool isSpeedBased; // 0x9B
		internal bool autoKill; // 0x9C
		internal float duration; // 0xA0
		internal int loops; // 0xA4
		internal LoopType loopType; // 0xA8
		internal float delay; // 0xAC
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isRelative>k__BackingField; // 0xB0
		internal Ease easeType; // 0xB4
		internal EaseFunction customEase; // 0xB8
		public float easeOvershootOrAmplitude; // 0xC0
		public float easePeriod; // 0xC4
		internal Type typeofT1; // 0xC8
		internal Type typeofT2; // 0xD0
		internal Type typeofTPlugOptions; // 0xD8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <active>k__BackingField; // 0xE0
		internal bool isSequenced; // 0xE1
		internal Sequence sequenceParent; // 0xE8
		internal int activeId; // 0xF0
		internal SpecialStartupMode specialStartupMode; // 0xF4
		internal bool creationLocked; // 0xF8
		internal bool startupDone; // 0xF9
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <playedOnce>k__BackingField; // 0xFA
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <position>k__BackingField; // 0xFC
		internal float fullDuration; // 0x100
		internal int completedLoops; // 0x104
		internal bool isPlaying; // 0x108
		internal bool isComplete; // 0x109
		internal float elapsedDelay; // 0x10C
		internal bool delayComplete; // 0x110
		internal int miscInt; // 0x114
	
		// Properties
		public bool isRelative { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ internal set; } // 0x0000000180DD1FF0-0x0000000180DD2000 0x0000000180DD2170-0x0000000180DD2180
		public bool active { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ internal set; } // 0x000000018081E0D0-0x000000018081E0E0 0x0000000180DD2020-0x0000000180DD2030
		public float fullPosition { get; set; } // 0x0000000180DD1F60-0x0000000180DD1FF0 0x0000000180DD2030-0x0000000180DD2170
		public bool playedOnce { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180DD2000-0x0000000180DD2010 0x0000000180DD2180-0x0000000180DD2190
		public float position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ internal set; } // 0x0000000180DD2010-0x0000000180DD2020 0x0000000180DD2190-0x0000000180DD21A0
	
		// Constructors
		protected Tween(); // 0x0000000180DD1F30-0x0000000180DD1F60
	
		// Methods
		internal virtual void Reset(); // 0x0000000180DD1E50-0x0000000180DD1F20
		internal abstract bool Validate();
		internal virtual float UpdateDelay(float elapsed); // 0x0000000180DD1F20-0x0000000180DD1F30
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode); // 0x0000000180DD1910-0x0000000180DD1CB0
		internal static bool OnTweenCallback(TweenCallback callback); // 0x0000000180DD1CB0-0x0000000180DD1E50
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, T param);
	}
}
