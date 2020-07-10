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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QRoutineGroup // TypeDefIndex: 13559
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
	public QRoutineGroup RootParentGroup { get; } // 0x00000001815F2030-0x00000001815F2060 
	public string Name { get; } // 0x000000018038B150-0x000000018038B160 
	public string FullPathName { get; } // 0x00000001815F1E00-0x00000001815F1E80 
	public List<QRoutine> RoutineQueue { get; } // 0x0000000180369B60-0x0000000180369B70 
	public List<QRoutineGroup> SubGroups { get; } // 0x0000000180397720-0x0000000180397730 
	public List<UnityEngine.Object> TrackedAssets { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public bool CanBeCanceledBeforeFinish { get; set; } // 0x0000000180478660-0x0000000180478670 0x00000001807009C0-0x00000001807009D0
	public bool CanTrackAssets { get; set; } // 0x00000001804785A0-0x00000001804785B0 0x00000001805460C0-0x00000001805460D0
	public bool HasTargetObject { get; } // 0x00000001805460A0-0x00000001805460B0 
	public GameObject TargetObject { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001815F2120-0x00000001815F21C0
	public string TargetName { get; } // 0x00000001803A27A0-0x00000001803A27B0 
	public bool TargetObjectDestroyed { get; } // 0x00000001815F2060-0x00000001815F2100 
	public bool Removed { get; set; } // 0x0000000180369BC0-0x0000000180369BD0 0x00000001803A27C0-0x00000001803A27D0
	public bool HasRoutines { get; } // 0x00000001815F1E80-0x00000001815F2030 
	public bool EmptyTimeoutHit { get; } // 0x00000001815F1DB0-0x00000001815F1E00 
	public int Priority { get; set; } // 0x00000001804D0650-0x00000001804D0660 0x00000001815F2100-0x00000001815F2120
	public int MaxRoutinesPerFrame { get; } // 0x00000001803DAC60-0x00000001803DAC70 
	public int CurrentRunningRoutineCount { get; } // 0x00000001815F1D80-0x00000001815F1DB0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13560
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<QRoutineGroup> <>9__50_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181607F90-0x0000000181607FF0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortSubGroupsByPriority>b__50_0(QRoutineGroup left, QRoutineGroup right); // 0x0000000181607F40-0x0000000181607F90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__78 : IAsyncStateMachine // TypeDefIndex: 13561
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
		private void MoveNext(); // 0x000000018022EDA0-0x000000018022EDB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018022EDB0-0x000000018022F9C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__79<T> : IAsyncStateMachine // TypeDefIndex: 13562
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartQRoutineAndWait>d__81 : IEnumerator<object> // TypeDefIndex: 13563
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineGroup <>4__this; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartQRoutineAndWait>d__81(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816062A0-0x0000000181606380
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181606380-0x00000001816063D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartQRoutineAndWait>d__82 : IEnumerator<object> // TypeDefIndex: 13564
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineGroup <>4__this; // 0x20
		public StartQRoutineOptions inOptions; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartQRoutineAndWait>d__82(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816063D0-0x00000001816064B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816064B0-0x0000000181606A40
	}

	// Constructors
	public QRoutineGroup(string inName, GameObject inTargetObject = null, int inMaxRoutinesPerFrame = -1 /* Metadata: 0x00783E64 */, int inEmptyTimeout = -1 /* Metadata: 0x00783E68 */); // 0x00000001815F1C20-0x00000001815F1D80
	static QRoutineGroup(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public void TrackAsset(UnityEngine.Object inAsset); // 0x00000001815F1850-0x00000001815F18E0
	public void SortSubGroupsByPriority(); // 0x00000001815F0B60-0x00000001815F0C70
	private void AddRoutineToQueue(QRoutine inQRoutine, QRoutineAddPriority inPriority); // 0x00000001815EF5B0-0x00000001815EF750
	public void Update(); // 0x00000001815F1BC0-0x00000001815F1C20
	public void CancelAllRoutines(); // 0x00000001815EFC00-0x00000001815EFD90
	public void DestroyTrackedAssets(); // 0x00000001815EFE30-0x00000001815F0060
	public void GetGroupRunningRoutineCount(ref int inRefCurrentRunningRoutineCount); // 0x00000001815F0250-0x00000001815F03A0
	public void UpdateTimedoutSubGroups(); // 0x00000001815F1A30-0x00000001815F1BC0
	public void UpdateRunningRoutines(); // 0x00000001815F18E0-0x00000001815F1A30
	public void StartQueuedRoutines(ref int inRefCurrentRunningRoutineCount, int inMaxRoutinesPerFrame); // 0x00000001815F16D0-0x00000001815F1850
	public void PruneNullAndFinishedRoutines(); // 0x00000001815F07F0-0x00000001815F0960
	public void AddSubGroup(QRoutineGroup inGroup); // 0x00000001815EFB10-0x00000001815EFC00
	public QRoutineGroup GetAutomaticSubGroupWithTarget(GameObject inTargetObject); // 0x00000001815F0060-0x00000001815F0250
	public QRoutineGroup GetSubGroupWithTarget(GameObject inTargetObject); // 0x00000001815F03A0-0x00000001815F0560
	public bool InsertSubGroupAtIndex(QRoutineGroup inGroup, int inIndex); // 0x00000001815F0560-0x00000001815F07F0
	public bool AddSubGroupBefore(QRoutineGroup inGroup, QRoutineGroup inOtherGroup); // 0x00000001815EF950-0x00000001815EFB10
	public bool AddSubGroupAfter(QRoutineGroup inGroup, QRoutineGroup inOtherGroup); // 0x00000001815EF750-0x00000001815EF950
	public bool RemoveSubGroup(QRoutineGroup inGroup); // 0x00000001815F0960-0x00000001815F0B60
	private static void ClearTempOptions(); // 0x00000001815EFD90-0x00000001815EFE30
	[AsyncStateMachine] // 0x00000001800C76C0-0x00000001800C7710
	public Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F0FB0-0x00000001815F10D0
	[AsyncStateMachine] // 0x00000001800C7AA0-0x00000001800C7AF0
	public Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public IEnumerator StartQActionAndWait(Action<QRoutine> inAction, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F0C70-0x00000001815F0DB0
	[IteratorStateMachine] // 0x00000001800C7E10-0x00000001800C7E60
	public IEnumerator StartQRoutineAndWait(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F0EA0-0x00000001815F0F30
	[IteratorStateMachine] // 0x00000001800C82A0-0x00000001800C82F0
	public IEnumerator StartQRoutineAndWait(StartQRoutineOptions inOptions); // 0x00000001815F0F30-0x00000001815F0FB0
	public QRoutine StartQAction(Action<QRoutine> inAction, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F0DB0-0x00000001815F0EA0
	public QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F10D0-0x00000001815F11C0
	public QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public QRoutine StartQRoutine(StartQRoutineOptions inOptions); // 0x00000001815F11C0-0x00000001815F16D0
	public QRoutine<T> StartQRoutine<T>(StartQRoutineOptions inOptions);
}

