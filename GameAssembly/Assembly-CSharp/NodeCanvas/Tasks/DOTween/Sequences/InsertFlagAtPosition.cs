/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category] // 0x00000001801519E0-0x0000000180151AA0
	[Description] // 0x00000001801519E0-0x0000000180151AA0
	[Icon] // 0x00000001801519E0-0x0000000180151AA0
	[Name] // 0x00000001801519E0-0x0000000180151AA0
	public class InsertFlagAtPosition : ActionTask // TypeDefIndex: 14542
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<bool> FlagVariable; // 0x70
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> TimePosition; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181256D20-0x0000000181256DD0 
	
		// Constructors
		public InsertFlagAtPosition(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181256C00-0x0000000181256CD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__5_0(); // 0x0000000181256CD0-0x0000000181256D20
	}
}
