/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	public class MultipleChoiceRequestInfo // TypeDefIndex: 15100
	{
		// Fields
		public IDialogueActor actor; // 0x10
		public Dictionary<IStatement, int> options; // 0x18
		public float availableTime; // 0x20
		public bool showLastStatement; // 0x24
		public Action<int> SelectOption; // 0x28
		public IStatement statement; // 0x30
		public bool allowNextButton; // 0x38
	
		// Constructors
		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback, bool allowNextButton); // 0x00000001808B0FF0-0x00000001808B1060
		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, Action<int> callback, bool allowNextButton); // 0x00000001808B1060-0x00000001808B10D0
	}
}
