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
	[Category] // 0x00000001801DBA20-0x00000001801DBAE0
	[Description] // 0x00000001801DBA20-0x00000001801DBAE0
	[Icon] // 0x00000001801DBA20-0x00000001801DBAE0
	[Name] // 0x00000001801DBA20-0x00000001801DBAE0
	public class CreateMovementTween : ActionTask<Rigidbody> // TypeDefIndex: 15612
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> Destination; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<bool> UseSnapping; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807FAA90-0x00000001807FABB0 
	
		// Constructors
		public CreateMovementTween(); // 0x00000001807FAA50-0x00000001807FAA90
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FA920-0x00000001807FAA50
	}
}
