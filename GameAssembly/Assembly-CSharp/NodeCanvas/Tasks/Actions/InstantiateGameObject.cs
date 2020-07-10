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
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 14274
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018154DB90-0x000000018154DF50 
	
		// Constructors
		public InstantiateGameObject(); // 0x000000018154DB50-0x000000018154DB90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154D980-0x000000018154DB50
	}
}
