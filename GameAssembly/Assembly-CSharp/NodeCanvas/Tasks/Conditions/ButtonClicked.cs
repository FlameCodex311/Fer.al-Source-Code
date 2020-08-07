/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023F270-0x000000018023F2A0
	public class ButtonClicked : ConditionTask // TypeDefIndex: 15268
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Button> button; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180792580-0x00000001807925E0 
	
		// Constructors
		public ButtonClicked(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override string OnInit(); // 0x00000001807924D0-0x0000000180792580
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void OnClick(); // 0x0000000180792470-0x0000000180792480
	}
}
