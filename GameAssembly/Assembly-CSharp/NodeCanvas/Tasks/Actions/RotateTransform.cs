/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028EF60-0x000000018028EF90
	public class RotateTransform : ActionTask<Transform> // TypeDefIndex: 15549
	{
		// Fields
		public BBParameter<Vector3> minRotation; // 0x68
		public BBParameter<Vector3> maxRotation; // 0x70
		public BBParameter<bool> local; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A1770-0x00000001807A1840 
	
		// Constructors
		public RotateTransform(); // 0x00000001807A1730-0x00000001807A1770
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A1350-0x00000001807A1730
	}
}
