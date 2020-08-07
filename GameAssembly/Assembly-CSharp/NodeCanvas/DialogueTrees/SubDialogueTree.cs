/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Description] // 0x0000000180207980-0x0000000180207A20
	[DropReferenceType] // 0x0000000180207980-0x0000000180207A20
	[Name] // 0x0000000180207980-0x0000000180207A20
	public class SubDialogueTree : DTNodeNested<NodeCanvas.DialogueTrees.DialogueTree>, IUpdatable // TypeDefIndex: 15129
	{
		// Fields
		[ExposeField] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private BBParameter<DialogueTree> _subTree; // 0xB0
		[fsSerializeAs] // 0x0000000180208080-0x00000001802080B0
		private Dictionary<string, string> _actorParametersMap; // 0xB8
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000180411150-0x0000000180411160 
		public override DialogueTree subGraph { get; set; } // 0x00000001808B56B0-0x00000001808B5700 0x00000001808B5700-0x00000001808B5760
		public override BBParameter subGraphParameter { get; } // 0x000000018067DD20-0x000000018067DD30 
	
		// Constructors
		public SubDialogueTree(); // 0x00000001808B5670-0x00000001808B56B0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808B5110-0x00000001808B53C0
		private void OnSubDialogueFinish(bool success); // 0x00000001808B53C0-0x00000001808B5440
		void IUpdatable.Update(); // 0x00000001808B5050-0x00000001808B5110
		private void TryWriteMappedActorParameters(); // 0x00000001808B5440-0x00000001808B5670
	}
}
