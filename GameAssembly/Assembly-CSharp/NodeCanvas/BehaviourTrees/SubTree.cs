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
	[Description] // 0x000000018021FA70-0x000000018021FB60
	[DropReferenceType] // 0x000000018021FA70-0x000000018021FB60
	[Icon] // 0x000000018021FA70-0x000000018021FB60
	[Name] // 0x000000018021FA70-0x000000018021FB60
	public class SubTree : BTNodeNested<NodeCanvas.BehaviourTrees.BehaviourTree> // TypeDefIndex: 15188
	{
		// Fields
		[ExposeField] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private BBParameter<BehaviourTree> _subTree; // 0xA0
	
		// Properties
		public override BehaviourTree subGraph { get; set; } // 0x00000001808B59C0-0x00000001808B5A10 0x00000001808B5A10-0x00000001808B5A70
		public override BBParameter subGraphParameter { get; } // 0x00000001803D6D90-0x00000001803D6DA0 
	
		// Constructors
		public SubTree(); // 0x00000001808B5980-0x00000001808B59C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B5760-0x00000001808B58F0
		protected override void OnReset(); // 0x00000001808B58F0-0x00000001808B5980
	}
}
