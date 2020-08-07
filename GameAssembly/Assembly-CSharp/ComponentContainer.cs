/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ComponentContainer // TypeDefIndex: 11038
{
	// Fields
	private Dictionary<Type, List<ComponentBase>> _components; // 0x10
	private bool _isEnumerating; // 0x18

	// Properties
	public IEnumerable<ComponentBase> All { [IteratorStateMachine] /* 0x000000018020C4B0-0x000000018020C500 */ get; } // 0x000000018077E320-0x000000018077E390 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <get_All>d__3 : IEnumerable<ComponentBase>, IEnumerator<ComponentBase> // TypeDefIndex: 11039
	{
		// Fields
		private int <>1__state; // 0x10
		private ComponentBase <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		public ComponentContainer <>4__this; // 0x28
		private Dictionary<Type, List<ComponentBase>> <>7__wrap1; // 0x30
		private KeyValuePair<Type, List<ComponentBase>> <kvp>5__3; // 0x58
		private int <i>5__4; // 0x68

		// Properties
		ComponentBase IEnumerator<ComponentBase>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <get_All>d__3(int <>1__state); // 0x00000001806301B0-0x00000001806301E0

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180787530-0x00000001807875D0
		private bool MoveNext(); // 0x0000000180787270-0x0000000180787440
		private void <>m__Finally1(); // 0x00000001807875D0-0x0000000180787610
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807874E0-0x0000000180787530
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator<ComponentBase> IEnumerable<ComponentBase>.GetEnumerator(); // 0x0000000180787440-0x00000001807874E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180787440-0x00000001807874E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AllOf>d__15<T> : IEnumerator<T> // TypeDefIndex: 11040
		where T : class
	{
		// Fields
		private int <>1__state;
		private T <>2__current;
		public ComponentContainer <>4__this;
		private IEnumerator<ComponentBase> <>7__wrap1;

		// Properties
		T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AllOf>d__15(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		private void <>m__Finally1();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Constructors
	public ComponentContainer(); // 0x000000018077E2C0-0x000000018077E320

	// Methods
	private List<ComponentBase> GetComponentListForType<T>();
	private List<ComponentBase> GetComponentListForType(Type inType); // 0x000000018077DE00-0x000000018077DEC0
	public ComponentBase AddComponent(Type ofType); // 0x000000018077DC90-0x000000018077DE00
	public ComponentBase GetComponent(Type ofType); // 0x000000018077DEC0-0x000000018077E2C0
	public T AddComponent<T>()
		where T : ComponentBase;
	public T AddComponent<T>(T inComponent)
		where T : ComponentBase;
	public T AddComponentByTypeof<T>(T inComponent)
		where T : ComponentBase;
	public T GetComponent<T>()
		where T : ComponentBase;
	public bool HasComponent<T>()
		where T : ComponentBase;
	public void RemoveComponent<T>()
		where T : ComponentBase;
	public void Foreach<T>(Action<T> a)
		where T : class;
	[IteratorStateMachine] // 0x000000018020C7D0-0x000000018020C820
	public IEnumerator<T> AllOf<T>()
		where T : class;
}

