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
	[Category] // 0x00000001800D3570-0x00000001800D35D0
	[Description] // 0x00000001800D3570-0x00000001800D35D0
	public class CheckUnityEventValue<T> : ConditionTask // TypeDefIndex: 14153
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Type targetType;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string eventName;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BBParameter<T> checkValue;
	
		// Properties
		public override Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckUnityEventValue();
	
		// Methods
		protected override string OnInit();
		public void Raised(T eventValue);
		protected override bool OnCheck();
	}
}
