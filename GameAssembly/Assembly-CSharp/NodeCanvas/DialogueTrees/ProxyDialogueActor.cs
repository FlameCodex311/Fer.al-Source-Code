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
	[Serializable]
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 14090
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Texture2D portrait { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public Sprite portraitSprite { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public Color dialogueColor { get; } // 0x0000000181563A10-0x0000000181563A40 
		public Vector3 dialoguePosition { get; } // 0x0000000181571400-0x0000000181571470 
		public Transform transform { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		public ProxyDialogueActor(string name, Transform transform); // 0x00000001803DA900-0x00000001803DA940
	}
}
