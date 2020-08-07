/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802907F0-0x0000000180290850
	[Description] // 0x00000001802907F0-0x0000000180290850
	public class SelectTransformFromList : ActionTask // TypeDefIndex: 15554
	{
		// Fields
		public List<Transform> transforms; // 0x68
		public SelectType selectType; // 0x70
		[ShowIf] // 0x0000000180290A90-0x0000000180290AC0
		public BBParameter<int> index; // 0x78
		public BBParameter<Transform> result; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807A2660-0x00000001807A26E0 
	
		// Nested types
		public enum SelectType // TypeDefIndex: 15555
		{
			IndexBased = 0,
			Random = 1
		}
	
		// Constructors
		public SelectTransformFromList(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A24C0-0x00000001807A2660
	}
}
