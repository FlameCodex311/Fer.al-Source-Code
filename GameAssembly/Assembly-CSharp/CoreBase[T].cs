/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class CoreBase<T> : CoreBase // TypeDefIndex: 11044
	where T : CoreBase<T>
{
	// Fields
	[NonSerialized]
	public string debugDateString;
	[NonSerialized]
	public double debugAddedSeconds;
	[NonSerialized]
	public string debugTimeString;
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static bool <IsResetting>k__BackingField;
	private static bool _quitting;
	protected static T _instance;
	protected static bool _loaded;
	[NonSerialized]
	public string currentSplashProgressName;
	[NonSerialized]
	public int currentSplashProgressNumber;
	private static FieldInfo[] _managerFields;
	private static List<GameObject> _doNotDestroyOnLoadList;

	// Properties
	public static bool DebugVerbose { get; set; }
	public virtual bool DestroyOnLoad { get; }
	public static bool IsResetting { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; }
	public static bool Quitting { get; }
	public static T instance { get; }
	public static bool Loaded { get; }
	private static FieldInfo[] ManagerFields { get; }
	private static string DebugVerboseName { get; }

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetManagerList>d__27 : IEnumerable<ManagerBase>, IEnumerator<ManagerBase> // TypeDefIndex: 11045
	{
		// Fields
		private int <>1__state;
		private ManagerBase <>2__current;
		private int <>l__initialThreadId;
		public CoreBase<T> <>4__this;
		private int <n>5__2;

		// Properties
		ManagerBase IEnumerator<ManagerBase>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetManagerList>d__27(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator<ManagerBase> IEnumerable<ManagerBase>.GetEnumerator();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator IEnumerable.GetEnumerator();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitializeManagers>d__34 : IEnumerator<object> // TypeDefIndex: 11046
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public CoreBase<T> <>4__this;
		private bool <wasLoaded>5__2;
		private List<ManagerBase> <initedManagers>5__3;
		private IEnumerator<ManagerBase> <>7__wrap3;
		private ManagerBase <nManager>5__5;
		private List<ManagerBase> <>7__wrap5;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitializeManagers>d__34(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		private void <>m__Finally1();
		private void <>m__Finally2();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Constructors
	protected CoreBase();
	static CoreBase();

	// Methods
	private FieldInfo GetManagerField(ManagerBase inManager);
	[IteratorStateMachine] // 0x0000000180211140-0x0000000180211190
	public IEnumerable<ManagerBase> GetManagerList();
	public void AddSceneManagerAndInit(ManagerBase inManager);
	public void RemoveSceneManagerAndDeinit(ManagerBase inManager);
	public static ManagerBase GetManagerInstance(ManagerBase inManager);
	public static ManagerBase GetManagerInstance(Type inType);
	private void Awake();
	protected virtual void MAwake();
	[IteratorStateMachine] // 0x00000001802113F0-0x0000000180211440
	private IEnumerator InitializeManagers();
	protected virtual void OnManagersInitialized();
	public void OnApplicationQuit();
	public void DeinitManagers();
	private void OnDestroy();
	protected static void Log(string inLog);
	protected static void LogError(string inLog);
	public static void RegisterDoNotDestroyOnLoadObject(GameObject inObj);
	public static void UnregisterDoNotDestroyOnLoadObject(GameObject inObj);
	public static void DestroyDoNotDestroyOnLoadList();
}

