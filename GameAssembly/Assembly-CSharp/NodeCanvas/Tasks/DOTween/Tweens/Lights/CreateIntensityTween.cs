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

namespace NodeCanvas.Tasks.DOTween.Tweens.Lights
{
	[Category] // 0x000000018013E170-0x000000018013E230
	[Description] // 0x000000018013E170-0x000000018013E230
	[Icon] // 0x000000018013E170-0x000000018013E230
	[Name] // 0x000000018013E170-0x000000018013E230
	public class CreateIntensityTween : ActionTask<Light> // TypeDefIndex: 14509
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Intensity; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E89630-0x0000000180E896D0 
	
		// Constructors
		public CreateIntensityTween(); // 0x0000000180E895F0-0x0000000180E89630
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E89510-0x0000000180E895F0
	}
}
