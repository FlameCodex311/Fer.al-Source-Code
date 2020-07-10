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
	[Description] // 0x00000001800BD340-0x00000001800BD3A0
	[Name] // 0x00000001800BD340-0x00000001800BD3A0
	public class StatementNode : DTNode // TypeDefIndex: 14101
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Statement statement; // 0x88
		public bool allowNextButton; // 0x90
	
		// Properties
		public override bool requireActorSelection { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		public StatementNode(); // 0x0000000181572640-0x00000001815726E0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001815724F0-0x0000000181572610
		private void OnStatementFinish(); // 0x0000000181572610-0x0000000181572640
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__4_0(int choice); // 0x0000000181572610-0x0000000181572640
	}
}
