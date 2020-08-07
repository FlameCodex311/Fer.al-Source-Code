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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018024E680-0x000000018024E6E0
	[Description] // 0x000000018024E680-0x000000018024E6E0
	public class SortGameObjectListByDistance : ActionTask<Transform> // TypeDefIndex: 15331
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<List<GameObject>> targetList; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveAs; // 0x70
		public bool reverse; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A81D0-0x00000001807A8390 
	
		// Constructors
		public SortGameObjectListByDistance(); // 0x00000001807A8190-0x00000001807A81D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A7F60-0x00000001807A8080
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnExecute>b__5_0(GameObject go); // 0x00000001807A8080-0x00000001807A8190
	}
}
