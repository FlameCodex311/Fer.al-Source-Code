/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180260DF0-0x0000000180260E50
	[Description] // 0x0000000180260DF0-0x0000000180260E50
	public class RotateTowards : ActionTask<Transform> // TypeDefIndex: 15397
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		[SliderField] // 0x0000000180229F50-0x0000000180229F70
		public BBParameter<float> angleDifference; // 0x78
		public BBParameter<Vector3> upVector; // 0x80
		public bool waitActionFinish; // 0x88
	
		// Constructors
		public RotateTowards(); // 0x00000001807A0950-0x00000001807A0A20
	
		// Methods
		protected override void OnUpdate(); // 0x00000001807A0520-0x00000001807A0950
	}
}
