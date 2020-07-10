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
	[Category] // 0x00000001800C38F0-0x00000001800C3920
	public class EvaluateCurve : ActionTask // TypeDefIndex: 14217
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<AnimationCurve> curve; // 0x68
		public BBParameter<float> from; // 0x70
		public BBParameter<float> to; // 0x78
		public BBParameter<float> time; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveAs; // 0x88
	
		// Constructors
		public EvaluateCurve(); // 0x0000000181541590-0x0000000181541600
	
		// Methods
		protected override void OnUpdate(); // 0x00000001815413D0-0x0000000181541590
	}
}
