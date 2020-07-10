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
	[Category] // 0x0000000180137D30-0x0000000180137DF0
	[Description] // 0x0000000180137D30-0x0000000180137DF0
	[Icon] // 0x0000000180137D30-0x0000000180137DF0
	[Name] // 0x0000000180137D30-0x0000000180137DF0
	public class CreateLookAtTween : ActionTask<Rigidbody> // TypeDefIndex: 14502
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> LookAt; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public AxisConstraint AxisConstraint; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E89BE0-0x0000000180E89CB0 
	
		// Constructors
		public CreateLookAtTween(); // 0x0000000180E89B60-0x0000000180E89BA0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E89940-0x0000000180E89A50
	}
}
