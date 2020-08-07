/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	public abstract class EquatableAtomVariable<T, E1, E2> : AtomVariable<T, E1, E2> // TypeDefIndex: 7910
		where T : IEquatable<T>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<T, T>
	{
		// Constructors
		protected EquatableAtomVariable();
	
		// Methods
		protected override bool AreEqual(T t1, T t2);
	}
}
