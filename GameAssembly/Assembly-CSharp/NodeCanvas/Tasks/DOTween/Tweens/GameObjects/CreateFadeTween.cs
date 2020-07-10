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
	[Category] // 0x000000018013F990-0x000000018013FA50
	[Description] // 0x000000018013F990-0x000000018013FA50
	[Icon] // 0x000000018013F990-0x000000018013FA50
	[Name] // 0x000000018013F990-0x000000018013FA50
	public class CreateFadeTween : ActionTask<Renderer> // TypeDefIndex: 14513
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Opacity; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180E89010-0x0000000180E890B0 
	
		// Constructors
		public CreateFadeTween(); // 0x0000000180E88FD0-0x0000000180E89010
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E88ED0-0x0000000180E88FD0
	}
}
