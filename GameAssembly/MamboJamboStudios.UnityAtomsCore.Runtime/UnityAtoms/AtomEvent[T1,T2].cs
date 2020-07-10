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
	public abstract class AtomEvent<T1, T2> : AtomEvent // TypeDefIndex: 7630
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<T1, T2> OnEvent;
	
		// Events
		public event Action<T1, T2> OnEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Constructors
		protected AtomEvent();
	
		// Methods
		public void Raise(T1 item1, T2 item2);
		public void Register(Action<T1, T2> del);
		public void Unregister(Action<T1, T2> del);
		public void RegisterListener(IAtomListener<T1, T2> listener);
		public void UnregisterListener(IAtomListener<T1, T2> listener);
		public IObservable<M> Observe<M>(Func<T1, T2, M> resultSelector);
		public override void OnAfterDeserialize();
	}
}
