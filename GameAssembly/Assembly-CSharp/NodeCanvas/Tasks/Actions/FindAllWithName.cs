/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F50D0-0x00000001800F5130
	[Description] // 0x00000001800F50D0-0x00000001800F5130
	public class FindAllWithName : ActionTask // TypeDefIndex: 14260
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> searchName; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181545220-0x0000000181545400 
	
		// Constructors
		public FindAllWithName(); // 0x00000001815451D0-0x0000000181545220
	
		// Methods
		protected override void OnExecute(); // 0x0000000181545040-0x00000001815451D0
	}
}
