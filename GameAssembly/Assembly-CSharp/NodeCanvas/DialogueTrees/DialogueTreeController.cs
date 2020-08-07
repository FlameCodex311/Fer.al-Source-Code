/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu] // 0x00000001801FFC70-0x00000001801FFCA0
	public class DialogueTreeController : GraphOwner<NodeCanvas.DialogueTrees.DialogueTree>, IDialogueActor // TypeDefIndex: 15110
	{
		// Properties
		string IDialogueActor.name { get; } // 0x00000001808A3EB0-0x00000001808A3EC0 
		Texture2D IDialogueActor.portrait { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		Sprite IDialogueActor.portraitSprite { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		Color IDialogueActor.dialogueColor { get; } // 0x00000001808A3E10-0x00000001808A3E40 
		Vector3 IDialogueActor.dialoguePosition { get; } // 0x00000001808A3E40-0x00000001808A3EB0 
		Transform IDialogueActor.transform { get; } // 0x00000001808A3EC0-0x00000001808A3ED0 
	
		// Constructors
		public DialogueTreeController(); // 0x00000001808A42C0-0x00000001808A4300
	
		// Methods
		public void StartDialogue(); // 0x00000001808A4210-0x00000001808A4220
		public void StartDialogue(Action<bool> callback); // 0x00000001808A4280-0x00000001808A4290
		public void StartDialogue(IDialogueActor instigator); // 0x00000001808A4220-0x00000001808A4230
		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback); // 0x00000001808A4230-0x00000001808A4280
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback); // 0x00000001808A4070-0x00000001808A4210
		public void PauseDialogue(); // 0x00000001808A3ED0-0x00000001808A3F00
		public void StopDialogue(); // 0x00000001808A4290-0x00000001808A42C0
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x00000001808A3F00-0x00000001808A3FC0
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x00000001808A3FC0-0x00000001808A4070
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x00000001808A3D50-0x00000001808A3E10
	}
}
