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
	[Category] // 0x000000018023B120-0x000000018023B170
	[DoNotList] // 0x000000018023B120-0x000000018023B170
	public class CheckTrigger : ConditionTask<Collider> // TypeDefIndex: 15265
	{
		// Fields
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[ShowIf] // 0x000000018023DEE0-0x000000018023DF30
		[TagField] // 0x000000018023DEE0-0x000000018023DF30
		public string objectTag; // 0x70
		public string whynot; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveGameObjectAs; // 0x80
		private bool stay; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807F6F50-0x00000001807F7010 
	
		// Constructors
		public CheckTrigger(); // 0x00000001807F6F00-0x00000001807F6F50
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F64F0-0x00000001807F6510
		protected override void OnEnable(); // 0x00000001807F65F0-0x00000001807F66D0
		protected override void OnDisable(); // 0x00000001807F6510-0x00000001807F65F0
		public void OnTriggerEnter(EventData<Collider> data); // 0x00000001807F66D0-0x00000001807F67B0
		public void OnTriggerExit(EventData<Collider> data); // 0x00000001807F67B0-0x00000001807F6890
	}
}
