/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	public abstract class DTNode : Node // TypeDefIndex: 15096
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _actorName; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _actorParameterID; // 0x90
	
		// Properties
		public override string name { get; } // 0x00000001808A3700-0x00000001808A3960 
		public virtual bool requireActorSelection { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override int maxInConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public override int maxOutConnections { get; } // 0x000000018058C710-0x000000018058C720 
		public sealed override Type outConnectionType { get; } // 0x00000001808A3960-0x00000001808A39C0 
		public sealed override bool allowAsPrime { get; } // 0x0000000180380B60-0x0000000180380B70 
		public sealed override bool canSelfConnect { get; } // 0x0000000180380950-0x0000000180380960 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x0000000180411150-0x0000000180411160 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x00000001806C4390-0x00000001806C43A0 
		protected DialogueTree DLGTree { get; } // 0x00000001808A35A0-0x00000001808A3630 
		public string actorName { get; private set; } // 0x00000001808A3630-0x00000001808A3680 0x00000001808A39C0-0x00000001808A3AF0
		public IDialogueActor finalActor { get; } // 0x00000001808A3680-0x00000001808A3700 
	
		// Constructors
		protected DTNode(); // 0x000000018089EA60-0x000000018089EAB0
	}
}
