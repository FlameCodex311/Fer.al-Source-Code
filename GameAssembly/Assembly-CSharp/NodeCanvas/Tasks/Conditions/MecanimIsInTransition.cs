/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180223480-0x00000001802234E0
	[Name] // 0x0000000180223480-0x00000001802234E0
	public class MecanimIsInTransition : ConditionTask<Animator> // TypeDefIndex: 15200
	{
		// Fields
		public BBParameter<int> layerIndex; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180801370-0x00000001808013A0 
	
		// Constructors
		public MecanimIsInTransition(); // 0x0000000180801330-0x0000000180801370
	
		// Methods
		protected override bool OnCheck(); // 0x00000001808012B0-0x0000000180801330
	}
}
