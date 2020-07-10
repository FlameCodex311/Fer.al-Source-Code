/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F5BB0-0x00000001800F5C10
	[Description] // 0x00000001800F5BB0-0x00000001800F5C10
	public class FindChildByName : ActionTask<Transform> // TypeDefIndex: 14262
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> childName; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Transform> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001815457F0-0x0000000181545850 
	
		// Constructors
		public FindChildByName(); // 0x00000001815457B0-0x00000001815457F0
	
		// Methods
		protected override void OnExecute(); // 0x00000001815456D0-0x00000001815457B0
	}
}
