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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001800BA820-0x00000001800BA910
	[Color] // 0x00000001800BA820-0x00000001800BA910
	[Description] // 0x00000001800BA820-0x00000001800BA910
	[Icon] // 0x00000001800BA820-0x00000001800BA910
	[Name] // 0x00000001800BA820-0x00000001800BA910
	public class FinishNode : DTNode // TypeDefIndex: 14094
	{
		// Fields
		public CompactStatus finishState; // 0x88
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool requireActorSelection { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public FinishNode(); // 0x0000000181567850-0x00000001815678A0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181567800-0x0000000181567850
	}
}
