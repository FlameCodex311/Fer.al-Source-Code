/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[Serializable]
	public class Statement : IStatement // TypeDefIndex: 14104
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _localize; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _defId; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _text; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AudioClip _audio; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _meta; // 0x30
	
		// Properties
		public string text { get; set; } // 0x0000000181572A90-0x0000000181572CC0 0x000000018036AC90-0x000000018036ACA0
		public bool localize { get; set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public string defId { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public AudioClip audio { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string meta { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 14105
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public <>c__DisplayClass24_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <BlackboardReplace>b__0(string input); // 0x0000000181575F90-0x0000000181576250
		}
	
		// Constructors
		public Statement(); // 0x00000001815728D0-0x0000000181572950
		public Statement(string text); // 0x0000000181572A00-0x0000000181572A90
		public Statement(string text, AudioClip audio); // 0x0000000181572830-0x00000001815728D0
		public Statement(string text, AudioClip audio, string meta); // 0x0000000181572950-0x0000000181572A00
	
		// Methods
		public IStatement BlackboardReplace(IBlackboard bb); // 0x00000001815726E0-0x0000000181572820
		public override string ToString(); // 0x0000000181572820-0x0000000181572830
	}
}
