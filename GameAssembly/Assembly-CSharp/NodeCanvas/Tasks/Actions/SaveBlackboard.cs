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
	[Category] // 0x0000000180250FF0-0x0000000180251050
	[Description] // 0x0000000180250FF0-0x0000000180251050
	public class SaveBlackboard : ActionTask<Blackboard> // TypeDefIndex: 15335
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A19D0-0x00000001807A1A30 
	
		// Constructors
		public SaveBlackboard(); // 0x00000001807A1990-0x00000001807A19D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A1900-0x00000001807A1990
	}
}
