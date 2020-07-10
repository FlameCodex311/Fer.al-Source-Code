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
	[Category] // 0x00000001800CAE50-0x00000001800CAE80
	public class CreateGameObject : ActionTask // TypeDefIndex: 14257
	{
		// Fields
		public BBParameter<string> objectName; // 0x68
		public BBParameter<Vector3> position; // 0x70
		public BBParameter<Vector3> rotation; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveAs; // 0x80
	
		// Constructors
		public CreateGameObject(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018174C690-0x000000018174C820
	}
}
