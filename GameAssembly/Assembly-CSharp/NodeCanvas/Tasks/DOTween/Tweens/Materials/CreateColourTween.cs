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

namespace NodeCanvas.Tasks.DOTween.Tweens.Materials
{
	[Category] // 0x000000018013A980-0x000000018013AA40
	[Description] // 0x000000018013A980-0x000000018013AA40
	[Icon] // 0x000000018013A980-0x000000018013AA40
	[Name] // 0x000000018013A980-0x000000018013AA40
	public class CreateColourTween : ActionTask // TypeDefIndex: 14506
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Material> Material; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Color> NewColour; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E88A90-0x0000000180E88BC0 
	
		// Constructors
		public CreateColourTween(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E88590-0x0000000180E88690
	}
}
