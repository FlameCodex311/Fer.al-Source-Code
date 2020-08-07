/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Description] // 0x000000018021E450-0x000000018021E540
	[DropReferenceType] // 0x000000018021E450-0x000000018021E540
	[Icon] // 0x000000018021E450-0x000000018021E540
	[Name] // 0x000000018021E450-0x000000018021E540
	public class NestedDT : BTNodeNested<DialogueTree> // TypeDefIndex: 15186
	{
		// Fields
		[ExposeField] // 0x00000001801F43C0-0x00000001801F4410
		[Name] // 0x00000001801F43C0-0x00000001801F4410
		[SerializeField] // 0x00000001801F43C0-0x00000001801F4410
		private BBParameter<DialogueTree> _nestedDialogueTree; // 0xA0
	
		// Properties
		public override DialogueTree subGraph { get; set; } // 0x00000001808B1640-0x00000001808B1690 0x00000001808B1690-0x00000001808B16F0
		public override BBParameter subGraphParameter { get; } // 0x00000001803D6D90-0x00000001803D6DA0 
	
		// Constructors
		public NestedDT(); // 0x00000001808B1600-0x00000001808B1640
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B1430-0x00000001808B1570
		private void OnDLGFinished(bool success); // 0x00000001808B1410-0x00000001808B1430
		protected override void OnReset(); // 0x00000001808B1570-0x00000001808B1600
	}
}
