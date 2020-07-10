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

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category] // 0x0000000180139A20-0x0000000180139AE0
	[Description] // 0x0000000180139A20-0x0000000180139AE0
	[Icon] // 0x0000000180139A20-0x0000000180139AE0
	[Name] // 0x0000000180139A20-0x0000000180139AE0
	public class CreateRotationTween : ActionTask<Rigidbody> // TypeDefIndex: 14504
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> Rotation; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public RotateMode RotateMode; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E8C3E0-0x0000000180E8C4B0 
	
		// Constructors
		public CreateRotationTween(); // 0x0000000180E8C1D0-0x0000000180E8C210
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8C0D0-0x0000000180E8C1D0
	}
}
