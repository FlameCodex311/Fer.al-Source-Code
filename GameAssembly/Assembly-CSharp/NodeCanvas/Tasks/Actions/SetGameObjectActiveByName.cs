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
	[Category] // 0x0000000180128770-0x00000001801287D0
	[Description] // 0x0000000180128770-0x00000001801287D0
	public class SetGameObjectActiveByName : ActionTask // TypeDefIndex: 14454
	{
		// Fields
		public BBParameter<string> gameObjectName; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181260190-0x0000000181260240 
	
		// Constructors
		public SetGameObjectActiveByName(); // 0x0000000181260140-0x0000000181260190
	
		// Methods
		protected override void OnExecute(); // 0x000000018125FF50-0x0000000181260140
	}
}
