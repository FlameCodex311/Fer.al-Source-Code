/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7577-7750

namespace UnityAtoms
{
	internal class ObservableEvent<T> : IObservable<T> // TypeDefIndex: 7698
	{
		// Fields
		private Action<Action<T>> _unregister;
		private List<IObserver<T>> _observers;
	
		// Constructors
		public ObservableEvent(Action<Action<T>> register, Action<Action<T>> unregister);
	
		// Methods
		~ObservableEvent();
		public IDisposable Subscribe(IObserver<T> observer);
		private void NotifyObservers(T value);
	}
}
