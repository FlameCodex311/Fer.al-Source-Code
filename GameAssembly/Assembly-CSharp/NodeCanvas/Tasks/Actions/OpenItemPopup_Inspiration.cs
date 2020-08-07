/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180288C80-0x0000000180288CE0
	[Description] // 0x0000000180288C80-0x0000000180288CE0
	public class OpenItemPopup_Inspiration : ActionTask // TypeDefIndex: 15512
	{
		// Fields
		public string inspirationDefId; // 0x68
		public BBParameter<bool> waitToContinue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BBC820-0x0000000180BBC850 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 15513
		{
			// Fields
			public OpenItemPopup_Inspiration <>4__this; // 0x10
			public int quantity; // 0x18
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnExecute>b__0(UI_Window_ItemPopup inWindow); // 0x0000000180BC0D20-0x0000000180BC0F20
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15514
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action <>9__4_1; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180BC0FE0-0x0000000180BC1040
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnExecute>b__4_1(); // 0x0000000180BC0B50-0x0000000180BC0B60
		}
	
		// Constructors
		public OpenItemPopup_Inspiration(); // 0x0000000180BBC7D0-0x0000000180BBC820
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBC670-0x0000000180BBC770
		public void OnWindowClosed(UI_Window inWindow); // 0x0000000180BBC770-0x0000000180BBC7D0
	}
}
