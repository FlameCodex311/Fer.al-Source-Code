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
	[Category] // 0x0000000180138110-0x00000001801381D0
	[Description] // 0x0000000180138110-0x00000001801381D0
	[Icon] // 0x0000000180138110-0x00000001801381D0
	[Name] // 0x0000000180138110-0x00000001801381D0
	public class CreateMovementTween : ActionTask<Rigidbody> // TypeDefIndex: 14503
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> Destination; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<bool> UseSnapping; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E8A8B0-0x0000000180E8A9D0 
	
		// Constructors
		public CreateMovementTween(); // 0x0000000180E8A870-0x0000000180E8A8B0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8A740-0x0000000180E8A870
	}
}
