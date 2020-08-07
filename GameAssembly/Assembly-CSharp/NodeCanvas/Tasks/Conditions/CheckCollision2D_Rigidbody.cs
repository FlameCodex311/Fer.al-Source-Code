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
	[Category] // 0x000000018023B6A0-0x000000018023B700
	[Name] // 0x000000018023B6A0-0x000000018023B700
	public class CheckCollision2D_Rigidbody : ConditionTask<Rigidbody2D> // TypeDefIndex: 15258
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
		protected override string info { get; } // 0x00000001807978F0-0x00000001807979B0 
	
		// Constructors
		public CheckCollision2D_Rigidbody(); // 0x00000001807978A0-0x00000001807978F0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180796EC0-0x0000000180796EE0
		protected override void OnEnable(); // 0x00000001807977C0-0x00000001807978A0
		protected override void OnDisable(); // 0x00000001807976E0-0x00000001807977C0
		private void OnCollisionEnter2D(EventData<Collision2D> data); // 0x00000001807973C0-0x0000000180797610
		private void OnCollisionExit2D(EventData<Collision2D> data); // 0x0000000180797610-0x00000001807976E0
	}
}
