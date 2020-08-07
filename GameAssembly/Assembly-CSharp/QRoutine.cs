/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QRoutine // TypeDefIndex: 11240
{
	// Fields
	private string _name; // 0x10
	public QRoutineGroup parentGroup; // 0x18
	public QRoutineState state; // 0x20
	public bool noYield; // 0x24
	public QRoutineAddPriority addPriority; // 0x28
	public Action<QRoutine> startAction; // 0x30
	public Action<QRoutine> finishedAction; // 0x38
	public Action<QRoutine> canceledAction; // 0x40
	public IEnumerator routine; // 0x48
	private List<IEnumerator> _innerEnumeratorStack; // 0x50

	// Properties
	public string Name { get; set; } // 0x0000000180A321C0-0x0000000180A32200 0x0000000180379F20-0x0000000180379F30
	public string InnerRoutineName { get; } // 0x0000000180A32100-0x0000000180A321C0 
	public string RoutineName { get; } // 0x0000000180A32200-0x0000000180A32400 
	public bool Canceled { get; } // 0x0000000180A320E0-0x0000000180A320F0 
	public bool Finished { get; } // 0x0000000180A320F0-0x0000000180A32100 
	public bool Running { get; } // 0x0000000180A32400-0x0000000180A32420 

	// Nested types
	public class QRoutineResult<T> // TypeDefIndex: 11241
	{
		// Fields
		public T result;

		// Constructors
		public QRoutineResult(T inValue);
	}

	public class QRoutineWaitForSeconds // TypeDefIndex: 11242
	{
		// Fields
		public float seconds; // 0x10
		public float startTime; // 0x14

		// Properties
		public bool OverTime { get; } // 0x0000000180A30BA0-0x0000000180A30BD0 

		// Constructors
		public QRoutineWaitForSeconds(float inSeconds); // 0x0000000180A30B60-0x0000000180A30BA0
	}

	public class QRoutineNoYield // TypeDefIndex: 11243
	{
		// Constructors
		public QRoutineNoYield(); // 0x0000000180373240-0x0000000180373250
	}

	public class QRoutineWaitForFrames // TypeDefIndex: 11244
	{
		// Fields
		public int frames; // 0x10
		public int startFrame; // 0x14

		// Properties
		public bool OverTime { get; } // 0x0000000180A30B40-0x0000000180A30B60 

		// Constructors
		public QRoutineWaitForFrames(int inFrames); // 0x0000000180A30B10-0x0000000180A30B40
	}

	public class QRoutineWaitForTrue // TypeDefIndex: 11245
	{
		// Fields
		public Func<bool> func; // 0x10

		// Properties
		public bool True { get; } // 0x0000000180A30BD0-0x0000000180A30C20 

		// Constructors
		public QRoutineWaitForTrue(Func<bool> inFunc); // 0x0000000180400150-0x0000000180400180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 11246
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<QRoutine> <>t__builder; // 0x08
		public IEnumerator inRoutine; // 0x20
		public Action<QRoutine> inFinishedAction; // 0x28
		public Action<QRoutine> inCanceledAction; // 0x30
		private QRoutine <qRoutine>5__2; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800308E0-0x00000001800308F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800308F0-0x0000000180030940
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__3<T> : IAsyncStateMachine // TypeDefIndex: 11247
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
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
	private sealed class <Wait>d__45 : IEnumerator<object> // TypeDefIndex: 11248
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutine <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Wait>d__45(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A44A10-0x0000000180A44A60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A44A60-0x0000000180A44AB0
	}

	// Constructors
	public QRoutine(); // 0x0000000180A32080-0x0000000180A320E0

	// Methods
	public static QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A31040-0x0000000180A310D0
	[AsyncStateMachine] // 0x0000000180267910-0x0000000180267960
	public static Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A30F30-0x0000000180A31040
	public static QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[AsyncStateMachine] // 0x0000000180267BC0-0x0000000180267C10
	public static Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public static QRoutineNoYield NoYield(); // 0x0000000180A30E10-0x0000000180A30E60
	public static QRoutineResult<T> Result<T>(T inValue);
	public static QRoutineWaitForSeconds WaitForSeconds(float inSeconds); // 0x0000000180A31F50-0x0000000180A31FC0
	public static QRoutineWaitForFrames WaitForFrames(int inFrames); // 0x0000000180A31EF0-0x0000000180A31F50
	public static QRoutineWaitForTrue WaitForTrue(Func<bool> inFunc); // 0x0000000180A31FC0-0x0000000180A32020
	public static List<object> GetMethodParameterValues(Delegate method); // 0x0000000180A30D40-0x0000000180A30E10
	public static string PrettyRoutineName(string inRoutineName); // 0x0000000180A30E60-0x0000000180A30F30
	public void Start(); // 0x0000000180A310D0-0x0000000180A310F0
	public void Update(); // 0x0000000180A310F0-0x0000000180A31EF0
	public void Cancel(); // 0x0000000180A30C20-0x0000000180A30C80
	protected virtual bool IsResultYield(object inCurrent); // 0x0000000180380950-0x0000000180380960
	protected virtual void OnResultYield(object inCurrent); // 0x00000001803774A0-0x00000001803774B0
	public void Finish(); // 0x0000000180A30C80-0x0000000180A30D40
	[IteratorStateMachine] // 0x0000000180267CE0-0x0000000180267D30
	public IEnumerator Wait(); // 0x0000000180A32020-0x0000000180A32080
}

