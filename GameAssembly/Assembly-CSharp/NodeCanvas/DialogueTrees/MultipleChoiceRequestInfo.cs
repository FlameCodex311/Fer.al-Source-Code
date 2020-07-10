/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	public class MultipleChoiceRequestInfo // TypeDefIndex: 14076
	{
		// Fields
		public IStatement statement; // 0x10
		public IDialogueActor actor; // 0x18
		public Dictionary<IStatement, int> options; // 0x20
		public float availableTime; // 0x28
		public Action<int> SelectOption; // 0x30
		public bool allowNextButton; // 0x38
	
		// Constructors
		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback, bool allowNextButton); // 0x0000000181569950-0x00000001815699C0
		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, Action<int> callback, bool allowNextButton); // 0x00000001815699C0-0x0000000181569A30
	}
}
