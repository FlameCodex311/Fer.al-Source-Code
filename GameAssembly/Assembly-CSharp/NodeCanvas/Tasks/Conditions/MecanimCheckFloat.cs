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
	[Category] // 0x00000001800C30A0-0x00000001800C3100
	[Name] // 0x00000001800C30A0-0x00000001800C3100
	public class MecanimCheckFloat : ConditionTask<Animator> // TypeDefIndex: 14116
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<float> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181258790-0x0000000181258990 
	
		// Constructors
		public MecanimCheckFloat(); // 0x0000000181258750-0x0000000181258790
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181258680-0x0000000181258750
	}
}
