/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 15114
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _text; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AudioClip _audio; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _meta; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _localize; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _defId; // 0x30
	
		// Properties
		public string text { get; set; } // 0x00000001808B4D30-0x00000001808B4F60 0x0000000180379F20-0x0000000180379F30
		public AudioClip audio { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string meta { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public bool localize { get; set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804D9980-0x00000001804D9990
		public string defId { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 15115
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public <>c__DisplayClass24_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <BlackboardReplace>b__0(string input); // 0x00000001808B7710-0x00000001808B7990
		}
	
		// Constructors
		public Statement(); // 0x00000001808B4B70-0x00000001808B4BF0
		public Statement(string text); // 0x00000001808B4CA0-0x00000001808B4D30
		public Statement(string text, AudioClip audio); // 0x00000001808B4AD0-0x00000001808B4B70
		public Statement(string text, AudioClip audio, string meta); // 0x00000001808B4BF0-0x00000001808B4CA0
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb); // 0x00000001808B4990-0x00000001808B4AC0
		public override string ToString(); // 0x00000001808B4AC0-0x00000001808B4AD0
	}
}
