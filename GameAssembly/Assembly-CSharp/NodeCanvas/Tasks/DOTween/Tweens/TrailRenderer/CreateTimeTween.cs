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
	[Category] // 0x0000000180137470-0x0000000180137530
	[Description] // 0x0000000180137470-0x0000000180137530
	[Icon] // 0x0000000180137470-0x0000000180137530
	[Name] // 0x0000000180137470-0x0000000180137530
	public class CreateTimeTween : ActionTask<TrailRenderer> // TypeDefIndex: 14501
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> EndValue; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E8D4E0-0x0000000180E8D580 
	
		// Constructors
		public CreateTimeTween(); // 0x0000000180E8D4A0-0x0000000180E8D4E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8D3C0-0x0000000180E8D4A0
	}
}
