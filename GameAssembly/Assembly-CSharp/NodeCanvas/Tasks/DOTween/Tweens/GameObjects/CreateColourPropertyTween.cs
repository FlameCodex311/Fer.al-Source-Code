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
	[Category] // 0x000000018013EBA0-0x000000018013EC60
	[Description] // 0x000000018013EBA0-0x000000018013EC60
	[Icon] // 0x000000018013EBA0-0x000000018013EC60
	[Name] // 0x000000018013EBA0-0x000000018013EC60
	public class CreateColourPropertyTween : ActionTask<Renderer> // TypeDefIndex: 14511
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Color> NewColour; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> PropertyName; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E883C0-0x0000000180E884B0 
	
		// Constructors
		public CreateColourPropertyTween(); // 0x0000000180E88290-0x0000000180E882D0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E88020-0x0000000180E88160
	}
}
