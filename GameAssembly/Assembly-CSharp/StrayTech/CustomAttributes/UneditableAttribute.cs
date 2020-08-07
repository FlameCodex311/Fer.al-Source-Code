/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech.CustomAttributes
{
	public class UneditableAttribute : PropertyAttribute // TypeDefIndex: 14605
	{
		// Fields
		public readonly Effective EffectiveWhen; // 0x18
	
		// Nested types
		public enum Effective // TypeDefIndex: 14606
		{
			Always = 0,
			OnlyWhilePlaying = 1,
			OnlyWhileEditing = 2
		}
	
		// Constructors
		public UneditableAttribute(); // 0x0000000180CBE3C0-0x0000000180CBE3E0
		public UneditableAttribute(Effective effectiveWhen); // 0x0000000180CBE3E0-0x0000000180CBE410
	}
}
