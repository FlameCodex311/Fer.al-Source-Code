/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Cutscene : MonoBehaviour // TypeDefIndex: 10372
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _cutsceneName; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _mainAnimationName; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _startTriggerName; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _endTriggerName; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _idleAnimationName; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _hasAnimationFile; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _hasSaveFile; // 0x49
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _isSkippable; // 0x4A
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _delayLevelNameDisplay; // 0x4B
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _autoPlayOnLevelLoad; // 0x4C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _playOnce; // 0x4D
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _alwaysForcePlayForDebugging; // 0x4E
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _isUsingFinalShot; // 0x4F
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _finalShotPosition; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _finalShotRotation; // 0x5C
	[Range] // 0x00000001800F93B0-0x00000001800F93F0
	[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
	private float _finalShotReturnInterpolationTime; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Camera _camera; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _skipCanvas; // 0x78
	[Range] // 0x00000001800F9860-0x00000001800F98A0
	[SerializeField] // 0x00000001800F9860-0x00000001800F98A0
	private float _cameraStartInterpolationAnimationOffset; // 0x80
	[Range] // 0x00000001800F93B0-0x00000001800F93F0
	[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
	private float _skipCanvasDelaySeconds; // 0x84
	[Range] // 0x00000001800F9BF0-0x00000001800F9C30
	[SerializeField] // 0x00000001800F9BF0-0x00000001800F9C30
	private float _skipCanvasFadeUpSeconds; // 0x88
	[Range] // 0x00000001800F9D80-0x00000001800F9DC0
	[SerializeField] // 0x00000001800F9D80-0x00000001800F9DC0
	private int _frameRateRollingAverageCount; // 0x8C
	private readonly IDictionary<Camera, float> _originalFieldsOfViewLookup; // 0x90
	private readonly List<float> _mostRecentDeltaTimes; // 0x98
	private float? _lastTimeSinceStartup; // 0xA0
	private Action<CutscenePlaybackState> _cutsceneEndedCallback; // 0xA8
	private bool _wasOriginalFieldsOfViewCaptured; // 0xB0
	private bool _isSkipRequested; // 0xB1
	private bool _isCancelRequested; // 0xB2
	private bool _isTestPlay; // 0xB3
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <OriginalMainCameraPosition>k__BackingField; // 0xB4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Quaternion <OriginalMainCameraRotation>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OriginalMainCameraFieldOfView>k__BackingField; // 0xD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private CutscenePlaybackState <PlaybackState>k__BackingField; // 0xD4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsInitialized>k__BackingField; // 0xD8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <PlayCount>k__BackingField; // 0xDC

	// Properties
	protected string SaveFilePrefix { get; } // 0x0000000180F440E0-0x0000000180F44120 
	protected Camera Camera { get; } // 0x0000000180369B50-0x0000000180369B60 
	protected Animator Animator { get; } // 0x0000000180F43EE0-0x0000000180F43F30 
	protected Avatar_Local Player { get; } // 0x0000000180F440A0-0x0000000180F440E0 
	protected string MainAnimationName { get; } // 0x0000000180369B60-0x0000000180369B70 
	protected string StartTriggerName { get; } // 0x0000000180397720-0x0000000180397730 
	protected string EndTriggerName { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	protected string IdleAnimationName { get; } // 0x0000000180369B30-0x0000000180369B40 
	protected bool IsSkippable { get; } // 0x000000018081D980-0x000000018081D990 
	protected bool DelayLevelNameDisplay { get; } // 0x0000000180F43F60-0x0000000180F43F70 
	protected bool IsFinishCutsceneRequested { get; } // 0x0000000180F43F70-0x0000000180F43F90 
	protected Vector3 OriginalMainCameraPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F44060-0x0000000180F44080 0x0000000180F44140-0x0000000180F44160
	protected Quaternion OriginalMainCameraRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F44080-0x0000000180F44090 0x0000000180F44160-0x0000000180F44170
	protected float OriginalMainCameraFieldOfView { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F44050-0x0000000180F44060 0x0000000180F44130-0x0000000180F44140
	public string CutsceneName { get; } // 0x000000018036AC70-0x000000018036AC80 
	public string ApplicableSceneName { get; } // 0x0000000180F43F30-0x0000000180F43F60 
	public bool AutoPlayOnLevelLoad { get; } // 0x0000000180478590-0x00000001804785A0 
	public virtual bool IsPlayable { get; } // 0x0000000180F43F90-0x0000000180F43FB0 
	public CutscenePlaybackState PlaybackState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F44090-0x0000000180F440A0 0x0000000180F44170-0x0000000180F44180
	public bool IsInitialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001809336D0-0x00000001809336E0 0x00000001809337E0-0x00000001809337F0
	public int PlayCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A24E0-0x00000001804A24F0 0x00000001804A22D0-0x00000001804A22E0
	public float NormalizedPlaybackTime { get; } // 0x0000000180F43FB0-0x0000000180F44050 
	public float TotalTime { get; } // 0x0000000180F44120-0x0000000180F44130 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10373
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__88_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F53830-0x0000000180F53890
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Initialize>b__88_0(); // 0x0000000180F53210-0x0000000180F53280
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Play>d__94 : IEnumerator<object> // TypeDefIndex: 10374
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Play>d__94(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F51E30-0x0000000180F52090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F52090-0x0000000180F52860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InterpolateCameraToStartAnimationOffset>d__97 : IEnumerator<object> // TypeDefIndex: 10375
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		private Vector3 <cameraStartPosition>5__2; // 0x28
		private Quaternion <cameraStartRotation>5__3; // 0x34
		private Vector3 <cameraTargetPosition>5__4; // 0x44
		private Quaternion <cameraTargetRotation>5__5; // 0x50
		private float <totalTimeTaken>5__6; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InterpolateCameraToStartAnimationOffset>d__97(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F508A0-0x0000000180F51140
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F51140-0x0000000180F51190
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MovePlayerThroughPoints>d__98 : IEnumerator<object> // TypeDefIndex: 10376
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public List<Vector3> points; // 0x20
		public Cutscene <>4__this; // 0x28
		public float speed; // 0x30
		public float epsilon; // 0x34
		public Action finishedCallback; // 0x38
		private List<Vector3> <>7__wrap1; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MovePlayerThroughPoints>d__98(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000180F513E0-0x0000000180F51490
		private bool MoveNext(); // 0x0000000180F51190-0x0000000180F51390
		private void <>m__Finally1(); // 0x0000000180F51490-0x0000000180F514D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F51390-0x0000000180F513E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MovePlayerThroughPoints>d__99 : IEnumerator<object> // TypeDefIndex: 10377
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		[TupleElementNames] // 0x0000000180100520-0x00000001801005B0
		public List<ValueTuple<Vector3, float, float>> targets; // 0x20
		public Cutscene <>4__this; // 0x28
		public Action finishedCallback; // 0x30
		[TupleElementNames] // 0x0000000180100780-0x0000000180100810
		private List<ValueTuple<Vector3, float, float>> <>7__wrap1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MovePlayerThroughPoints>d__99(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000180F51710-0x0000000180F517C0
		private bool MoveNext(); // 0x0000000180F514D0-0x0000000180F516C0
		private void <>m__Finally1(); // 0x0000000180F517C0-0x0000000180F51800
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F516C0-0x0000000180F51710
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MovePlayerToPoint>d__100 : IEnumerator<object> // TypeDefIndex: 10378
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		public Vector3 point; // 0x28
		public float speed; // 0x34
		public float epsilon; // 0x38
		public Action finishedCallback; // 0x40
		private bool <hasPlayerReachedTarget>5__2; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MovePlayerToPoint>d__100(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F51800-0x0000000180F51DE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F51DE0-0x0000000180F51E30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BeginPlay>d__123 : IEnumerator<object> // TypeDefIndex: 10379
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BeginPlay>d__123(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4CD70-0x0000000180F4CF60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4CF60-0x0000000180F4D240
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FinalShot>d__124 : IEnumerator<object> // TypeDefIndex: 10380
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		private Camera <finalShotCamera>5__2; // 0x28
		private float <interpolationTime>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FinalShot>d__124(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4EA50-0x0000000180F4EFD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4EFD0-0x0000000180F4F020
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DisplaySkipCanvas>d__125 : IEnumerator<object> // TypeDefIndex: 10381
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		private CanvasGroup <canvasGroup>5__2; // 0x28
		private float <deltaMultiplier>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DisplaySkipCanvas>d__125(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4D580-0x0000000180F4D820
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4D820-0x0000000180F4D870
	}

	// Constructors
	public Cutscene(); // 0x0000000180F43DA0-0x0000000180F43EE0

	// Methods
	public void Initialize(); // 0x0000000180F41D70-0x0000000180F42010
	public bool TryPlay(bool force = false /* Metadata: 0x00781C3A */, Action<CutscenePlaybackState> cutsceneEndedCallback = null); // 0x0000000180F43880-0x0000000180F43960
	public bool TrySkip(bool force = false /* Metadata: 0x00781C3B */); // 0x0000000180F43A70-0x0000000180F43AA0
	public virtual bool TrySetNormalizedPlaybackTime(float time); // 0x0000000180F43960-0x0000000180F43A70
	public bool TryCancel(); // 0x0000000180F43840-0x0000000180F43880
	protected virtual void PrePlay(); // 0x0000000180F428C0-0x0000000180F42C30
	[IteratorStateMachine] // 0x00000001800FD1A0-0x00000001800FD1F0
	protected virtual IEnumerator Play(); // 0x0000000180F42660-0x0000000180F426C0
	protected virtual void UpdateCutscene(); // 0x0000000180F43B70-0x0000000180F43DA0
	protected virtual void PostPlay(); // 0x0000000180F426C0-0x0000000180F428C0
	[IteratorStateMachine] // 0x00000001800FD3A0-0x00000001800FD3F0
	protected IEnumerator InterpolateCameraToStartAnimationOffset(); // 0x0000000180F42010-0x0000000180F42070
	[IteratorStateMachine] // 0x00000001800FD5A0-0x00000001800FD5F0
	protected IEnumerator MovePlayerThroughPoints(List<Vector3> points, float speed = 8.5f /* Metadata: 0x00781C3C */, float epsilon = 0.5f /* Metadata: 0x00781C40 */, Action finishedCallback = null); // 0x0000000180F423D0-0x0000000180F42470
	[IteratorStateMachine] // 0x00000001800FD750-0x00000001800FD7A0
	protected IEnumerator MovePlayerThroughPoints([TupleElementNames] /* 0x00000001800FD910-0x00000001800FD9A0 */ List<ValueTuple<Vector3, float, float>> targets, Action finishedCallback = null); // 0x0000000180F42470-0x0000000180F424F0
	[IteratorStateMachine] // 0x00000001800FDFF0-0x00000001800FE040
	protected IEnumerator MovePlayerToPoint(Vector3 point, float speed = 8.5f /* Metadata: 0x00781C44 */, float epsilon = 0.5f /* Metadata: 0x00781C48 */, Action finishedCallback = null); // 0x0000000180F424F0-0x0000000180F425A0
	protected void SetCaptureFrameRateFromRollingAverage(); // 0x0000000180F43360-0x0000000180F434C0
	protected void EnableInput(); // 0x0000000180F416D0-0x0000000180F41750
	protected void DisableInput(); // 0x0000000180F41320-0x0000000180F413A0
	protected void ShowHUD(); // 0x0000000180F437A0-0x0000000180F43840
	protected void HideHUD(); // 0x0000000180F41CD0-0x0000000180F41D70
	protected void SetCursorEnabled(bool isEnabled); // 0x0000000180F434C0-0x0000000180F434D0
	protected void EnableCursorIfSkippable(); // 0x0000000180F41650-0x0000000180F41660
	protected void EnableAnimation(); // 0x0000000180F41400-0x0000000180F41650
	protected void DisableAnimation(); // 0x0000000180F41150-0x0000000180F412D0
	protected void EnableCutsceneAudio(); // 0x0000000180F41660-0x0000000180F416D0
	protected void DisableCutsceneAudio(); // 0x0000000180F412D0-0x0000000180F41320
	protected void RestoreMainCamera(); // 0x0000000180F42C30-0x0000000180F42CB0
	protected void SetupCutsceneCamera(); // 0x0000000180F43720-0x0000000180F437A0
	protected void RestoreNPCCulling(); // 0x0000000180F42CB0-0x0000000180F42D50
	protected void OverrideNPCCulling(); // 0x0000000180F425A0-0x0000000180F42660
	protected void SetFieldOfView(float fieldOfView); // 0x0000000180F434D0-0x0000000180F43720
	protected void SaveOriginalMainCameraProperties(); // 0x0000000180F432A0-0x0000000180F43360
	protected void SaveOriginalFieldsOfView(); // 0x0000000180F430E0-0x0000000180F432A0
	protected void RestoreOriginalFieldsOfView(); // 0x0000000180F42D50-0x0000000180F42FD0
	protected virtual void SaveLocalData(); // 0x0000000180F42FD0-0x0000000180F430E0
	protected virtual void LoadLocalData(); // 0x0000000180F422A0-0x0000000180F423D0
	protected bool IsLineSegmentIntersectingSphere(Vector3 lineStartPoint, Vector3 lineEndPoint, Vector3 sphereCenter, float radius); // 0x0000000180F42070-0x0000000180F422A0
	[IteratorStateMachine] // 0x00000001800FE150-0x00000001800FE1A0
	private IEnumerator BeginPlay(); // 0x0000000180F40F20-0x0000000180F40F80
	[IteratorStateMachine] // 0x00000001800FE390-0x00000001800FE3E0
	private IEnumerator FinalShot(); // 0x0000000180F41980-0x0000000180F419E0
	[IteratorStateMachine] // 0x00000001800FE4E0-0x00000001800FE530
	private IEnumerator DisplaySkipCanvas(); // 0x0000000180F413A0-0x0000000180F41400
	private void CleanupPostPlay(); // 0x0000000180F40F80-0x0000000180F41150
	private float GetTotalTime(); // 0x0000000180F419E0-0x0000000180F41CD0
	private void EnsureValidInspectorItems(); // 0x0000000180F41750-0x0000000180F41980
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Initialize>b__88_1(); // 0x0000000180F43AE0-0x0000000180F43B30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <InterpolateCameraToStartAnimationOffset>b__97_0(AnimationClip ac); // 0x0000000180F43B30-0x0000000180F43B70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <GetTotalTime>b__127_0(AnimationClip ac); // 0x0000000180F43AA0-0x0000000180F43AE0
}

