/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018022E850-0x000000018022E880
	public class InstantiateGameObject : ActionTask<Transform> // TypeDefIndex: 15375
	{
		// Fields
		public BBParameter<Transform> parent; // 0x68
		public BBParameter<Vector3> clonePosition; // 0x70
		public BBParameter<Vector3> cloneRotation; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveCloneAs; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BB39B0-0x0000000180BB3D40 
	
		// Constructors
		public InstantiateGameObject(); // 0x0000000180BB3970-0x0000000180BB39B0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB37B0-0x0000000180BB3970
	}
}
