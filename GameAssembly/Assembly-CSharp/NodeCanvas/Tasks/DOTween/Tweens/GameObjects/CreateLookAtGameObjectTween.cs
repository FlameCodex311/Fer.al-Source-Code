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
	[Category] // 0x000000018013FE40-0x000000018013FF00
	[Description] // 0x000000018013FE40-0x000000018013FF00
	[Icon] // 0x000000018013FE40-0x000000018013FF00
	[Name] // 0x000000018013FE40-0x000000018013FF00
	public class CreateLookAtGameObjectTween : ActionTask<Rigidbody> // TypeDefIndex: 14514
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> LookAtObject; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public AxisConstraint AxisConstraint; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E89870-0x0000000180E89940 
	
		// Constructors
		public CreateLookAtGameObjectTween(); // 0x0000000180E89830-0x0000000180E89870
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E896D0-0x0000000180E89830
	}
}
