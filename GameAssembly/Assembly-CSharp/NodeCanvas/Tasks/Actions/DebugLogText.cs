/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180271500-0x0000000180271580
	[Description] // 0x0000000180271500-0x0000000180271580
	[Name] // 0x0000000180271500-0x0000000180271580
	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 15430
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> log; // 0x68
		public float labelYOffset; // 0x70
		public float secondsToRun; // 0x74
		public VerboseMode verboseMode; // 0x78
		public LogMode logMode; // 0x7C
		public CompactStatus finishStatus; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180CC24A0-0x0000000180CC2570 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 15431
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 15432
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText(); // 0x0000000180CC2440-0x0000000180CC24A0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC1E80-0x0000000180CC1FA0
		protected override void OnStop(); // 0x0000000180CC2360-0x0000000180CC2400
		protected override void OnUpdate(); // 0x0000000180CC2400-0x0000000180CC2440
		private void OnGUI(); // 0x0000000180CC1FA0-0x0000000180CC2360
	}
}
