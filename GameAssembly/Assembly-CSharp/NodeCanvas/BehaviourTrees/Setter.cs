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

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018021C700-0x000000018021C7C0
	[Description] // 0x000000018021C700-0x000000018021C7C0
	[Icon] // 0x000000018021C700-0x000000018021C7C0
	[Name] // 0x000000018021C700-0x000000018021C7C0
	public class Setter : BTDecorator // TypeDefIndex: 15181
	{
		// Fields
		public bool revertToOriginal; // 0x88
		[ShowIf] // 0x000000018021CD40-0x000000018021CD70
		public BBParameter<GameObject> newAgent; // 0x90
	
		// Constructors
		public Setter(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B4650-0x00000001808B4760
	}
}
