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

namespace NodeCanvas.Tasks.DOTween.Tweens.LineRenderer
{
	[Category] // 0x000000018013C2F0-0x000000018013C3B0
	[Description] // 0x000000018013C2F0-0x000000018013C3B0
	[Icon] // 0x000000018013C2F0-0x000000018013C3B0
	[Name] // 0x000000018013C2F0-0x000000018013C3B0
	public class CreateColourTween : ActionTask<LineRenderer> // TypeDefIndex: 14507
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Color> StartColour; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Color> EndColour; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E88CF0-0x0000000180E88DA0 
	
		// Constructors
		public CreateColourTween(); // 0x0000000180E88A50-0x0000000180E88A90
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E88790-0x0000000180E889D0
	}
}
