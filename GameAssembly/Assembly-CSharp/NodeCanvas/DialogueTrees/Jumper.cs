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
	[Category] // 0x00000001800BABE0-0x00000001800BACD0
	[Color] // 0x00000001800BABE0-0x00000001800BACD0
	[Description] // 0x00000001800BABE0-0x00000001800BACD0
	[Icon] // 0x00000001800BABE0-0x00000001800BACD0
	[Name] // 0x00000001800BABE0-0x00000001800BACD0
	public class Jumper : DTNode // TypeDefIndex: 14095
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _sourceNodeUID; // 0x88
		private object _sourceNode; // 0x90
	
		// Properties
		private string sourceNodeUID { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		private DTNode sourceNode { get; set; } // 0x0000000181568CD0-0x0000000181568E00 0x000000018049D4D0-0x000000018049D4E0
		public override int maxOutConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override bool requireActorSelection { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public Jumper(); // 0x000000018155E380-0x000000018155E3C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181568B90-0x0000000181568C90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <get_sourceNode>b__6_0(DTNode n); // 0x0000000181568C90-0x0000000181568CD0
	}
}
