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
	[EditorIcon] // 0x00000001800E2BB0-0x00000001800E2BE0
	public abstract class AtomBaseVariable<T> : AtomBaseVariable // TypeDefIndex: 7737
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
		public override void Reset(bool shouldTriggerEvents = false /* Metadata: 0x00742198 */);
	}
}
