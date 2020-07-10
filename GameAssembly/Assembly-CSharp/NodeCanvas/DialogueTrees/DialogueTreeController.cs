/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu] // 0x00000001800B77C0-0x00000001800B77F0
	public class DialogueTreeController : GraphOwner<NodeCanvas.DialogueTrees.DialogueTree>, IDialogueActor // TypeDefIndex: 14086
	{
		// Properties
		string IDialogueActor.name { get; } // 0x000000018123D3C0-0x000000018123D3D0 
		Texture2D IDialogueActor.portrait { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		Sprite IDialogueActor.portraitSprite { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		Color IDialogueActor.dialogueColor { get; } // 0x0000000181563A10-0x0000000181563A40 
		Vector3 IDialogueActor.dialoguePosition { get; } // 0x0000000181563A40-0x0000000181563AB0 
		Transform IDialogueActor.transform { get; } // 0x0000000181563AB0-0x0000000181563AC0 
	
		// Constructors
		public DialogueTreeController(); // 0x0000000181563E30-0x0000000181563E70
	
		// Methods
		public void StartDialogue(); // 0x0000000181563DC0-0x0000000181563DD0
		public void StartDialogue(Action<bool> callback); // 0x0000000181563DE0-0x0000000181563DF0
		public void StartDialogue(IDialogueActor instigator); // 0x0000000181563DD0-0x0000000181563DE0
		public void StartDialogue(IDialogueActor instigator, Action<bool> callback); // 0x0000000181563C20-0x0000000181563DC0
		public void PauseDialogue(); // 0x0000000181563AC0-0x0000000181563AF0
		public void StopDialogue(); // 0x0000000181563DF0-0x0000000181563E30
		public void SetActorReference(string paramName, IDialogueActor actor); // 0x0000000181563AF0-0x0000000181563B90
		public void SetActorReferences(Dictionary<string, IDialogueActor> actors); // 0x0000000181563B90-0x0000000181563C20
		public IDialogueActor GetActorReferenceByName(string paramName); // 0x0000000181563970-0x0000000181563A10
	}
}
