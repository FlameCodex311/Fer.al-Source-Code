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

namespace NodeCanvas.DialogueTrees
{
	[Description] // 0x0000000180207340-0x00000001802073A0
	[Name] // 0x0000000180207340-0x00000001802073A0
	public class StatementNode : DTNode // TypeDefIndex: 15128
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Statement statement; // 0x98
		public bool allowNextButton; // 0xA0
	
		// Properties
		public override bool requireActorSelection { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		public StatementNode(); // 0x00000001808B48F0-0x00000001808B4990
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808B4760-0x00000001808B48B0
		private void OnStatementFinish(); // 0x00000001808B48B0-0x00000001808B48F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__4_0(int choice); // 0x00000001808B48B0-0x00000001808B48F0
	}
}
