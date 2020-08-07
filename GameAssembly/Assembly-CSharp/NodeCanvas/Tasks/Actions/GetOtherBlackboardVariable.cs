/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018024ADA0-0x000000018024AE00
	[Description] // 0x000000018024ADA0-0x000000018024AE00
	public class GetOtherBlackboardVariable : ActionTask<Blackboard> // TypeDefIndex: 15318
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> targetVariableName; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBObjectParameter saveAs; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BAFE70-0x0000000180BAFEB0 
	
		// Constructors
		public GetOtherBlackboardVariable(); // 0x0000000180BAFE30-0x0000000180BAFE70
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAFD60-0x0000000180BAFE30
	}
}
