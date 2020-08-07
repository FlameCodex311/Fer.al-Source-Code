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
	[CreateAssetMenu] // 0x0000000180245B50-0x0000000180245BC0
	[EditorIcon] // 0x0000000180245B50-0x0000000180245BC0
	public sealed class FloatVariable : EquatableAtomVariable<float, UnityAtoms.FloatEvent, UnityAtoms.FloatFloatEvent> // TypeDefIndex: 7911
	{
		// Constructors
		public FloatVariable(); // 0x00000001820670F0-0x0000000182067130
	
		// Methods
		public bool ApplyChange(float amount); // 0x0000000182067000-0x0000000182067060
		public bool ApplyChange(EquatableAtomVariable<float, FloatEvent, FloatFloatEvent> amount); // 0x0000000182067060-0x00000001820670F0
	}
}
