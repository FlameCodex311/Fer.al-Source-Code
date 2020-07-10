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
	[Category] // 0x00000001800E8E70-0x00000001800E8ED0
	[Name] // 0x00000001800E8E70-0x00000001800E8ED0
	public class GetToString : ActionTask // TypeDefIndex: 14219
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<object> variable; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154AE60-0x000000018154AEA0 
	
		// Constructors
		public GetToString(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154ADA0-0x000000018154AE60
	}
}
