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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802231C0-0x0000000180223220
	[Name] // 0x00000001802231C0-0x0000000180223220
	public class MecanimCheckInt : ConditionTask<Animator> // TypeDefIndex: 15199
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> parameter; // 0x68
		public CompareMethod comparison; // 0x70
		public BBParameter<int> value; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001808010D0-0x00000001808012B0 
	
		// Constructors
		public MecanimCheckInt(); // 0x0000000180801090-0x00000001808010D0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180800FE0-0x0000000180801090
	}
}
