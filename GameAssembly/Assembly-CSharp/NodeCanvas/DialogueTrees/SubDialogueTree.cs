/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001800BD7B0-0x00000001800BD830
	[Description] // 0x00000001800BD7B0-0x00000001800BD830
	[Name] // 0x00000001800BD7B0-0x00000001800BD830
	public class SubDialogueTree : DTNode, IGraphAssignable, ISubParametersContainer // TypeDefIndex: 14102
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BBParameter<DialogueTree> _subTree; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Dictionary<string, string> actorParametersMap; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Dictionary<string, BBObjectParameter> variablesMap; // 0x98
		private Dictionary<DialogueTree, DialogueTree> instances; // 0xA0
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000180362180-0x0000000180362190 
		public DialogueTree subTree { get; set; } // 0x00000001815730B0-0x0000000181573100 0x0000000181573CA0-0x0000000181573D00
		Graph IGraphAssignable.nestedGraph { get; set; } // 0x00000001815730B0-0x0000000181573100 0x0000000181573100-0x00000001815731D0
	
		// Constructors
		public SubDialogueTree(); // 0x0000000181573BC0-0x0000000181573CA0
	
		// Methods
		Graph[] IGraphAssignable.GetInstances(); // 0x0000000181573050-0x00000001815730B0
		BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x00000001815731D0-0x0000000181573230
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181573230-0x00000001815734C0
		private void SetActorParametersMapping(); // 0x0000000181573700-0x0000000181573990
		private void SetVariablesMapping(); // 0x0000000181573990-0x0000000181573BC0
		private void OnSubDialogueFinish(bool success); // 0x00000001815736A0-0x0000000181573700
		public override void OnGraphStoped(); // 0x00000001815735B0-0x00000001815736A0
		public override void OnGraphPaused(); // 0x00000001815734C0-0x00000001815735B0
		private bool IsInstance(DialogueTree dt); // 0x0000000181572FF0-0x0000000181573050
		private void CheckInstance(); // 0x0000000181572D90-0x0000000181572FF0
	}
}
