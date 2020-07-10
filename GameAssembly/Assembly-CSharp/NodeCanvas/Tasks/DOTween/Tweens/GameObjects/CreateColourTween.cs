﻿/*
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
	[Category] // 0x000000018013F360-0x000000018013F420
	[Description] // 0x000000018013F360-0x000000018013F420
	[Icon] // 0x000000018013F360-0x000000018013F420
	[Name] // 0x000000018013F360-0x000000018013F420
	public class CreateColourTween : ActionTask<Renderer> // TypeDefIndex: 14512
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Color> NewColour; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E88DA0-0x0000000180E88ED0 
	
		// Constructors
		public CreateColourTween(); // 0x0000000180E889D0-0x0000000180E88A10
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E88690-0x0000000180E88790
	}
}