/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	[EditorIcon] // 0x0000000180244E10-0x0000000180244E40
	public abstract class AtomVariable<T, E1, E2> : AtomBaseVariable<T> // TypeDefIndex: 7904
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<T, T>
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _initialValue;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _oldValue;
		public E1 Changed;
		public E2 ChangedWithHistory;
	
		// Properties
		public override T Value { get; set; }
		public T InitialValue { get; }
		public T OldValue { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7905
		{
			// Fields
			public static readonly <>c<T, E1, E2> <>9;
			public static Func<T, T, ValueTuple<T, T>> <>9__17_0;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal ValueTuple<T, T> <ObserveChangeWithHistory>b__17_0(T n, T o);
		}
	
		// Constructors
		protected AtomVariable();
	
		// Methods
		protected abstract bool AreEqual(T first, T second);
		private void OnEnable();
		public sealed override void Reset(bool shouldTriggerEvents = false /* Metadata: 0x00776E87 */);
		public bool SetValue(T newValue);
		public bool SetValue(AtomVariable<T, E1, E2> variable);
		public IObservable<T> ObserveChange();
		public IObservable<ValueTuple<T, T>> ObserveChangeWithHistory();
	}
}
