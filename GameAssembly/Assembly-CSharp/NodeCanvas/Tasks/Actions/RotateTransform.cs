/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180122E10-0x0000000180122E40
	public class RotateTransform : ActionTask<Transform> // TypeDefIndex: 14443
	{
		// Fields
		public BBParameter<Vector3> minRotation; // 0x68
		public BBParameter<Vector3> maxRotation; // 0x70
		public BBParameter<bool> local; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018125CB30-0x000000018125CC10 
	
		// Constructors
		public RotateTransform(); // 0x000000018125CAF0-0x000000018125CB30
	
		// Methods
		protected override void OnExecute(); // 0x000000018125C6F0-0x000000018125CAF0
	}
}
