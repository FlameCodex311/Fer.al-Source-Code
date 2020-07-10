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
	[Category] // 0x0000000180140AB0-0x0000000180140B70
	[Description] // 0x0000000180140AB0-0x0000000180140B70
	[Icon] // 0x0000000180140AB0-0x0000000180140B70
	[Name] // 0x0000000180140AB0-0x0000000180140B70
	public class CreateMaterialFloatTween : ActionTask<Renderer> // TypeDefIndex: 14516
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Value; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> PropertyName; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180E89F00-0x0000000180E89FB0 
	
		// Constructors
		public CreateMaterialFloatTween(); // 0x0000000180E89EC0-0x0000000180E89F00
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E89D80-0x0000000180E89EC0
	}
}
