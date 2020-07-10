/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D14A0-0x00000001800D1500
	[Description] // 0x00000001800D14A0-0x00000001800D1500
	public class CheckStaticCSharpEvent<T> : ConditionTask // TypeDefIndex: 14150
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Type targetType;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string eventName;
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		private BBParameter<T> saveAs;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckStaticCSharpEvent();
	
		// Methods
		protected override string OnInit();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnInit>b__5_0(T v);
	}
}
