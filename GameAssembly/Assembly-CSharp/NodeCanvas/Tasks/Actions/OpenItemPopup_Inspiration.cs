/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011B710-0x000000018011B770
	[Description] // 0x000000018011B710-0x000000018011B770
	public class OpenItemPopup_Inspiration : ActionTask // TypeDefIndex: 14407
	{
		// Fields
		public string inspirationDefId; // 0x68
		public BBParameter<bool> waitToContinue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181556370-0x00000001815563A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 14408
		{
			// Fields
			public OpenItemPopup_Inspiration <>4__this; // 0x10
			public int quantity; // 0x18
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnExecute>b__0(UI_Window_ItemPopup inWindow); // 0x000000018155C3C0-0x000000018155C5D0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14409
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action <>9__4_1; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C690-0x000000018155C6F0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnExecute>b__4_1(); // 0x000000018155C1C0-0x000000018155C1D0
		}
	
		// Constructors
		public OpenItemPopup_Inspiration(); // 0x0000000181556320-0x0000000181556370
	
		// Methods
		protected override void OnExecute(); // 0x00000001815561C0-0x00000001815562C0
		public void OnWindowClosed(UI_Window inWindow); // 0x00000001815562C0-0x0000000181556320
	}
}
