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
	[Category] // 0x000000018014CC10-0x000000018014CCD0
	[Description] // 0x000000018014CC10-0x000000018014CCD0
	[Icon] // 0x000000018014CC10-0x000000018014CCD0
	[Name] // 0x000000018014CC10-0x000000018014CCD0
	public class CreatePitchTween : ActionTask<AudioSource> // TypeDefIndex: 14537
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Pitch; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001812568E0-0x0000000181256980 
	
		// Constructors
		public CreatePitchTween(); // 0x00000001812568A0-0x00000001812568E0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812567C0-0x00000001812568A0
	}
}
