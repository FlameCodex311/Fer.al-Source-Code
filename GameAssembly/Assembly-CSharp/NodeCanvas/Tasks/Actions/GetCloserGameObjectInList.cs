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
	[Category] // 0x000000018024BFD0-0x000000018024C030
	[Description] // 0x000000018024BFD0-0x000000018024C030
	public class GetCloserGameObjectInList : ActionTask<Transform> // TypeDefIndex: 15322
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> list; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAD970-0x0000000180BADB30 
	
		// Constructors
		public GetCloserGameObjectInList(); // 0x0000000180BAD930-0x0000000180BAD970
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAD650-0x0000000180BAD930
	}
}
