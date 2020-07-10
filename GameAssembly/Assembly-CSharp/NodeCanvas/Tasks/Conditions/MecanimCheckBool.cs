/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C2C20-0x00000001800C2C80
	[Name] // 0x00000001800C2C20-0x00000001800C2C80
	public class MecanimCheckBool : ConditionTask<Animator> // TypeDefIndex: 14115
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> parameter; // 0x68
		public BBParameter<bool> value; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181258480-0x0000000181258680 
	
		// Constructors
		public MecanimCheckBool(); // 0x0000000181258440-0x0000000181258480
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812583A0-0x0000000181258440
	}
}
