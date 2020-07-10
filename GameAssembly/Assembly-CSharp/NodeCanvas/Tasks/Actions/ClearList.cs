/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800C7FF0-0x00000001800C8020
	public class ClearList : ActionTask // TypeDefIndex: 14221
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<IList> targetList; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018174B0F0-0x000000018174B130 
	
		// Constructors
		public ClearList(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018174B070-0x000000018174B0F0
	}
}
