/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Cutscene : MonoBehaviour // TypeDefIndex: 11862
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _cutsceneName; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _mainAnimationName; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _startTriggerName; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _endTriggerName; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _idleAnimationName; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _hasAnimationFile; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _hasSaveFile; // 0x49
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _isSkippable; // 0x4A
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _delayLevelNameDisplay; // 0x4B
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _autoPlayOnLevelLoad; // 0x4C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _playOnce; // 0x4D
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _alwaysForcePlayForDebugging; // 0x4E
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _isUsingFinalShot; // 0x4F
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _finalShotPosition; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _finalShotRotation; // 0x5C
	[Range] // 0x00000001801EAD10-0x00000001801EAD50
	[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
	private float _finalShotReturnInterpolationTime; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Camera _camera; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _skipCanvas; // 0x78
	[Range] // 0x0000000180244930-0x0000000180244970
	[SerializeField] // 0x0000000180244930-0x0000000180244970
	private float _cameraStartInterpolationAnimationOffset; // 0x80
	[Range] // 0x00000001801EAD10-0x00000001801EAD50
	[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
	private float _skipCanvasDelaySeconds; // 0x84
	[Range] // 0x0000000180290560-0x00000001802905A0
	[SerializeField] // 0x0000000180290560-0x00000001802905A0
	private float _skipCanvasFadeUpSeconds; // 0x88
	[Range] // 0x00000001802908A0-0x00000001802908E0
	[SerializeField] // 0x00000001802908A0-0x00000001802908E0
	private int _frameRateRollingAverageCount; // 0x8C
	private readonly IDictionary<Camera, float> _originalFieldsOfViewLookup; // 0x90
	private readonly List<float> _mostRecentDeltaTimes; // 0x98
	private float? _lastTimeSinceStartup; // 0xA0
	private Action<CutscenePlaybackState> _cutsceneEndedCallback; // 0xA8
	private bool _wasOriginalFieldsOfViewCaptured; // 0xB0
	private bool _isSkipRequested; // 0xB1
	private bool _isCancelRequested; // 0xB2
	private bool _isTestPlay; // 0xB3
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <OriginalMainCameraPosition>k__BackingField; // 0xB4
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Quaternion <OriginalMainCameraRotation>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OriginalMainCameraFieldOfView>k__BackingField; // 0xD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CutscenePlaybackState <PlaybackState>k__BackingField; // 0xD4
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsInitialized>k__BackingField; // 0xD8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <PlayCount>k__BackingField; // 0xDC

	// Properties
	protected string SaveFilePrefix { get; } // 0x0000000180556980-0x00000001805569C0 
	protected Camera Camera { get; } // 0x0000000180418980-0x0000000180418990 
	protected Animator Animator { get; } // 0x0000000180556750-0x00000001805567A0 
	protected Avatar_Local Player { get; } // 0x0000000180556940-0x0000000180556980 
	protected string MainAnimationName { get; } // 0x00000001803745B0-0x00000001803745C0 
	protected string StartTriggerName { get; } // 0x00000001803745C0-0x00000001803745D0 
	protected string EndTriggerName { get; } // 0x00000001803743D0-0x00000001803743E0 
	protected string IdleAnimationName { get; } // 0x00000001803C7290-0x00000001803C72A0 
	protected bool IsSkippable { get; } // 0x0000000180556840-0x0000000180556850 
	protected bool DelayLevelNameDisplay { get; } // 0x00000001805567E0-0x00000001805567F0 
	protected bool IsFinishCutsceneRequested { get; } // 0x00000001805567F0-0x0000000180556810 
	protected Vector3 OriginalMainCameraPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180556900-0x0000000180556920 0x00000001805569F0-0x0000000180556A10
	protected Quaternion OriginalMainCameraRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180556920-0x0000000180556930 0x0000000180556A10-0x0000000180556A20
	protected float OriginalMainCameraFieldOfView { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805568F0-0x0000000180556900 0x00000001805569E0-0x00000001805569F0
	public string CutsceneName { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public string ApplicableSceneName { get; } // 0x00000001805567A0-0x00000001805567D0 
	public bool AutoPlayOnLevelLoad { get; } // 0x00000001805567D0-0x00000001805567E0 
	public virtual bool IsPlayable { get; } // 0x0000000180556820-0x0000000180556840 
	public CutscenePlaybackState PlaybackState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180556930-0x0000000180556940 0x0000000180556A20-0x0000000180556A30
	public bool IsInitialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180556810-0x0000000180556820 0x00000001805569D0-0x00000001805569E0
	public int PlayCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180475720-0x0000000180475730 0x0000000180479300-0x0000000180479310
	public float NormalizedPlaybackTime { get; } // 0x0000000180556850-0x00000001805568F0 
	public float TotalTime { get; } // 0x00000001805569C0-0x00000001805569D0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11863
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__88_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180568980-0x0000000180568A40
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Initialize>b__88_0(); // 0x0000000180567D20-0x0000000180567D90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Play>d__94 : IEnumerator<object> // TypeDefIndex: 11864
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Play>d__94(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180566A90-0x0000000180566CF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180566CF0-0x00000001805673D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InterpolateCameraToStartAnimationOffset>d__97 : IEnumerator<object> // TypeDefIndex: 11865
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InterpolateCameraToStartAnimationOffset>d__97(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180565190-0x0000000180565A00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180565A00-0x0000000180565A50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MovePlayerThroughPoints>d__98 : IEnumerator<object> // TypeDefIndex: 11866
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MovePlayerThroughPoints>d__98(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180565FE0-0x0000000180566080
		private bool MoveNext(); // 0x0000000180565D90-0x0000000180565F90
		private void <>m__Finally1(); // 0x0000000180566080-0x00000001805660C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180565F90-0x0000000180565FE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MovePlayerThroughPoints>d__99 : IEnumerator<object> // TypeDefIndex: 11867
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		[TupleElementNames] // 0x00000001801CFE60-0x00000001801CFEF0
		public List<ValueTuple<Vector3, float, float>> targets; // 0x20
		public Cutscene <>4__this; // 0x28
		public Action finishedCallback; // 0x30
		[TupleElementNames] // 0x00000001801D0220-0x00000001801D02B0
		private List<ValueTuple<Vector3, float, float>> <>7__wrap1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MovePlayerThroughPoints>d__99(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180566310-0x00000001805663B0
		private bool MoveNext(); // 0x00000001805660C0-0x00000001805662C0
		private void <>m__Finally1(); // 0x00000001805663B0-0x00000001805663F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805662C0-0x0000000180566310
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MovePlayerThroughPoints>d__100 : IEnumerator<object> // TypeDefIndex: 11868
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		[TupleElementNames] // 0x00000001801D0E50-0x00000001801D0EF0
		public List<ValueTuple<Vector3, float, float, Action>> targets; // 0x20
		public Cutscene <>4__this; // 0x28
		public Action finalFinishedCallback; // 0x30
		[TupleElementNames] // 0x00000001801D11B0-0x00000001801D1250
		private List<ValueTuple<Vector3, float, float, Action>> <>7__wrap1; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MovePlayerThroughPoints>d__100(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180565CB0-0x0000000180565D50
		private bool MoveNext(); // 0x0000000180565A50-0x0000000180565C60
		private void <>m__Finally1(); // 0x0000000180565D50-0x0000000180565D90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180565C60-0x0000000180565CB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MovePlayerToPoint>d__101 : IEnumerator<object> // TypeDefIndex: 11869
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float speedPercent; // 0x20
		public Cutscene <>4__this; // 0x28
		public Vector3 point; // 0x30
		public float epsilon; // 0x3C
		public Action finishedCallback; // 0x40
		private bool <hasPlayerReachedTarget>5__2; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MovePlayerToPoint>d__101(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805663F0-0x0000000180566A40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180566A40-0x0000000180566A90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BeginPlay>d__124 : IEnumerator<object> // TypeDefIndex: 11870
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BeginPlay>d__124(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180563620-0x0000000180563810
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180563810-0x0000000180563AF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FinalShot>d__125 : IEnumerator<object> // TypeDefIndex: 11871
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		private Camera <finalShotCamera>5__2; // 0x28
		private float <interpolationTime>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FinalShot>d__125(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805643F0-0x0000000180564960
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180564960-0x00000001805649B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DisplaySkipCanvas>d__126 : IEnumerator<object> // TypeDefIndex: 11872
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Cutscene <>4__this; // 0x20
		private CanvasGroup <canvasGroup>5__2; // 0x28
		private float <deltaMultiplier>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DisplaySkipCanvas>d__126(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180563D90-0x0000000180564030
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180564030-0x0000000180564080
	}

	// Constructors
	public Cutscene(); // 0x0000000180556610-0x0000000180556750

	// Methods
	public void Initialize(); // 0x0000000180554450-0x00000001805546E0
	public bool TryPlay(bool force = false /* Metadata: 0x007B92E5 */, Action<CutscenePlaybackState> cutsceneEndedCallback = null); // 0x0000000180556100-0x00000001805561E0
	public bool TrySkip(bool force = false /* Metadata: 0x007B92E6 */); // 0x00000001805562F0-0x0000000180556320
	public virtual bool TrySetNormalizedPlaybackTime(float time); // 0x00000001805561E0-0x00000001805562F0
	public bool TryCancel(); // 0x00000001805560C0-0x0000000180556100
	protected virtual void PrePlay(); // 0x0000000180555160-0x00000001805554C0
	[IteratorStateMachine] // 0x0000000180294570-0x00000001802945C0
	protected virtual IEnumerator Play(); // 0x0000000180554DB0-0x0000000180554E10
	protected virtual void UpdateCutscene(); // 0x00000001805563F0-0x0000000180556610
	protected virtual void PostPlay(); // 0x0000000180554E10-0x0000000180555160
	[IteratorStateMachine] // 0x0000000180294770-0x00000001802947C0
	protected IEnumerator InterpolateCameraToStartAnimationOffset(); // 0x00000001805546E0-0x0000000180554740
	[IteratorStateMachine] // 0x0000000180294A60-0x0000000180294AB0
	protected IEnumerator MovePlayerThroughPoints(List<Vector3> points, float speed = 8.5f /* Metadata: 0x007B92E7 */, float epsilon = 0.5f /* Metadata: 0x007B92EB */, Action finishedCallback = null); // 0x0000000180554AA0-0x0000000180554B40
	[IteratorStateMachine] // 0x0000000180294FC0-0x0000000180295010
	protected IEnumerator MovePlayerThroughPoints([TupleElementNames] /* 0x0000000180295120-0x00000001802951B0 */ List<ValueTuple<Vector3, float, float>> targets, Action finishedCallback = null); // 0x0000000180554BC0-0x0000000180554C40
	[IteratorStateMachine] // 0x00000001802956F0-0x0000000180295740
	protected IEnumerator MovePlayerThroughPoints([TupleElementNames] /* 0x0000000180295C00-0x0000000180295CA0 */ List<ValueTuple<Vector3, float, float, Action>> targets, Action finalFinishedCallback = null); // 0x0000000180554B40-0x0000000180554BC0
	[IteratorStateMachine] // 0x0000000180295E90-0x0000000180295EE0
	protected IEnumerator MovePlayerToPoint(Vector3 point, float speedPercent = 0.85f /* Metadata: 0x007B92EF */, float epsilon = 0.5f /* Metadata: 0x007B92F3 */, Action finishedCallback = null); // 0x0000000180554C40-0x0000000180554CF0
	protected void SetCaptureFrameRateFromRollingAverage(); // 0x0000000180555BE0-0x0000000180555D40
	protected void EnableInput(); // 0x0000000180553DD0-0x0000000180553E50
	protected void DisableInput(); // 0x0000000180553A20-0x0000000180553AA0
	protected void ShowHUD(); // 0x0000000180556020-0x00000001805560C0
	protected void HideHUD(); // 0x00000001805543B0-0x0000000180554450
	protected void SetCursorEnabled(bool isEnabled); // 0x0000000180555D40-0x0000000180555D50
	protected void EnableCursorIfSkippable(); // 0x0000000180553D50-0x0000000180553D60
	protected void EnableAnimation(); // 0x0000000180553B00-0x0000000180553D50
	protected void DisableAnimation(); // 0x0000000180553860-0x00000001805539D0
	protected void EnableCutsceneAudio(); // 0x0000000180553D60-0x0000000180553DD0
	protected void DisableCutsceneAudio(); // 0x00000001805539D0-0x0000000180553A20
	protected void RestoreMainCamera(); // 0x00000001805554C0-0x0000000180555540
	protected void SetupCutsceneCamera(); // 0x0000000180555FA0-0x0000000180556020
	protected void RestoreNPCCulling(); // 0x0000000180555540-0x00000001805555E0
	protected void OverrideNPCCulling(); // 0x0000000180554CF0-0x0000000180554DB0
	protected void SetFieldOfView(float fieldOfView); // 0x0000000180555D50-0x0000000180555FA0
	protected void SaveOriginalMainCameraProperties(); // 0x0000000180555B20-0x0000000180555BE0
	protected void SaveOriginalFieldsOfView(); // 0x0000000180555960-0x0000000180555B20
	protected void RestoreOriginalFieldsOfView(); // 0x00000001805555E0-0x0000000180555850
	protected virtual void SaveLocalData(); // 0x0000000180555850-0x0000000180555960
	protected virtual void LoadLocalData(); // 0x0000000180554970-0x0000000180554AA0
	protected bool IsLineSegmentIntersectingSphere(Vector3 lineStartPoint, Vector3 lineEndPoint, Vector3 sphereCenter, float radius); // 0x0000000180554740-0x0000000180554970
	[IteratorStateMachine] // 0x0000000180295FC0-0x0000000180296010
	private IEnumerator BeginPlay(); // 0x0000000180553630-0x0000000180553690
	[IteratorStateMachine] // 0x0000000180296220-0x0000000180296270
	private IEnumerator FinalShot(); // 0x0000000180554070-0x00000001805540D0
	[IteratorStateMachine] // 0x0000000180296450-0x00000001802964A0
	private IEnumerator DisplaySkipCanvas(); // 0x0000000180553AA0-0x0000000180553B00
	private void CleanupPostPlay(); // 0x0000000180553690-0x0000000180553860
	private float GetTotalTime(); // 0x00000001805540D0-0x00000001805543B0
	private void EnsureValidInspectorItems(); // 0x0000000180553E50-0x0000000180554070
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Initialize>b__88_1(); // 0x0000000180556360-0x00000001805563B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <InterpolateCameraToStartAnimationOffset>b__97_0(AnimationClip ac); // 0x00000001805563B0-0x00000001805563F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <GetTotalTime>b__128_0(AnimationClip ac); // 0x0000000180556320-0x0000000180556360
}

