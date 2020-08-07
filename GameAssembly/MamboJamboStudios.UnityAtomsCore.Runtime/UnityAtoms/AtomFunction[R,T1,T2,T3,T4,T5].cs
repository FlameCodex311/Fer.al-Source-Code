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
	[EditorIcon] // 0x000000018023AEF0-0x000000018023AF20
	public abstract class AtomFunction<R, T1, T2, T3, T4, T5> : BaseAtom // TypeDefIndex: 7823
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Func<T1, T2, T3, T4, T5, R> Func;
	
		// Constructors
		protected AtomFunction();
	
		// Methods
		public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
		public AtomFunction<R, T1, T2, T3, T4, T5> SetFunc(Func<T1, T2, T3, T4, T5, R> func);
	}
}
