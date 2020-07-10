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
	[Category] // 0x0000000180146AE0-0x0000000180146BA0
	[Description] // 0x0000000180146AE0-0x0000000180146BA0
	[Icon] // 0x0000000180146AE0-0x0000000180146BA0
	[Name] // 0x0000000180146AE0-0x0000000180146BA0
	public class CreateRotationTween : ActionTask // TypeDefIndex: 14523
	{
		// Fields
		public BBParameter<Vector3> DestinationRotation; // 0x68
		public BBParameter<GameObject> DestinationGameObject; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		public RotateMode RotateMode; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8C210-0x0000000180E8C3E0 
	
		// Constructors
		public CreateRotationTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8BEF0-0x0000000180E8C0D0
	}
}
