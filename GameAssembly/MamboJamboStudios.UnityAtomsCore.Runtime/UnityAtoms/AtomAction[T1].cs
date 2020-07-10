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
	public abstract class AtomAction<T1> : AtomAction // TypeDefIndex: 7579
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Action<T1> Action;
	
		// Constructors
		protected AtomAction();
	
		// Methods
		public virtual void Do(T1 t1);
	}
}
