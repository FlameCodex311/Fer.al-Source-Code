/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	internal class ObservableEvent<T1, T2, M> : IObservable<M> // TypeDefIndex: 7865
	{
		// Fields
		private Action<Action<T1, T2>> _unregister;
		private List<IObserver<M>> _observers;
		private Func<T1, T2, M> _createCombinedModel;
	
		// Constructors
		public ObservableEvent(Action<Action<T1, T2>> register, Action<Action<T1, T2>> unregister, Func<T1, T2, M> createCombinedModel);
	
		// Methods
		~ObservableEvent();
		public IDisposable Subscribe(IObserver<M> observer);
		private void NotifyObservers(T1 value1, T2 value2);
	}
}
