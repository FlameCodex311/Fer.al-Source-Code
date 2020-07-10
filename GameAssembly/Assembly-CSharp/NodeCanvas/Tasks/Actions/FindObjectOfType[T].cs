/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800F6D30-0x00000001800F6D90
	[Description] // 0x00000001800F6D30-0x00000001800F6D90
	public class FindObjectOfType<T> : ActionTask // TypeDefIndex: 14264
		where T : Component
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<T> saveComponentAs;
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGameObjectAs;
	
		// Constructors
		public FindObjectOfType();
	
		// Methods
		protected override void OnExecute();
	}
}
