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
	[Category] // 0x000000018023DCD0-0x000000018023DD30
	[Description] // 0x000000018023DCD0-0x000000018023DD30
	public class CheckTrigger_Transform : ConditionTask<Transform> // TypeDefIndex: 15264
	{
		// Fields
		private static bool avatarUpdated; // 0x00
		public TriggerTypes checkType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[ShowIf] // 0x000000018023DEE0-0x000000018023DF30
		[TagField] // 0x000000018023DEE0-0x000000018023DF30
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F6E40-0x00000001807F6F00 
	
		// Constructors
		public CheckTrigger_Transform(); // 0x00000001807F6DF0-0x00000001807F6E40
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F6890-0x00000001807F6A80
		protected override void OnEnable(); // 0x00000001807F6B60-0x00000001807F6C40
		protected override void OnDisable(); // 0x00000001807F6A80-0x00000001807F6B60
		public void OnTriggerEnter(EventData<Collider> data); // 0x00000001807F6C40-0x00000001807F6D20
		public void OnTriggerExit(EventData<Collider> data); // 0x00000001807F6D20-0x00000001807F6DF0
	}
}
