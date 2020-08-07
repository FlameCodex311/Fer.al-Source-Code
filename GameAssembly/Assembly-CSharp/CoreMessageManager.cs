/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreMessageManager : CoreManagerBase<CoreMessageManager> // TypeDefIndex: 11138
{
	// Fields
	private static MessagePool _messagePool; // 0x00
	private static Dictionary<string, string> _eventIDNames; // 0x08
	private static Dictionary<Type, string> _typeNames; // 0x10
	private Dictionary<string, List<RegisteredListener>> _registeredListeners; // 0x60
	private static Dictionary<string, List<RegisteredListener>> _staticRegisteredListeners; // 0x18
	private List<RegisteredListener> _listenersToRegister; // 0x68
	private List<RegisteredListener> _listenersToUnregister; // 0x70
	private int _dispatchingStack; // 0x78

	// Properties
	public static MessagePool MessagePool { get; } // 0x0000000180A72430-0x0000000180A72520 
	public bool IsDispatching { get; } // 0x0000000180A72420-0x0000000180A72430 

	// Nested types
	public class RegisteredListener // TypeDefIndex: 11139
	{
		// Fields
		public string eventID; // 0x10
		public string tag; // 0x18
		public MethodInfo method; // 0x20
		public object target; // 0x28
		private string _registeredMethodName; // 0x30
		private string _registeredGameObjectName; // 0x38
		private int _registeredGameObjectInstanceID; // 0x40
		private string _taggedEventName; // 0x48
		private static object[] _invokeArgs; // 0x00

		// Properties
		public string RegisteredMethodName { get; } // 0x0000000180A74490-0x0000000180A744C0 
		public string RegisteredGameObjectName { get; } // 0x0000000180A74460-0x0000000180A74490 
		public int RegisteredGameObjectInstanceID { get; } // 0x00000001807C4280-0x00000001807C4290 
		public string TaggedEventName { get; } // 0x0000000180A744C0-0x0000000180A74BF0 

		// Constructors
		public RegisteredListener(string inEventID, string inTag, MethodInfo inMethod, object inTarget, string inMethodName, string inGameObjectName, int inTargetInstanceID); // 0x0000000180A743D0-0x0000000180A74460
		static RegisteredListener(); // 0x0000000180A74380-0x0000000180A743D0

		// Methods
		public void Invoke(IMessage inMessage); // 0x0000000180A741D0-0x0000000180A74380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass47_0<T> // TypeDefIndex: 11140
		where T : IMessage
	{
		// Fields
		public Action<T> inCallback;
		public Action<T> cb;
		public string inTag;

		// Constructors
		public <>c__DisplayClass47_0();

		// Methods
		internal void <OnTaggedMessage>b__0(T m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass49_0<T> // TypeDefIndex: 11141
		where T : IMessage
	{
		// Fields
		public Action<T> inCallback;
		public string inEventID;
		public Action<T> cb;
		public string inTag;

		// Constructors
		public <>c__DisplayClass49_0();

		// Methods
		internal void <OnMessageWithEventID>b__0(T m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass51_0<T, T2> // TypeDefIndex: 11142
		where T : IMessage
		where T2 : IMessage
	{
		// Fields
		public Action<T> inFirstCallback;
		public Action<T> cb1;
		public string inFirstTag;
		public Action<T2> cb2;
		public string inSecondTag;
		public Action<T2> inSecondCallback;

		// Constructors
		public <>c__DisplayClass51_0();

		// Methods
		internal void <OnEitherTaggedMessage>b__0(T m);
		internal void <OnEitherTaggedMessage>b__1(T2 m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass53_0<T, T2> // TypeDefIndex: 11143
		where T : IMessage
		where T2 : IMessage
	{
		// Fields
		public Action<T> inFirstCallback;
		public string inFirstEventID;
		public Action<T> cb1;
		public string inFirstTag;
		public string inSecondEventID;
		public Action<T2> cb2;
		public string inSecondTag;
		public Action<T2> inSecondCallback;

		// Constructors
		public <>c__DisplayClass53_0();

		// Methods
		internal void <OnEitherTaggedMessageWithEventID>b__0(T m);
		internal void <OnEitherTaggedMessageWithEventID>b__1(T2 m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitMessage>d__57<T> : IAsyncStateMachine // TypeDefIndex: 11144
		where T : IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public int timeoutMs;
		private TaskAwaiter<T> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass58_0<T> // TypeDefIndex: 11145
		where T : IMessage
	{
		// Fields
		public T message;

		// Constructors
		public <>c__DisplayClass58_0();

		// Methods
		internal void <AwaitTaggedMessage>b__0(T m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitTaggedMessage>d__58<T> : IAsyncStateMachine // TypeDefIndex: 11146
		where T : IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public string tag;
		public int timeoutMs;
		private <>c__DisplayClass58_0<T> <>8__1;
		private Action<T> <callback>5__2;
		private DateTime <timeoutTime>5__3;
		private TaskAwaiter <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitEitherMessage>d__59<T, T2> : IAsyncStateMachine // TypeDefIndex: 11147
		where T : IMessage
		where T2 : IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder <>t__builder;
		public Action<T> inFirstCallback;
		public Action<T2> inSecondCallback;
		public int timeoutMs;
		private TaskAwaiter <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass60_0<T, T2> // TypeDefIndex: 11148
		where T : IMessage
		where T2 : IMessage
	{
		// Fields
		public Action<T> inFirstCallback;
		public Action<T> cb1;
		public string inFirstTag;
		public Action<T2> cb2;
		public string inSecondTag;
		public bool done;
		public Action<T2> inSecondCallback;

		// Constructors
		public <>c__DisplayClass60_0();

		// Methods
		internal void <AwaitEitherTaggedMessage>b__0(T m);
		internal void <AwaitEitherTaggedMessage>b__1(T2 m);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitEitherTaggedMessage>d__60<T, T2> : IAsyncStateMachine // TypeDefIndex: 11149
		where T : IMessage
		where T2 : IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder <>t__builder;
		public Action<T> inFirstCallback;
		public string inFirstTag;
		public string inSecondTag;
		public Action<T2> inSecondCallback;
		public int timeoutMs;
		private <>c__DisplayClass60_0<T, T2> <>8__1;
		private DateTime <timeoutTime>5__2;
		private TaskAwaiter <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitAnyMessage>d__61 : IAsyncStateMachine // TypeDefIndex: 11150
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public List<string> inEventNames; // 0x20
		public List<Action<IMessage>> inCallbacks; // 0x28
		public int timeoutMs; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180030A00-0x0000000180030A10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 11151
	{
		// Fields
		public Dictionary<string, Action<IMessage>> messageToActionMap; // 0x10
		public List<string> inEventNames; // 0x18
		public Action<IMessage> callbackWithCleanup; // 0x20
		public List<string> inTags; // 0x28
		public bool done; // 0x30

		// Constructors
		public <>c__DisplayClass62_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <AwaitAnyTaggedMessage>b__0(IMessage m); // 0x0000000180A7BFC0-0x0000000180A7C130
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AwaitAnyTaggedMessage>d__62 : IAsyncStateMachine // TypeDefIndex: 11152
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public List<string> inEventNames; // 0x20
		public List<string> inTags; // 0x28
		public List<Action<IMessage>> inCallbacks; // 0x30
		public int timeoutMs; // 0x38
		private <>c__DisplayClass62_0 <>8__1; // 0x40
		private DateTime <timeoutTime>5__2; // 0x48
		private TaskAwaiter <>u__1; // 0x50

		// Methods
		private void MoveNext(); // 0x0000000180030A10-0x0000000180030B80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Constructors
	public CoreMessageManager(); // 0x0000000180A72370-0x0000000180A72420
	static CoreMessageManager(); // 0x0000000180A722D0-0x0000000180A72370

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
	public static void FastPlayModeReset(); // 0x0000000180A70890-0x0000000180A70900
	private static string GetFullActionName(object inAction); // 0x0000000180A710F0-0x0000000180A71120
	private static string GetActionTargetName(Action<IMessage> inAction); // 0x0000000180A70900-0x0000000180A70A20
	private static string GetTaggedName(string inEventID, string inTag); // 0x0000000180A71590-0x0000000180A71610
	public static string GetEventIDName(string inEventID); // 0x0000000180A70A20-0x0000000180A710F0
	private static string GetTypeName(Type inType); // 0x0000000180A71610-0x0000000180A71720
	public override void Init(); // 0x0000000180A719B0-0x0000000180A71C20
	public void ClearListeners(); // 0x0000000180A70810-0x0000000180A70890
	private RegisteredListener GetRegisteredListener(RegisteredListener inListener); // 0x0000000180A712C0-0x0000000180A71300
	private RegisteredListener GetRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag); // 0x0000000180A71120-0x0000000180A712C0
	private static RegisteredListener GetStaticRegisteredListener(RegisteredListener inListener); // 0x0000000180A71300-0x0000000180A713A0
	private static RegisteredListener GetStaticRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag); // 0x0000000180A713A0-0x0000000180A71590
	private void AddRegisteredListener(RegisteredListener inListener); // 0x0000000180A6FDF0-0x0000000180A70140
	private static void AddStaticRegisteredListener(RegisteredListener inListener); // 0x0000000180A701C0-0x0000000180A705F0
	private void RemoveRegisteredListener(RegisteredListener inListener); // 0x0000000180A71F10-0x0000000180A71F90
	private static void RemoveStaticRegisteredListener(RegisteredListener inListener); // 0x0000000180A71F90-0x0000000180A72030
	public static void AddListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x0077C7F4 */); // 0x0000000180A6FD70-0x0000000180A6FDF0
	public static void AddListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x0077C7F8 */)
		where T : IMessage;
	public static void AddListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x0077C7FC */)
		where T : IMessage;
	public static void AddStaticListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x0077C800 */); // 0x0000000180A70140-0x0000000180A701C0
	public static void AddStaticListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x0077C804 */)
		where T : IMessage;
	public static void AddStaticListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x0077C808 */)
		where T : IMessage;
	public static void RemoveListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x0077C80C */); // 0x0000000180A71C90-0x0000000180A71F10
	public static void RemoveListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x0077C810 */)
		where T : IMessage;
	public static void RemoveListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x0077C814 */)
		where T : IMessage;
	public static new void SendMessage(string inEventID); // 0x0000000180A72210-0x0000000180A722D0
	public static void SendMessage<T>(T inMsg)
		where T : IMessage;
	public static void SendMessage<T>(string inEventID, T inMsg)
		where T : IMessage;
	public static void SendTaggedMessage<T>(T inMsg)
		where T : IMessage, ITaggedMessage;
	public static void SendTaggedMessage<T>(string inEventID, T inMsg)
		where T : IMessage, ITaggedMessage;
	private void HandleListenerQueues(); // 0x0000000180A71720-0x0000000180A719B0
	public override void MUpdate(); // 0x0000000180A71C20-0x0000000180A71C90
	private void SendMessageToRegisteredListeners(IMessage inMessage, string tag = "" /* Metadata: 0x0077C818 */); // 0x0000000180A72030-0x0000000180A72210
	public static Action<T> OnMessage<T>(Action<T> inCallback)
		where T : IMessage;
	public static Action<T> OnTaggedMessage<T>(string inTag, Action<T> inCallback)
		where T : IMessage;
	public static Action<T> OnMessageWithEventID<T>(string inEventID, Action<T> inCallback)
		where T : IMessage;
	public static Action<T> OnMessageWithEventID<T>(string inEventID, string inTag, Action<T> inCallback)
		where T : IMessage;
	public static void OnEitherMessage<T, T2>(Action<T> inFirstCallback, Action<T2> inSecondCallback)
		where T : IMessage
		where T2 : IMessage;
	public static void OnEitherTaggedMessage<T, T2>(string inFirstTag, Action<T> inFirstCallback, string inSecondTag, Action<T2> inSecondCallback)
		where T : IMessage
		where T2 : IMessage;
	public static void OnEitherMessageWithEventID<T, T2>(string inFirstEventID, Action<T> inFirstCallback, string inSecondEventID, Action<T2> inSecondCallback)
		where T : IMessage
		where T2 : IMessage;
	public static void OnEitherTaggedMessageWithEventID<T, T2>(string inFirstEventID, string inFirstTag, Action<T> inFirstCallback, string inSecondEventID, string inSecondTag, Action<T2> inSecondCallback)
		where T : IMessage
		where T2 : IMessage;
	private string GetActionTargetName<T>(Action<T> inAction)
		where T : IMessage;
	private int GetActionTargetInstanceID<T>(Action<T> inAction)
		where T : IMessage;
	private string GetActionMethodName<T>(Action<T> inAction)
		where T : IMessage;
	[AsyncStateMachine] // 0x0000000180246AA0-0x0000000180246AF0
	public static Task<T> AwaitMessage<T>(int timeoutMs = 10000 /* Metadata: 0x0077C81C */)
		where T : IMessage;
	[AsyncStateMachine] // 0x00000001802470D0-0x0000000180247120
	public static Task<T> AwaitTaggedMessage<T>(string tag, int timeoutMs = 10000 /* Metadata: 0x0077C820 */)
		where T : IMessage;
	[AsyncStateMachine] // 0x0000000180247290-0x00000001802472E0
	public static Task AwaitEitherMessage<T, T2>(Action<T> inFirstCallback, Action<T2> inSecondCallback, int timeoutMs = 10000 /* Metadata: 0x0077C824 */)
		where T : IMessage
		where T2 : IMessage;
	[AsyncStateMachine] // 0x0000000180247450-0x00000001802474A0
	public static Task AwaitEitherTaggedMessage<T, T2>(string inFirstTag, Action<T> inFirstCallback, string inSecondTag, Action<T2> inSecondCallback, int timeoutMs = 10000 /* Metadata: 0x0077C828 */)
		where T : IMessage
		where T2 : IMessage;
	[AsyncStateMachine] // 0x0000000180247580-0x00000001802475D0
	public static Task AwaitAnyMessage(List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000 /* Metadata: 0x0077C82C */); // 0x0000000180A705F0-0x0000000180A706F0
	[AsyncStateMachine] // 0x0000000180247760-0x00000001802477B0
	public static Task AwaitAnyTaggedMessage(List<string> inTags, List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000 /* Metadata: 0x0077C830 */); // 0x0000000180A706F0-0x0000000180A70810
}

