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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category] // 0x00000001801DD490-0x00000001801DD550
	[Description] // 0x00000001801DD490-0x00000001801DD550
	[Icon] // 0x00000001801DD490-0x00000001801DD550
	[Name] // 0x00000001801DD490-0x00000001801DD550
	public class CreateRotationTween : ActionTask<Rigidbody> // TypeDefIndex: 15613
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> Rotation; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public RotateMode RotateMode; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807FC770-0x00000001807FC840 
	
		// Constructors
		public CreateRotationTween(); // 0x00000001807FC570-0x00000001807FC5B0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FC470-0x00000001807FC570
	}
}
