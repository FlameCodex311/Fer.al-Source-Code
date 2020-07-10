/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QRoutine // TypeDefIndex: 13569
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
	public string Name { get; set; } // 0x00000001815F4740-0x00000001815F4780 0x000000018036B1E0-0x000000018036B1F0
	public string InnerRoutineName { get; } // 0x00000001815F4670-0x00000001815F4740 
	public string RoutineName { get; } // 0x00000001815F4780-0x00000001815F4990 
	public bool Canceled { get; } // 0x00000001815F4660-0x00000001815F4670 
	public bool Finished { get; } // 0x00000001806D5E00-0x00000001806D5E10 
	public bool Running { get; } // 0x00000001815F4990-0x00000001815F49B0 

	// Nested types
	public class QRoutineResult<T> // TypeDefIndex: 13570
	{
		// Fields
		public T result;

		// Constructors
		public QRoutineResult(T inValue);
	}

	public class QRoutineWaitForSeconds // TypeDefIndex: 13571
	{
		// Fields
		public float seconds; // 0x10
		public float startTime; // 0x14

		// Properties
		public bool OverTime { get; } // 0x00000001815F30B0-0x00000001815F30E0 

		// Constructors
		public QRoutineWaitForSeconds(float inSeconds); // 0x00000001815F3070-0x00000001815F30B0
	}

	public class QRoutineNoYield // TypeDefIndex: 13572
	{
		// Constructors
		public QRoutineNoYield(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public class QRoutineWaitForFrames // TypeDefIndex: 13573
	{
		// Fields
		public int frames; // 0x10
		public int startFrame; // 0x14

		// Properties
		public bool OverTime { get; } // 0x00000001815F3050-0x00000001815F3070 

		// Constructors
		public QRoutineWaitForFrames(int inFrames); // 0x00000001815F3020-0x00000001815F3050
	}

	public class QRoutineWaitForTrue // TypeDefIndex: 13574
	{
		// Fields
		public Func<bool> func; // 0x10

		// Properties
		public bool True { get; } // 0x00000001815F30E0-0x00000001815F3130 

		// Constructors
		public QRoutineWaitForTrue(Func<bool> inFunc); // 0x000000018037D3F0-0x000000018037D420
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 13575
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
		private void MoveNext(); // 0x000000018022ECE0-0x000000018022ECF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018022ECF0-0x000000018022ED40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__3<T> : IAsyncStateMachine // TypeDefIndex: 13576
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Wait>d__45 : IEnumerator<object> // TypeDefIndex: 13577
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutine <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Wait>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816085D0-0x0000000181608620
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181608620-0x0000000181608670
	}

	// Constructors
	public QRoutine(); // 0x00000001815F4600-0x00000001815F4660

	// Methods
	public static QRoutine StartQRoutine(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F3560-0x00000001815F35F0
	[AsyncStateMachine] // 0x00000001800CA9F0-0x00000001800CAA40
	public static Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815F3450-0x00000001815F3560
	public static QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[AsyncStateMachine] // 0x00000001800CAC70-0x00000001800CACC0
	public static Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	public static QRoutineNoYield NoYield(); // 0x00000001815F3330-0x00000001815F3380
	public static QRoutineResult<T> Result<T>(T inValue);
	public static QRoutineWaitForSeconds WaitForSeconds(float inSeconds); // 0x00000001815F44D0-0x00000001815F4540
	public static QRoutineWaitForFrames WaitForFrames(int inFrames); // 0x00000001815F4470-0x00000001815F44D0
	public static QRoutineWaitForTrue WaitForTrue(Func<bool> inFunc); // 0x00000001815F4540-0x00000001815F45A0
	public static List<object> GetMethodParameterValues(Delegate method); // 0x00000001815F3250-0x00000001815F3330
	public static string PrettyRoutineName(string inRoutineName); // 0x00000001815F3380-0x00000001815F3450
	public void Start(); // 0x00000001815F35F0-0x00000001815F3610
	public void Update(); // 0x00000001815F3610-0x00000001815F4470
	public void Cancel(); // 0x00000001815F3130-0x00000001815F3190
	protected virtual bool IsResultYield(object inCurrent); // 0x00000001803C28F0-0x00000001803C2900
	protected virtual void OnResultYield(object inCurrent); // 0x00000001803581E0-0x00000001803581F0
	public void Finish(); // 0x00000001815F3190-0x00000001815F3250
	[IteratorStateMachine] // 0x00000001800CB0C0-0x00000001800CB110
	public IEnumerator Wait(); // 0x00000001815F45A0-0x00000001815F4600
}

