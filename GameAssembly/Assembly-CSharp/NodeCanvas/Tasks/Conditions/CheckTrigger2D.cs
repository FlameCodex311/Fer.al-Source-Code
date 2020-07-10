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
	[Category] // 0x00000001800DA670-0x00000001800DA730
	[Name] // 0x00000001800DA670-0x00000001800DA730
	[EventReceiver] // 0x00000001800DA670-0x00000001800DA730
	public class CheckTrigger2D : ConditionTask<Collider2D> // TypeDefIndex: 14165
	{
		// Fields
		public TriggerTypes CheckType; // 0x68
		public bool specifiedTagOnly; // 0x6C
		[TagField] // 0x00000001800B36B0-0x00000001800B36C0
		public string objectTag; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGameObjectAs; // 0x78
		private bool stay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181255670-0x0000000181255740 
	
		// Constructors
		public CheckTrigger2D(); // 0x0000000181255620-0x0000000181255670
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181255430-0x0000000181255450
		public void OnTriggerEnter2D(Collider2D other); // 0x0000000181255450-0x0000000181255540
		public void OnTriggerExit2D(Collider2D other); // 0x0000000181255540-0x0000000181255620
	}
}
