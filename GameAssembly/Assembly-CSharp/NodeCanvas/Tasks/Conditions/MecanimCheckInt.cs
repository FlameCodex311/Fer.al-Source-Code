/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C3470-0x00000001800C34D0
	[Name] // 0x00000001800C3470-0x00000001800C34D0
	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 14117
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181258A80-0x0000000181258C80 
	
		// Constructors
		public MecanimCheckInt(); // 0x0000000181258A40-0x0000000181258A80
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181258990-0x0000000181258A40
	}
}
