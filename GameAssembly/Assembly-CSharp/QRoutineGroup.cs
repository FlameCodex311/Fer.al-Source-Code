/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QRoutineGroup // TypeDefIndex: 11230
{
	// Fields
	public QRoutineGroup parentGroup; // 0x10
	private string _name; // 0x18
	private string _fullPathName; // 0x20
	private List<QRoutine> _routineQueue; // 0x28
	public List<QRoutineGroup> _subGroups; // 0x30
	private List<UnityEngine.Object> _trackedAssets; // 0x38
	private bool _canBeCanceled; // 0x40
	private bool _canTrackAssets; // 0x41
	private bool _hasTargetObject; // 0x42
	private GameObject _targetObject; // 0x48
	private string _targetName; // 0x50
	private bool _removed; // 0x58
	private int _creationTime; // 0x5C
	private int _emptyTimeout; // 0x60
	private int _priority; // 0x64
	private int _maxRoutinesPerFrame; // 0x68
	private static StartQRoutineOptions _tempOptions; // 0x00

	// Properties
	public QRoutineGroup RootParentGroup { get; } // 0x0000000180A2FB30-0x0000000180A2FB60 
	public string Name { get; } // 0x0000000180372430-0x0000000180372440 
	public string FullPathName { get; } // 0x0000000180A2F900-0x0000000180A2F980 
	public List<QRoutine> RoutineQueue { get; } // 0x00000001803745B0-0x00000001803745C0 
	public List<QRoutineGroup> SubGroups { get; } // 0x00000001803745C0-0x00000001803745D0 
	public List<UnityEngine.Object> TrackedAssets { get; } // 0x00000001803743D0-0x00000001803743E0 
	public bool CanBeCanceledBeforeFinish { get; set; } // 0x0000000180455BA0-0x0000000180455BB0 0x0000000180455C20-0x0000000180455C30
	public bool CanTrackAssets { get; set; } // 0x000000018053DFB0-0x000000018053DFC0 0x0000000180A2FC00-0x0000000180A2FC10
	public bool HasTargetObject { get; } // 0x0000000180A2FB20-0x0000000180A2FB30 
	public GameObject TargetObject { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x0000000180A2FC30-0x0000000180A2FCD0
	public string TargetName { get; } // 0x0000000180378320-0x0000000180378330 
	public bool TargetObjectDestroyed { get; } // 0x0000000180A2FB60-0x0000000180A2FC00 
	public bool Removed { get; set; } // 0x0000000180379F00-0x0000000180379F10 0x00000001805FC5A0-0x00000001805FC5B0
	public bool HasRoutines { get; } // 0x0000000180A2F980-0x0000000180A2FB20 
	public bool EmptyTimeoutHit { get; } // 0x0000000180A2F8B0-0x0000000180A2F900 
	public int Priority { get; set; } // 0x00000001804C5F20-0x00000001804C5F30 0x0000000180A2FC10-0x0000000180A2FC30
	public int MaxRoutinesPerFrame { get; } // 0x00000001806F4980-0x00000001806F4990 
	public int CurrentRunningRoutineCount { get; } // 0x0000000180A2F880-0x0000000180A2F8B0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11231
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<QRoutineGroup> <>9__50_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180A44460-0x0000000180A444C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortSubGroupsByPriority>b__50_0(QRoutineGroup left, QRoutineGroup right); // 0x0000000180A44410-0x0000000180A44460
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__78 : IAsyncStateMachine // TypeDefIndex: 11232
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<QRoutine> <>t__builder; // 0x08
		public QRoutineGroup <>4__this; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38
		private QRoutine <qRoutine>5__2; // 0x40
		private TaskAwaiter <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800309A0-0x00000001800309B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800309B0-0x0000000180030A00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__79<T> : IAsyncStateMachine // TypeDefIndex: 11233
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public QRoutineGroup <>4__this;
		public IEnumerator inRoutine;
		public Action<QRoutine> inFinishedAction;
		public Action<QRoutine> inCanceledAction;
		private QRoutine<T> <qRoutine>5__2;
		private TaskAwaiter <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartQRoutineAndWait>d__81 : IEnumerator<object> // TypeDefIndex: 11234
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineGroup <>4__this; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartQRoutineAndWait>d__81(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A42CB0-0x0000000180A42D80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A42D80-0x0000000180A42DD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartQRoutineAndWait>d__82 : IEnumerator<object> // TypeDefIndex: 11235
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineGroup <>4__this; // 0x20
		public StartQRoutineOptions inOptions; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartQRoutineAndWait>d__82(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A42DD0-0x0000000180A42EB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A42EB0-0x0000000180A43440
	}

	// Constructors
	public QRoutineGroup(string inName, GameObject inTargetObject = null, int inMaxRoutinesPerFrame = -1 /* Metadata: 0x0077C923 */, int inEmptyTimeout = -1 /* Metadata: 0x0077C927 */); // 0x0000000180A2F720-0x0000000180A2F880
	static QRoutineGroup(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public void TrackAsset(UnityEngine.Object inAsset); // 0x0000000180A2F370-0x0000000180A2F400
	public void SortSubGroupsByPriority(); // 0x0000000180A2E6A0-0x0000000180A2E7B0
	private void AddRoutineToQueue(QRoutine inQRoutine, QRoutineAddPriority inPriority); // 0x0000000180A2D180-0x0000000180A2D310
	public void Update(); // 0x0000000180A2F6C0-0x0000000180A2F720
	public void CancelAllRoutines(); // 0x0000000180A2D7B0-0x0000000180A2D930
	public void DestroyTrackedAssets(); // 0x0000000180A2D9D0-0x0000000180A2DC00
	public void GetGroupRunningRoutineCount(ref int inRefCurrentRunningRoutineCount); // 0x0000000180A2DDE0-0x0000000180A2DF20
	public void UpdateTimedoutSubGroups(); // 0x0000000180A2F540-0x0000000180A2F6C0
	public void UpdateRunningRoutines(); // 0x0000000180A2F400-0x0000000180A2F540
	public void StartQueuedRoutines(ref int inRefCurrentRunningRoutineCount, int inMaxRoutinesPerFrame); // 0x0000000180A2F1F0-0x0000000180A2F370
	public void PruneNullAndFinishedRoutines(); // 0x0000000180A2E340-0x0000000180A2E4B0
	public void AddSubGroup(QRoutineGroup inGroup); // 0x0000000180A2D6C0-0x0000000180A2D7B0
	public QRoutineGroup GetAutomaticSubGroupWithTarget(GameObject inTargetObject); // 0x0000000180A2DC00-0x0000000180A2DDE0
	public QRoutineGroup GetSubGroupWithTarget(GameObject inTargetObject); // 0x0000000180A2DF20-0x0000000180A2E0D0
	public bool InsertSubGroupAtIndex(QRoutineGroup inGroup, int inIndex); // 0x0000000180A2E0D0-0x0000000180A2E340
	public bool AddSubGroupBefore(QRoutineGroup inGroup, QRoutineGroup inOtherGroup); // 0x0000000180A2D500-0x0000000180A2D6C0
	public bool AddSubGroupAfter(QRoutineGroup inGroup, QRoutineGroup inOtherGroup); // 0x0000000180A2D310-0x0000000180A2D500
	public bool RemoveSubGroup(QRoutineGroup inGroup); // 0x0000000180A2E4B0-0x0000000180A2E6A0
	private static void ClearTempOptions(); // 0x0000000180A2D930-0x0000000180A2D9D0
	[AsyncStateMachine] // 0x0000000180264890-0x00000001802648E0
	public Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2EAF0-0x0000000180A2EC10
	[AsyncStateMachine] // 0x0000000180264B90-0x0000000180264BE0
	public Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public IEnumerator StartQActionAndWait(Action<QRoutine> inAction, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2E7B0-0x0000000180A2E8F0
	[IteratorStateMachine] // 0x0000000180264ED0-0x0000000180264F20
	public IEnumerator StartQRoutineAndWait(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2E9E0-0x0000000180A2EA70
	[IteratorStateMachine] // 0x0000000180266350-0x00000001802663A0
	public IEnumerator StartQRoutineAndWait(StartQRoutineOptions inOptions); // 0x0000000180A2EA70-0x0000000180A2EAF0
	public QRoutine StartQAction(Action<QRoutine> inAction, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2E8F0-0x0000000180A2E9E0
	public QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2EC10-0x0000000180A2ED00
	public QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public QRoutine StartQRoutine(StartQRoutineOptions inOptions); // 0x0000000180A2ED00-0x0000000180A2F1F0
	public QRoutine<T> StartQRoutine<T>(StartQRoutineOptions inOptions);
}

