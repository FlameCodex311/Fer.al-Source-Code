/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7577-7750

namespace UnityAtoms
{
	[EditorIcon] // 0x00000001800D45F0-0x00000001800D4620
	public abstract class AtomEvent<T> : AtomEvent // TypeDefIndex: 7629
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<T> OnEvent;
	
		// Events
		public event Action<T> OnEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		protected AtomEvent();
	
		// Methods
		public void Raise(T item);
		public void Register(Action<T> del);
		public void Unregister(Action<T> del);
		public void RegisterListener(IAtomListener<T> listener);
		public void UnregisterListener(IAtomListener<T> listener);
		public IObservable<T> Observe();
		public override void OnAfterDeserialize();
	}
}
