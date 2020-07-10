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
	[EditorIcon] // 0x00000001800D45F0-0x00000001800D4620
	public abstract class AtomEvent : BaseAtom, ISerializationCallbackReceiver // TypeDefIndex: 7628
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action OnEventNoValue; // 0x20
	
		// Events
		public event Action OnEventNoValue {
			add; // 0x00000001822A00C0-0x00000001822A0160
			remove; // 0x00000001822A0160-0x00000001822A0200
		}
	
		// Constructors
		protected AtomEvent(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		protected void RaiseNoValue(); // 0x0000000180DDB0D0-0x0000000180DDB0F0
		public void Register(Action del); // 0x000000018229FFB0-0x000000018229FFC0
		public void Unregister(Action del); // 0x00000001822A00B0-0x00000001822A00C0
		public void RegisterListener(IAtomListener listener); // 0x000000018229FEC0-0x000000018229FFB0
		public void UnregisterListener(IAtomListener listener); // 0x000000018229FFC0-0x00000001822A00B0
		public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnAfterDeserialize(); // 0x000000018229FDF0-0x000000018229FEC0
	}
}
