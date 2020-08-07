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
	[EditorIcon] // 0x0000000180244970-0x00000001802449A0
	public abstract class AtomBaseVariable<T> : AtomBaseVariable // TypeDefIndex: 7903
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected T _value;
	
		// Properties
		public override object BaseValue { get; set; }
		public virtual T Value { get; set; }
	
		// Constructors
		protected AtomBaseVariable();
	
		// Methods
		protected bool Equals(AtomBaseVariable<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
		public static bool operator ==(AtomBaseVariable<T> left, AtomBaseVariable<T> right);
		public static bool operator !=(AtomBaseVariable<T> left, AtomBaseVariable<T> right);
		public override void Reset(bool shouldTriggerEvents = false /* Metadata: 0x00776E86 */);
	}
}
