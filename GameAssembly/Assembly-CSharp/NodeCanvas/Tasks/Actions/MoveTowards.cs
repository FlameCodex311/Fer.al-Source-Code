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
	[Category] // 0x00000001800FDA30-0x00000001800FDA90
	[Description] // 0x00000001800FDA30-0x00000001800FDA90
	public class MoveTowards : ActionTask<Transform> // TypeDefIndex: 14292
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> stopDistance; // 0x78
		public bool waitActionFinish; // 0x80
	
		// Constructors
		public MoveTowards(); // 0x00000001815526B0-0x0000000181552720
	
		// Methods
		protected override void OnUpdate(); // 0x0000000181552360-0x00000001815526B0
	}
}
