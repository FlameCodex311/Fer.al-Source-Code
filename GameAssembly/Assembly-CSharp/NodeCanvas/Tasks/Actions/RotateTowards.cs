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
	[Category] // 0x00000001800FE3E0-0x00000001800FE440
	[Description] // 0x00000001800FE3E0-0x00000001800FE440
	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 14294
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		[SliderField] // 0x00000001800C9340-0x00000001800C9360
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateTowards(); // 0x000000018125BC90-0x000000018125BD60
	
		// Methods
		protected override void OnUpdate(); // 0x000000018125B840-0x000000018125BC90
	}
}
