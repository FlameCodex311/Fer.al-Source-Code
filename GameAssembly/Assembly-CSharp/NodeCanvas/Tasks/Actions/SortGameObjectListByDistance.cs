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
	[Category] // 0x00000001800EC830-0x00000001800EC890
	[Description] // 0x00000001800EC830-0x00000001800EC890
	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 14231
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<List<GameObject>> targetList; // 0x68
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181263B00-0x0000000181263CE0 
	
		// Constructors
		public SortGameObjectListByDistance(); // 0x0000000181263AC0-0x0000000181263B00
	
		// Methods
		protected override void OnExecute(); // 0x0000000181263880-0x00000001812639A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <OnExecute>b__5_0(GameObject go); // 0x00000001812639A0-0x0000000181263AC0
	}
}
