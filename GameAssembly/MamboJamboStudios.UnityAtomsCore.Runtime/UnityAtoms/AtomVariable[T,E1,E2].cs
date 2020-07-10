/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7577-7750

namespace UnityAtoms
{
	[EditorIcon] // 0x00000001800E2E40-0x00000001800E2E70
	public abstract class AtomVariable<T, E1, E2> : AtomBaseVariable<T> // TypeDefIndex: 7738
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<T, T>
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private T _initialValue;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private T _oldValue;
		public E1 Changed;
		public E2 ChangedWithHistory;
	
		// Properties
		public override T Value { get; set; }
		public T InitialValue { get; }
		public T OldValue { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7739
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
		public sealed override void Reset(bool shouldTriggerEvents = false /* Metadata: 0x00742199 */);
		public bool SetValue(T newValue);
		public bool SetValue(AtomVariable<T, E1, E2> variable);
		public IObservable<T> ObserveChange();
		public IObservable<ValueTuple<T, T>> ObserveChangeWithHistory();
	}
}
