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
	public abstract class SetVariableValue<T, V, C, R, E1, E2> : VoidAction // TypeDefIndex: 7772
		where V : AtomVariable<T, E1, E2>
		where C : AtomBaseVariable<T>
		where R : AtomReference<T, V, C>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<T, T>
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private V _variable;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private R _value;
	
		// Constructors
		protected SetVariableValue();
	
		// Methods
		public override void Do();
	}
}
