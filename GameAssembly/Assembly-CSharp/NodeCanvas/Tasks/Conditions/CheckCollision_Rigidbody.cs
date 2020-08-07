/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023A890-0x000000018023A8F0
	[Name] // 0x000000018023A890-0x000000018023A8F0
	public class CheckCollision_Rigidbody : ConditionTask<Rigidbody> // TypeDefIndex: 15256
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000180798430-0x00000001807984F0 
	
		// Constructors
		public CheckCollision_Rigidbody(); // 0x00000001807983E0-0x0000000180798430
	
		// Methods
		protected override void OnEnable(); // 0x0000000180798300-0x00000001807983E0
		protected override void OnDisable(); // 0x0000000180798220-0x0000000180798300
		protected override bool OnCheck(); // 0x0000000180796EC0-0x0000000180796EE0
		public void OnCollisionEnter(EventData<Collision> data); // 0x0000000180797F50-0x0000000180798150
		public void OnCollisionExit(EventData<Collision> data); // 0x0000000180798150-0x0000000180798220
	}
}
