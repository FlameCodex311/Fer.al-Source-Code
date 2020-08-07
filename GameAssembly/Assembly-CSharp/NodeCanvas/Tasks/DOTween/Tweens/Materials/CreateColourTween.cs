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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.Materials
{
	[Category] // 0x00000001801DE9E0-0x00000001801DEAA0
	[Description] // 0x00000001801DE9E0-0x00000001801DEAA0
	[Icon] // 0x00000001801DE9E0-0x00000001801DEAA0
	[Name] // 0x00000001801DE9E0-0x00000001801DEAA0
	public class CreateColourTween : ActionTask // TypeDefIndex: 15615
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Material> Material; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> NewColour; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F8AF0-0x00000001807F8C20 
	
		// Constructors
		public CreateColourTween(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F85F0-0x00000001807F86F0
	}
}
