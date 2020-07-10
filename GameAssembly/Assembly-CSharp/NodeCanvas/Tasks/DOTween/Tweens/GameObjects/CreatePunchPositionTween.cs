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
	[Category] // 0x0000000180145A70-0x0000000180145B30
	[Description] // 0x0000000180145A70-0x0000000180145B30
	[Icon] // 0x0000000180145A70-0x0000000180145B30
	[Name] // 0x0000000180145A70-0x0000000180145B30
	public class CreatePunchPositionTween : ActionTask // TypeDefIndex: 14521
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> PunchVector; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<int> Vibration; // 0x78
		public BBParameter<float> Elasticity; // 0x80
		public BBParameter<bool> UseSnapping; // 0x88
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000180E8B630-0x0000000180E8B770 
	
		// Constructors
		public CreatePunchPositionTween(); // 0x0000000180E8B560-0x0000000180E8B630
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8B3A0-0x0000000180E8B560
	}
}
