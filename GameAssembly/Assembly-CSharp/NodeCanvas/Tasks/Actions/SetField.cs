/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180103F60-0x0000000180103FE0
	[Description] // 0x0000000180103F60-0x0000000180103FE0
	[Name] // 0x0000000180103F60-0x0000000180103FE0
	public class SetField : ActionTask // TypeDefIndex: 14312
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBObjectParameter setValue; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Type targetType; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string fieldName; // 0x78
		private FieldInfo field; // 0x80
	
		// Properties
		public override Type agentType { get; } // 0x000000018125F7E0-0x000000018125F850 
		protected override string info { get; } // 0x000000018125F850-0x000000018125F8C0 
	
		// Constructors
		public SetField(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override string OnInit(); // 0x000000018125F720-0x000000018125F7E0
		protected override void OnExecute(); // 0x000000018125F680-0x000000018125F720
	}
}
