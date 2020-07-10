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
	[Category] // 0x00000001800ED6C0-0x00000001800ED720
	[Description] // 0x00000001800ED6C0-0x00000001800ED720
	public class SaveBlackboard : ActionTask<Blackboard> // TypeDefIndex: 14235
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018125CDA0-0x000000018125CE00 
	
		// Constructors
		public SaveBlackboard(); // 0x000000018125CD60-0x000000018125CDA0
	
		// Methods
		protected override void OnExecute(); // 0x000000018125CCD0-0x000000018125CD60
	}
}
