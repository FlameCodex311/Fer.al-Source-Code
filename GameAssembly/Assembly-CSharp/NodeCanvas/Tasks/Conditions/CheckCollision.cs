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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D6310-0x00000001800D63B0
	[EventReceiver] // 0x00000001800D6310-0x00000001800D63B0
	public class CheckCollision : ConditionTask<Collider> // TypeDefIndex: 14158
	{
		// Fields
		public CollisionTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField] // 0x00000001800B36B0-0x00000001800B36C0
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveContactPoint; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveContactNormal; // 0x88
		private bool stay; // 0x90
	
		// Properties
		protected override string info { get; } // 0x000000018124F5A0-0x000000018124F670 
	
		// Constructors
		public CheckCollision(); // 0x000000018124F550-0x000000018124F5A0
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124EDF0-0x000000018124EE10
		public void OnCollisionEnter(Collision info); // 0x000000018124F260-0x000000018124F470
		public void OnCollisionExit(Collision info); // 0x000000018124F470-0x000000018124F550
	}
}
