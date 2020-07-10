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
	[Category] // 0x00000001800FD660-0x00000001800FD6C0
	[Description] // 0x00000001800FD660-0x00000001800FD6C0
	public class MoveAway : ActionTask<Transform> // TypeDefIndex: 14291
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveAway(); // 0x00000001815512A0-0x0000000181551310
	
		// Methods
		protected override void OnUpdate(); // 0x0000000181550F40-0x00000001815512A0
	}
}
