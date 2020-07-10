/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech.CustomAttributes
{
	public class UneditableAttribute : PropertyAttribute // TypeDefIndex: 13937
	{
		// Fields
		public readonly Effective EffectiveWhen; // 0x18
	
		// Nested types
		public enum Effective // TypeDefIndex: 13938
		{
			Always = 0,
			OnlyWhilePlaying = 1,
			OnlyWhileEditing = 2
		}
	
		// Constructors
		public UneditableAttribute(); // 0x0000000181361550-0x0000000181361570
		public UneditableAttribute(Effective effectiveWhen); // 0x0000000181361570-0x00000001813615A0
	}
}
