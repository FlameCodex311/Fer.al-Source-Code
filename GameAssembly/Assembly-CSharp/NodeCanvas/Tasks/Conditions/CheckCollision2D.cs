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
	[Category] // 0x00000001800D7020-0x00000001800D70E0
	[Name] // 0x00000001800D7020-0x00000001800D70E0
	[EventReceiver] // 0x00000001800D7020-0x00000001800D70E0
	public class CheckCollision2D : ConditionTask<Collider2D> // TypeDefIndex: 14159
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
		protected override string info { get; } // 0x000000018124F190-0x000000018124F260 
	
		// Constructors
		public CheckCollision2D(); // 0x000000018124F140-0x000000018124F190
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124EDF0-0x000000018124EE10
		public void OnCollisionEnter2D(Collision2D info); // 0x000000018124EE10-0x000000018124F060
		public void OnCollisionExit2D(Collision2D info); // 0x000000018124F060-0x000000018124F140
	}
}
