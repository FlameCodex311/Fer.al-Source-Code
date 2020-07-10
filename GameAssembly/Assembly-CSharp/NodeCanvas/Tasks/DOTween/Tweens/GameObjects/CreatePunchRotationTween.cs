/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x0000000180146380-0x0000000180146440
	[Description] // 0x0000000180146380-0x0000000180146440
	[Icon] // 0x0000000180146380-0x0000000180146440
	[Name] // 0x0000000180146380-0x0000000180146440
	public class CreatePunchRotationTween : ActionTask // TypeDefIndex: 14522
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> PunchRotation; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<int> Vibration; // 0x78
		public BBParameter<float> Elasticity; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8B9B0-0x0000000180E8BAB0 
	
		// Constructors
		public CreatePunchRotationTween(); // 0x0000000180E8B8E0-0x0000000180E8B9B0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8B770-0x0000000180E8B8E0
	}
}
