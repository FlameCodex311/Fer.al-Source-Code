/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DAE30-0x00000001800DAE60
	public class ButtonClicked : ConditionTask // TypeDefIndex: 14166
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Button> button; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018124D950-0x000000018124D9B0 
	
		// Constructors
		public ButtonClicked(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override string OnInit(); // 0x000000018124D890-0x000000018124D940
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		private void OnClick(); // 0x000000018124D880-0x000000018124D890
	}
}
