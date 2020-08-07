/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[AddComponentMenu] // 0x0000000180207C50-0x0000000180207CD0
	[RequireComponent] // 0x0000000180207C50-0x0000000180207CD0
	public class TextContainer : UIBehaviour // TypeDefIndex: 9058
	{
		// Fields
		private bool m_hasChanged; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 m_pivot; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextContainerAnchors m_anchorPosition; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public Vector2 pivot { get; set; } // 0x0000000180D43A20-0x0000000180D43A40 0x0000000180D43E80-0x0000000180D43F40
		public TextContainerAnchors anchorPosition { get; set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180D43BB0-0x0000000180D43D00
		public Rect rect { get; set; } // 0x0000000180379E90-0x0000000180379EA0 0x0000000180D43F40-0x0000000180D43FA0
		public Vector2 size { get; set; } // 0x0000000180D43AC0-0x0000000180D43B20 0x0000000180D43FA0-0x0000000180D440D0
		public float width { get; set; } // 0x0000000180D43BA0-0x0000000180D43BB0 0x0000000180D440D0-0x0000000180D441B0
		public float height { get; set; } // 0x0000000180D43A10-0x0000000180D43A20 0x0000000180D43D00-0x0000000180D43DE0
		public bool isDefaultWidth { get; } // 0x0000000180379B20-0x0000000180379B30 
		public bool isDefaultHeight { get; } // 0x00000001804F1610-0x00000001804F1620 
		public bool isAutoFitting { get; set; } // 0x00000001804F1650-0x00000001804F1660 0x00000001804F16B0-0x00000001804F16C0
		public Vector3[] corners { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public Vector3[] worldCorners { get; } // 0x00000001803743E0-0x00000001803743F0 
		public Vector4 margins { get; set; } // 0x00000001809C9FD0-0x00000001809C9FE0 0x0000000180D43DE0-0x0000000180D43E80
		public RectTransform rectTransform { get; } // 0x0000000180D43A40-0x0000000180D43AC0 
		public TextMeshPro textMeshPro { get; } // 0x0000000180D43B20-0x0000000180D43BA0 
	
		// Constructors
		public TextContainer(); // 0x0000000180D439A0-0x0000000180D43A10
		static TextContainer(); // 0x0000000180D43930-0x0000000180D439A0
	
		// Methods
		protected override void Awake(); // 0x0000000180D42AC0-0x0000000180D42B60
		protected override void OnEnable(); // 0x0000000180D431B0-0x0000000180D431C0
		protected override void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
		private void OnContainerChanged(); // 0x0000000180D42FD0-0x0000000180D431B0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180D431C0-0x0000000180D43560
		private void SetRect(Vector2 size); // 0x0000000180D43560-0x0000000180D435E0
		private void UpdateCorners(); // 0x0000000180D435E0-0x0000000180D43930
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x0000000180D42EB0-0x0000000180D42FD0
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x0000000180D42B60-0x0000000180D42EB0
	}
}
