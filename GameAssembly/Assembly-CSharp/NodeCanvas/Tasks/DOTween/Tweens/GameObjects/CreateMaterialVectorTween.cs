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

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801E7100-0x00000001801E71C0
	[Description] // 0x00000001801E7100-0x00000001801E71C0
	[Icon] // 0x00000001801E7100-0x00000001801E71C0
	[Name] // 0x00000001801E7100-0x00000001801E71C0
	public class CreateMaterialVectorTween : ActionTask<Renderer> // TypeDefIndex: 15626
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> Value; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> PropertyName; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807FA370-0x00000001807FA420 
	
		// Constructors
		public CreateMaterialVectorTween(); // 0x00000001807FA330-0x00000001807FA370
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FA1B0-0x00000001807FA330
	}
}
