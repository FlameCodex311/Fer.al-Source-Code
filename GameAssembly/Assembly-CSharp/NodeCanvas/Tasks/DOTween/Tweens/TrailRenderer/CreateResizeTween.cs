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

namespace NodeCanvas.Tasks.DOTween.Tweens.TrailRenderer
{
	[Category] // 0x0000000180136DC0-0x0000000180136E80
	[Description] // 0x0000000180136DC0-0x0000000180136E80
	[Icon] // 0x0000000180136DC0-0x0000000180136E80
	[Name] // 0x0000000180136DC0-0x0000000180136E80
	public class CreateResizeTween : ActionTask<TrailRenderer> // TypeDefIndex: 14500
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> StartSize; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> EndSize; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E8BE40-0x0000000180E8BEF0 
	
		// Constructors
		public CreateResizeTween(); // 0x0000000180E8BE00-0x0000000180E8BE40
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8BCE0-0x0000000180E8BE00
	}
}
