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
	[Category] // 0x00000001800C3750-0x00000001800C37B0
	[Name] // 0x00000001800C3750-0x00000001800C37B0
	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 14118
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181258D40-0x0000000181258D70 
	
		// Constructors
		public MecanimIsInTransition(); // 0x0000000181258D00-0x0000000181258D40
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181258C80-0x0000000181258D00
	}
}
