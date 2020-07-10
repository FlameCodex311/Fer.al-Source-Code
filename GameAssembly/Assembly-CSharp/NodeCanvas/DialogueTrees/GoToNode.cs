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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x0000000180174670-0x0000000180174780
	[Color] // 0x0000000180174670-0x0000000180174780
	[Description] // 0x0000000180174670-0x0000000180174780
	[Icon] // 0x0000000180174670-0x0000000180174780
	[Name] // 0x0000000180174670-0x0000000180174780
	[Obsolete] // 0x0000000180174670-0x0000000180174780
	public class GoToNode : DTNode // TypeDefIndex: 14073
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DTNode _targetNode; // 0x88
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool requireActorSelection { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public GoToNode(); // 0x000000018155E380-0x000000018155E3C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181567A50-0x0000000181567B40
	}
}
