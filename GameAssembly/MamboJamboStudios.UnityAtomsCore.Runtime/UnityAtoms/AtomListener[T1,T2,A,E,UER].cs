/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	[EditorIcon] // 0x000000018023D5B0-0x000000018023D5E0
	public abstract class AtomListener<T1, T2, A, E, UER> : BaseAtomListener, IAtomListener<T1, T2> // TypeDefIndex: 7826
		where A : AtomAction<T1, T2>
		where E : AtomEvent<T1, T2>
		where UER : UnityEvent<T1, T2>
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private E _event;
		public UER _unityEventResponse;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<A> _actionResponses;
	
		// Properties
		public E Event { get; set; }
	
		// Constructors
		protected AtomListener();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public void OnEventRaised(T1 first, T2 second);
		public void DebugLog(T1 item1, T2 item2);
	}
}
