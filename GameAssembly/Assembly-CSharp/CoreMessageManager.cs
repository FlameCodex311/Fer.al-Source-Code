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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreMessageManager : CoreManagerBase<CoreMessageManager> // TypeDefIndex: 13467
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
	public static MessagePool MessagePool { get; } // 0x0000000181317F70-0x0000000181318060 
	public bool IsDispatching { get; } // 0x0000000181317F60-0x0000000181317F70 

	// Nested types
	public class RegisteredListener // TypeDefIndex: 13468
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
		public string RegisteredMethodName { get; } // 0x0000000181323ED0-0x0000000181323F00 
		public string RegisteredGameObjectName { get; } // 0x0000000181323EA0-0x0000000181323ED0 
		public int RegisteredGameObjectInstanceID { get; } // 0x00000001805F5E50-0x00000001805F5E60 
		public string TaggedEventName { get; } // 0x0000000181323F00-0x0000000181324650 

		// Constructors
		public RegisteredListener(string inEventID, string inTag, MethodInfo inMethod, object inTarget, string inMethodName, string inGameObjectName, int inTargetInstanceID); // 0x0000000181323E10-0x0000000181323EA0
		static RegisteredListener(); // 0x0000000181323DC0-0x0000000181323E10

		// Methods
		public void Invoke(IMessage inMessage); // 0x0000000181323C00-0x0000000181323DC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass47_0<T> // TypeDefIndex: 13469
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass49_0<T> // TypeDefIndex: 13470
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass51_0<T, T2> // TypeDefIndex: 13471
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass53_0<T, T2> // TypeDefIndex: 13472
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitMessage>d__57<T> : IAsyncStateMachine // TypeDefIndex: 13473
		where T : IMessage
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public int timeoutMs;
		private TaskAwaiter<T> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass58_0<T> // TypeDefIndex: 13474
		where T : IMessage
	{
		// Fields
		public T message;

		// Constructors
		public <>c__DisplayClass58_0();

		// Methods
		internal void <AwaitTaggedMessage>b__0(T m);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitTaggedMessage>d__58<T> : IAsyncStateMachine // TypeDefIndex: 13475
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitEitherMessage>d__59<T, T2> : IAsyncStateMachine // TypeDefIndex: 13476
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass60_0<T, T2> // TypeDefIndex: 13477
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitEitherTaggedMessage>d__60<T, T2> : IAsyncStateMachine // TypeDefIndex: 13478
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitAnyMessage>d__61 : IAsyncStateMachine // TypeDefIndex: 13479
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public List<string> inEventNames; // 0x20
		public List<Action<IMessage>> inCallbacks; // 0x28
		public int timeoutMs; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001802130B0-0x00000001802130C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 13480
	{
		// Fields
		public Dictionary<string, Action<IMessage>> messageToActionMap; // 0x10
		public List<string> inEventNames; // 0x18
		public Action<IMessage> callbackWithCleanup; // 0x20
		public List<string> inTags; // 0x28
		public bool done; // 0x30

		// Constructors
		public <>c__DisplayClass62_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <AwaitAnyTaggedMessage>b__0(IMessage m); // 0x000000018132A270-0x000000018132A3F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AwaitAnyTaggedMessage>d__62 : IAsyncStateMachine // TypeDefIndex: 13481
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
		private void MoveNext(); // 0x00000001802130C0-0x0000000180213100
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Constructors
	public CoreMessageManager(); // 0x0000000181317EB0-0x0000000181317F60
	static CoreMessageManager(); // 0x0000000181317E10-0x0000000181317EB0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1A80-0x00000001800C1AA0
	public static void FastPlayModeReset(); // 0x0000000181316370-0x00000001813163E0
	private static string GetFullActionName(object inAction); // 0x0000000181316BF0-0x0000000181316C20
	private static string GetActionTargetName(Action<IMessage> inAction); // 0x00000001813163E0-0x0000000181316500
	private static string GetTaggedName(string inEventID, string inTag); // 0x0000000181317090-0x0000000181317110
	public static string GetEventIDName(string inEventID); // 0x0000000181316500-0x0000000181316BF0
	private static string GetTypeName(Type inType); // 0x0000000181317110-0x0000000181317220
	public override void Init(); // 0x00000001813174C0-0x0000000181317740
	public void ClearListeners(); // 0x00000001813162F0-0x0000000181316370
	private RegisteredListener GetRegisteredListener(RegisteredListener inListener); // 0x0000000181316DC0-0x0000000181316E00
	private RegisteredListener GetRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag); // 0x0000000181316C20-0x0000000181316DC0
	private static RegisteredListener GetStaticRegisteredListener(RegisteredListener inListener); // 0x0000000181316E00-0x0000000181316EA0
	private static RegisteredListener GetStaticRegisteredListener(string inEventID, MethodInfo inMethod, object inTarget, string inTag); // 0x0000000181316EA0-0x0000000181317090
	private void AddRegisteredListener(RegisteredListener inListener); // 0x0000000181315890-0x0000000181315C00
	private static void AddStaticRegisteredListener(RegisteredListener inListener); // 0x0000000181315C80-0x00000001813160D0
	private void RemoveRegisteredListener(RegisteredListener inListener); // 0x0000000181317A40-0x0000000181317AC0
	private static void RemoveStaticRegisteredListener(RegisteredListener inListener); // 0x0000000181317AC0-0x0000000181317B70
	public static void AddListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x00783D35 */); // 0x0000000181315810-0x0000000181315890
	public static void AddListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x00783D39 */)
		where T : IMessage;
	public static void AddListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x00783D3D */)
		where T : IMessage;
	public static void AddStaticListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x00783D41 */); // 0x0000000181315C00-0x0000000181315C80
	public static void AddStaticListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x00783D45 */)
		where T : IMessage;
	public static void AddStaticListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x00783D49 */)
		where T : IMessage;
	public static void RemoveListener(string inEventID, Action<Message> inAction, string inTag = "" /* Metadata: 0x00783D4D */); // 0x00000001813177B0-0x0000000181317A40
	public static void RemoveListener<T>(Action<T> inAction, string inTag = "" /* Metadata: 0x00783D51 */)
		where T : IMessage;
	public static void RemoveListener<T>(string inEventID, Action<T> inAction, string inTag = "" /* Metadata: 0x00783D55 */)
		where T : IMessage;
	public static new void SendMessage(string inEventID); // 0x0000000181317D50-0x0000000181317E10
	public static void SendMessage<T>(T inMsg)
		where T : IMessage;
	public static void SendMessage<T>(string inEventID, T inMsg)
		where T : IMessage;
	public static void SendTaggedMessage<T>(T inMsg)
		where T : IMessage, ITaggedMessage;
	public static void SendTaggedMessage<T>(string inEventID, T inMsg)
		where T : IMessage, ITaggedMessage;
	private void HandleListenerQueues(); // 0x0000000181317220-0x00000001813174C0
	public override void MUpdate(); // 0x0000000181317740-0x00000001813177B0
	private void SendMessageToRegisteredListeners(IMessage inMessage, string tag = "" /* Metadata: 0x00783D59 */); // 0x0000000181317B70-0x0000000181317D50
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
	[AsyncStateMachine] // 0x0000000180165D20-0x0000000180165D70
	public static Task<T> AwaitMessage<T>(int timeoutMs = 10000 /* Metadata: 0x00783D5D */)
		where T : IMessage;
	[AsyncStateMachine] // 0x00000001801660C0-0x0000000180166110
	public static Task<T> AwaitTaggedMessage<T>(string tag, int timeoutMs = 10000 /* Metadata: 0x00783D61 */)
		where T : IMessage;
	[AsyncStateMachine] // 0x0000000180167600-0x0000000180167650
	public static Task AwaitEitherMessage<T, T2>(Action<T> inFirstCallback, Action<T2> inSecondCallback, int timeoutMs = 10000 /* Metadata: 0x00783D65 */)
		where T : IMessage
		where T2 : IMessage;
	[AsyncStateMachine] // 0x0000000180167970-0x00000001801679C0
	public static Task AwaitEitherTaggedMessage<T, T2>(string inFirstTag, Action<T> inFirstCallback, string inSecondTag, Action<T2> inSecondCallback, int timeoutMs = 10000 /* Metadata: 0x00783D69 */)
		where T : IMessage
		where T2 : IMessage;
	[AsyncStateMachine] // 0x0000000180167AF0-0x0000000180167B40
	public static Task AwaitAnyMessage(List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000 /* Metadata: 0x00783D6D */); // 0x00000001813160D0-0x00000001813161D0
	[AsyncStateMachine] // 0x0000000180167D60-0x0000000180167DB0
	public static Task AwaitAnyTaggedMessage(List<string> inTags, List<string> inEventNames, List<Action<IMessage>> inCallbacks, int timeoutMs = 10000 /* Metadata: 0x00783D71 */); // 0x00000001813161D0-0x00000001813162F0
}

