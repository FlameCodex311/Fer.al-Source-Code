﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	public abstract class AtomReference<T, V, C> : AtomReference // TypeDefIndex: 7869
		where V : AtomBaseVariable<T>
		where C : AtomBaseVariable<T>
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _value;
		public C _constant;
		public V _variable;
	
		// Properties
		public T Value { get; set; }
	
		// Constructors
		protected AtomReference();
	
		// Methods
		public static implicit operator T(AtomReference<T, V, C> reference);
	}
}
