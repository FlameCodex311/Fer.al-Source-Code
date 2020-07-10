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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180126F50-0x0000000180126FB0
	[Description] // 0x0000000180126F50-0x0000000180126FB0
	public class SelectTransformFromList : ActionTask // TypeDefIndex: 14448
	{
		// Fields
		public List<Transform> transforms; // 0x68
		public SelectType selectType; // 0x70
		[ShowIf] // 0x0000000180127190-0x00000001801271C0
		public BBParameter<int> index; // 0x78
		public BBParameter<Transform> result; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018125DAC0-0x000000018125DB40 
	
		// Nested types
		public enum SelectType // TypeDefIndex: 14449
		{
			IndexBased = 0,
			Random = 1
		}
	
		// Constructors
		public SelectTransformFromList(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018125D910-0x000000018125DAC0
	}
}
