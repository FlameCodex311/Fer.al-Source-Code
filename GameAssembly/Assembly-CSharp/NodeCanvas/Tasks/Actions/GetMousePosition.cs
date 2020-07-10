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
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class GetMousePosition : ActionTask // TypeDefIndex: 14280
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveAs; // 0x68
		public bool repeat; // 0x70
	
		// Constructors
		public GetMousePosition(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181549BB0-0x0000000181549BC0
		protected override void OnUpdate(); // 0x0000000181549BB0-0x0000000181549BC0
		private void Do(); // 0x0000000181549B20-0x0000000181549BB0
	}
}
