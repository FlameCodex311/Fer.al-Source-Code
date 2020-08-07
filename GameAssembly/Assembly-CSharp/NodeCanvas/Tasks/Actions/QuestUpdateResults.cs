/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028E4F0-0x000000018028E550
	[Description] // 0x000000018028E4F0-0x000000018028E550
	public class QuestUpdateResults : NetworkActionTask // TypeDefIndex: 15544
	{
		// Fields
		public EResultVariable resultVariable; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018079FBC0-0x000000018079FC60 
	
		// Nested types
		public enum EResultVariable // TypeDefIndex: 15545
		{
			SideQuest = 0,
			Cinders = 1,
			Secrets = 2,
			Treasures = 3,
			Puzzles = 4
		}
	
		// Constructors
		public QuestUpdateResults(); // 0x000000018079E720-0x000000018079E730
	}
}
