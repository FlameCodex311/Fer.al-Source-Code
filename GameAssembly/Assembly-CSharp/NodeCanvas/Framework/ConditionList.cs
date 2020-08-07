/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[DoNotList] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class ConditionList : ConditionTask // TypeDefIndex: 15724
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
	
		// Properties
		private bool allTrueRequired { get; } // 0x00000001808A22F0-0x00000001808A2300 
		protected override string info { get; } // 0x00000001808A2300-0x00000001808A2510 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 15725
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		// Constructors
		public ConditionList(); // 0x00000001808A2280-0x00000001808A22F0
	
		// Methods
		public override Task Duplicate(ITaskSystem newOwnerSystem); // 0x00000001808A1B20-0x00000001808A1D80
		protected override void OnEnable(); // 0x00000001808A2160-0x00000001808A2280
		protected override void OnDisable(); // 0x00000001808A1F90-0x00000001808A2060
		protected override bool OnCheck(); // 0x00000001808A1E40-0x00000001808A1F90
		public override void OnDrawGizmosSelected(); // 0x00000001808A2060-0x00000001808A2160
		public void AddCondition(ConditionTask condition); // 0x00000001808A1900-0x00000001808A1B20
		internal override string GetWarningOrError(); // 0x00000001808A1D80-0x00000001808A1E40
	}
}
