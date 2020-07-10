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
	[Category] // 0x00000001800E9B10-0x00000001800E9B70
	[Description] // 0x00000001800E9B10-0x00000001800E9B70
	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 14222
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> list; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181547B40-0x0000000181547D20 
	
		// Constructors
		public GetCloserGameObjectInList(); // 0x0000000181547B00-0x0000000181547B40
	
		// Methods
		protected override void OnExecute(); // 0x0000000181547810-0x0000000181547B00
	}
}
