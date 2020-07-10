/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	public abstract class DTNode : Node // TypeDefIndex: 14088
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _actorName; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _actorParameterID; // 0x80
	
		// Properties
		public override string name { get; } // 0x0000000181563360-0x00000001815635C0 
		public virtual bool requireActorSelection { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override int maxInConnections { get; } // 0x00000001805F5E50-0x00000001805F5E60 
		public override int maxOutConnections { get; } // 0x000000018042E670-0x000000018042E680 
		public sealed override Type outConnectionType { get; } // 0x00000001815635C0-0x0000000181563620 
		public sealed override bool allowAsPrime { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000180362180-0x0000000180362190 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		protected DialogueTree DLGTree { get; } // 0x0000000181563200-0x0000000181563290 
		protected string actorName { get; set; } // 0x0000000181563290-0x00000001815632E0 0x0000000181563620-0x0000000181563750
		protected IDialogueActor finalActor { get; } // 0x00000001815632E0-0x0000000181563360 
	
		// Constructors
		protected DTNode(); // 0x000000018155E380-0x000000018155E3C0
	}
}
