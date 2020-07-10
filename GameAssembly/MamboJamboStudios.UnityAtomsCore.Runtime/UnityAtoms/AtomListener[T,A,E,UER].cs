/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7577-7750

namespace UnityAtoms
{
	[EditorIcon] // 0x00000001800DBEB0-0x00000001800DBEE0
	public abstract class AtomListener<T, A, E, UER> : BaseAtomListener, IAtomListener<T> // TypeDefIndex: 7659
		where A : AtomAction<T>
		where E : AtomEvent<T>
		where UER : UnityEvent<T>
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private E _event;
		public UER _unityEventResponse;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<A> _actionResponses;
	
		// Properties
		public E Event { get; set; }
	
		// Constructors
		protected AtomListener();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public void OnEventRaised(T item);
		public void DebugLog(T item);
	}
}
