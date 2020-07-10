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
	internal class ObservableUnsubscriber<T> : IDisposable // TypeDefIndex: 7700
	{
		// Fields
		private List<IObserver<T>> _observers;
		private IObserver<T> _observer;
	
		// Constructors
		public ObservableUnsubscriber(List<IObserver<T>> observers, IObserver<T> observer);
	
		// Methods
		public void Dispose();
	}
}
