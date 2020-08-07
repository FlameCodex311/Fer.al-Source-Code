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
	[Serializable]
	public class ProxyDialogueActor : IDialogueActor // TypeDefIndex: 15112
	{
		// Fields
		private string _name; // 0x10
		private Transform _transform; // 0x18
	
		// Properties
		public string name { get; } // 0x0000000180372440-0x0000000180372450 
		public Texture2D portrait { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public Sprite portraitSprite { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public Color dialogueColor { get; } // 0x00000001808A3E10-0x00000001808A3E40 
		public Vector3 dialoguePosition { get; } // 0x00000001808B3C90-0x00000001808B3D00 
		public Transform transform { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Constructors
		public ProxyDialogueActor(string name, Transform transform); // 0x0000000180372010-0x00000001803720F0
	}
}
