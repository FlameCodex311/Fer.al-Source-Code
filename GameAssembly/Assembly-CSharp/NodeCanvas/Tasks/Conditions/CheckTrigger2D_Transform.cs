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
	[Category] // 0x000000018023E730-0x000000018023E7B0
	[Description] // 0x000000018023E730-0x000000018023E7B0
	[Name] // 0x000000018023E730-0x000000018023E7B0
	public class CheckTrigger2D_Transform : ConditionTask<Transform> // TypeDefIndex: 15266
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F6320-0x00000001807F63E0 
	
		// Constructors
		public CheckTrigger2D_Transform(); // 0x00000001807F62D0-0x00000001807F6320
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F5BD0-0x00000001807F5BF0
		protected override void OnEnable(); // 0x00000001807F6040-0x00000001807F6120
		protected override void OnDisable(); // 0x00000001807F5F60-0x00000001807F6040
		public void OnTriggerEnter2D(EventData<Collider2D> data); // 0x00000001807F6120-0x00000001807F6200
		public void OnTriggerExit2D(EventData<Collider2D> data); // 0x00000001807F6200-0x00000001807F62D0
	}
}
