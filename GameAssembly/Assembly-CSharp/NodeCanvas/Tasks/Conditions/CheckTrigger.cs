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
	[Category] // 0x00000001800D9A70-0x00000001800D9B10
	[EventReceiver] // 0x00000001800D9A70-0x00000001800D9B10
	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 14164
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[ShowIf] // 0x00000001800DA130-0x00000001800DA180
		[TagField] // 0x00000001800DA130-0x00000001800DA180
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181255960-0x0000000181255A30 
	
		// Constructors
		public CheckTrigger(); // 0x0000000181255910-0x0000000181255960
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181255430-0x0000000181255450
		public void OnTriggerEnter(Collider other); // 0x0000000181255740-0x0000000181255830
		public void OnTriggerExit(Collider other); // 0x0000000181255830-0x0000000181255910
	}
}
