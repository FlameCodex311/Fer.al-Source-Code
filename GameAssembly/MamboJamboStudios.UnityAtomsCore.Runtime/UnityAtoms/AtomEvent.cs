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
	[EditorIcon] // 0x0000000180234E70-0x0000000180234EA0
	public abstract class AtomEvent : BaseAtom, ISerializationCallbackReceiver // TypeDefIndex: 7794
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action OnEventNoValue; // 0x20
	
		// Events
		public event Action OnEventNoValue {
			add; // 0x00000001820658C0-0x0000000182065960
			remove; // 0x0000000182065960-0x0000000182065A00
		}
	
		// Constructors
		protected AtomEvent(); // 0x00000001803FEC00-0x00000001803FEC10
	
		// Methods
		protected void RaiseNoValue(); // 0x00000001804D7E10-0x00000001804D7E30
		public void Register(Action del); // 0x00000001820657C0-0x00000001820657D0
		public void Unregister(Action del); // 0x00000001820658B0-0x00000001820658C0
		public void RegisterListener(IAtomListener listener); // 0x00000001820656E0-0x00000001820657C0
		public void UnregisterListener(IAtomListener listener); // 0x00000001820657D0-0x00000001820658B0
		public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnAfterDeserialize(); // 0x0000000182065620-0x00000001820656E0
	}
}
