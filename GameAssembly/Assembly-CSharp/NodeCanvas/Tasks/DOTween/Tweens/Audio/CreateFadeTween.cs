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

namespace NodeCanvas.Tasks.DOTween.Tweens.Audio
{
	[Category] // 0x000000018014C220-0x000000018014C2E0
	[Description] // 0x000000018014C220-0x000000018014C2E0
	[Icon] // 0x000000018014C220-0x000000018014C2E0
	[Name] // 0x000000018014C220-0x000000018014C2E0
	public class CreateFadeTween : ActionTask<AudioSource> // TypeDefIndex: 14536
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Fade; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181256720-0x00000001812567C0 
	
		// Constructors
		public CreateFadeTween(); // 0x00000001812566E0-0x0000000181256720
	
		// Methods
		protected override void OnExecute(); // 0x0000000181256600-0x00000001812566E0
	}
}
