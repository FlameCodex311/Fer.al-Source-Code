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
	[EditorIcon] // 0x00000001800DA1D0-0x00000001800DA200
	public abstract class AtomFunction<R> : BaseAtom // TypeDefIndex: 7652
	{
		// Fields
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Func<R> Func;
	
		// Constructors
		protected AtomFunction();
	
		// Methods
		public virtual R Call();
		public AtomFunction<R> SetFunc(Func<R> func);
	}
}
