/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ThisOtherThing.Utils.Animation
{
	[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
	public class ValueSetter : MonoBehaviour // TypeDefIndex: 13939
	{
		// Fields
		public static BindingFlags binding; // 0x00
		public int FieldType; // 0x20
		public bool IsInArray; // 0x24
		public int ArrayItemIndex; // 0x28
		public bool IsInClass; // 0x2C
		public string TargetTypeName; // 0x30
		public string TargetFieldName; // 0x38
		public string FieldName; // 0x40
		public string ArrayFieldName; // 0x48
		public string TargetClassFieldName; // 0x50
		public string ClassFieldName; // 0x58
		public float FloatValue; // 0x60
		public Color ColorValue; // 0x64
		private float cachedFloatValue; // 0x74
		private Color cachedColorValue; // 0x78
		private bool cachedBoolValue; // 0x88
		private IShape target; // 0x90
		private object targetField; // 0x98
		private FieldInfo fieldInfo; // 0xA0
	
		// Constructors
		public ValueSetter(); // 0x0000000181A0F2B0-0x0000000181A0F2C0
		static ValueSetter(); // 0x0000000181A0FA90-0x0000000181A0FAD0
	
		// Methods
		private void OnValidate(); // 0x0000000181A0F2C0-0x0000000181A0F2D0
		private void Start(); // 0x0000000181A0F2C0-0x0000000181A0F2D0
		private void Update(); // 0x0000000181A0F8C0-0x0000000181A0FA90
		private void UpdateCachedReferences(); // 0x0000000181A0F2D0-0x0000000181A0F8C0
	}
}
