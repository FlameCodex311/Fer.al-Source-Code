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
	[Category] // 0x0000000180294330-0x0000000180294390
	[Description] // 0x0000000180294330-0x0000000180294390
	public class SetGameObjectActiveByName : ActionTask // TypeDefIndex: 15560
	{
		// Fields
		public BBParameter<string> gameObjectName; // 0x68
		public BBParameter<bool> setActive; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A4F30-0x00000001807A4FE0 
	
		// Constructors
		public SetGameObjectActiveByName(); // 0x00000001807A4EE0-0x00000001807A4F30
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A4D00-0x00000001807A4EE0
	}
}
