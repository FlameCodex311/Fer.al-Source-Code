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
	[Category] // 0x000000018013E5B0-0x000000018013E670
	[Description] // 0x000000018013E5B0-0x000000018013E670
	[Icon] // 0x000000018013E5B0-0x000000018013E670
	[Name] // 0x000000018013E5B0-0x000000018013E670
	public class CreateShadowStrengthTween : ActionTask<Light> // TypeDefIndex: 14510
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> ShadowStrength; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E8C5D0-0x0000000180E8C680 
	
		// Constructors
		public CreateShadowStrengthTween(); // 0x0000000180E8C590-0x0000000180E8C5D0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8C4B0-0x0000000180E8C590
	}
}
