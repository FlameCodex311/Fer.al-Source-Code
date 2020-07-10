/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu] // 0x0000000180175110-0x0000000180175140
	public class DialogueActor : MonoBehaviour, IDialogueActor // TypeDefIndex: 14074
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string _name; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Texture2D _portrait; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Color _dialogueColor; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Vector3 _dialogueOffset; // 0x40
		private Sprite _portraitSprite; // 0x50
	
		// Properties
		public new string name { get; } // 0x000000018036AC70-0x000000018036AC80 
		public Texture2D portrait { get; } // 0x0000000180369B60-0x0000000180369B70 
		public Sprite portraitSprite { get; } // 0x00000001815637F0-0x0000000181563970 
		public Color dialogueColor { get; } // 0x000000018038E0C0-0x000000018038E0D0 
		public Vector3 dialoguePosition { get; } // 0x0000000181563780-0x00000001815637F0 
	
		// Constructors
		public DialogueActor(); // 0x0000000181563750-0x0000000181563780
	}
}
