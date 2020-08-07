/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu] // 0x00000001801FA3B0-0x00000001801FA3E0
	public class DialogueActor : ManagedBehaviour, IDialogueActor // TypeDefIndex: 15098
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected string _name; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Texture2D _portrait; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Color _dialogueColor; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Vector3 _dialogueOffset; // 0x70
		private Sprite _portraitSprite; // 0x80
	
		// Properties
		public new string name { get; } // 0x0000000180378320-0x0000000180378330 
		public Texture2D portrait { get; } // 0x00000001803A1580-0x00000001803A1590 
		public Sprite portraitSprite { get; } // 0x00000001808A3BD0-0x00000001808A3D50 
		public Color dialogueColor { get; } // 0x0000000180428FB0-0x0000000180428FC0 
		public Vector3 dialoguePosition { get; } // 0x00000001808A3B60-0x00000001808A3BD0 
	
		// Constructors
		public DialogueActor(); // 0x00000001808A3AF0-0x00000001808A3B60
	}
}
