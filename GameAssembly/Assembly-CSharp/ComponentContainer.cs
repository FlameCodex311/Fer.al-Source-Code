/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ComponentContainer // TypeDefIndex: 13367
{
	// Fields
	private Dictionary<Type, List<ComponentBase>> _components; // 0x10
	private bool _isEnumerating; // 0x18

	// Properties
	public IEnumerable<ComponentBase> All { [IteratorStateMachine] /* 0x0000000180130260-0x00000001801302B0 */ get; } // 0x0000000181472C30-0x0000000181472CA0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <get_All>d__3 : IEnumerable<ComponentBase>, IEnumerator<ComponentBase> // TypeDefIndex: 13368
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
		ComponentBase IEnumerator<ComponentBase>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <get_All>d__3(int <>1__state); // 0x000000018094DE20-0x000000018094DE50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001814847D0-0x0000000181484880
		private bool MoveNext(); // 0x0000000181484500-0x00000001814846E0
		private void <>m__Finally1(); // 0x0000000181484880-0x00000001814848C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181484780-0x00000001814847D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<ComponentBase> IEnumerable<ComponentBase>.GetEnumerator(); // 0x00000001814846E0-0x0000000181484780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001814846E0-0x0000000181484780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AllOf>d__15<T> : IEnumerator<T> // TypeDefIndex: 13369
		where T : class
	{
		// Fields
		private int <>1__state;
		private T <>2__current;
		public ComponentContainer <>4__this;
		private IEnumerator<ComponentBase> <>7__wrap1;

		// Properties
		T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AllOf>d__15(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		private void <>m__Finally1();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	// Constructors
	public ComponentContainer(); // 0x0000000181472BD0-0x0000000181472C30

	// Methods
	private List<ComponentBase> GetComponentListForType<T>();
	private List<ComponentBase> GetComponentListForType(Type inType); // 0x0000000181472700-0x00000001814727C0
	public ComponentBase AddComponent(Type ofType); // 0x0000000181472590-0x0000000181472700
	public ComponentBase GetComponent(Type ofType); // 0x00000001814727C0-0x0000000181472BD0
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
	[IteratorStateMachine] // 0x00000001801308F0-0x0000000180130940
	public IEnumerator<T> AllOf<T>()
		where T : class;
}

