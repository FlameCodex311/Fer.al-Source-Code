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
	public class ActionList : ActionTask // TypeDefIndex: 15719
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private int currentActionIndex; // 0x78
		private bool[] finishedIndeces; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018089E670-0x000000018089E840 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 15720
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		// Constructors
		public ActionList(); // 0x000000018089E600-0x000000018089E670
	
		// Methods
		public override Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018089DAB0-0x000000018089DD10
		protected override string OnInit(); // 0x000000018089DF60-0x000000018089DFC0
		protected override void OnExecute(); // 0x000000018089DED0-0x000000018089DF60
		protected override void OnUpdate(); // 0x000000018089E1E0-0x000000018089E600
		protected override void OnStop(); // 0x000000018089E0D0-0x000000018089E1E0
		protected override void OnPause(); // 0x000000018089DFC0-0x000000018089E0D0
		public override void OnDrawGizmosSelected(); // 0x000000018089DDD0-0x000000018089DED0
		public void AddAction(ActionTask action); // 0x000000018089D890-0x000000018089DAB0
		internal override string GetWarningOrError(); // 0x000000018089DD10-0x000000018089DDD0
	}
}
