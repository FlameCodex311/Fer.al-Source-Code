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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180108480-0x00000001801084E0
	[Description] // 0x0000000180108480-0x00000001801084E0
	public class DebugLogText : ActionTask<Transform> // TypeDefIndex: 14327
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> log; // 0x68
		public float labelYOffset; // 0x70
		public float secondsToRun; // 0x74
		public VerboseMode verboseMode; // 0x78
		public LogMode logMode; // 0x7C
		public CompactStatus finishStatus; // 0x80
		private Texture2D _tex; // 0x88
	
		// Properties
		protected override string info { get; } // 0x000000018174E3D0-0x000000018174E4A0 
		private Texture2D tex { get; } // 0x000000018174E4A0-0x000000018174E590 
	
		// Nested types
		public enum LogMode // TypeDefIndex: 14328
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}
	
		public enum VerboseMode // TypeDefIndex: 14329
		{
			LogAndDisplayLabel = 0,
			LogOnly = 1,
			DisplayLabelOnly = 2
		}
	
		// Constructors
		public DebugLogText(); // 0x000000018174E370-0x000000018174E3D0
	
		// Methods
		protected override void OnExecute(); // 0x000000018174DB80-0x000000018174DDD0
		protected override void OnStop(); // 0x000000018174E290-0x000000018174E330
		protected override void OnUpdate(); // 0x000000018174E330-0x000000018174E370
		private void OnGUI(); // 0x000000018174DDD0-0x000000018174E290
	}
}
