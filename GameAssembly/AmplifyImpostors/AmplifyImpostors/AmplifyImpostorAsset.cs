/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	[CreateAssetMenu] // 0x000000018020AE10-0x000000018020AE50
	public class AmplifyImpostorAsset : ScriptableObject // TypeDefIndex: 9085
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Material Material; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Mesh Mesh; // 0x20
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public int Version; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ImpostorType ImpostorType; // 0x2C
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public bool LockedSizes; // 0x30
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public int SelectedSize; // 0x34
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Vector2 TexSize; // 0x38
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		public bool DecoupleAxisFrames; // 0x40
		[Range] // 0x000000018020BCF0-0x000000018020BD30
		[SerializeField] // 0x000000018020BCF0-0x000000018020BD30
		public int HorizontalFrames; // 0x44
		[Range] // 0x000000018020BF80-0x000000018020BFC0
		[SerializeField] // 0x000000018020BF80-0x000000018020BFC0
		public int VerticalFrames; // 0x48
		[Range] // 0x000000018020C260-0x000000018020C2A0
		[SerializeField] // 0x000000018020C260-0x000000018020C2A0
		public int PixelPadding; // 0x4C
		[Range] // 0x000000018020C410-0x000000018020C450
		[SerializeField] // 0x000000018020C410-0x000000018020C450
		public int MaxVertices; // 0x50
		[Range] // 0x000000018020C740-0x000000018020C780
		[SerializeField] // 0x000000018020C740-0x000000018020C780
		public float Tolerance; // 0x54
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		public float NormalScale; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Vector2[] ShapePoints; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public AmplifyImpostorBakePreset Preset; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<TextureOutput> OverrideOutput; // 0x70
	
		// Constructors
		public AmplifyImpostorAsset(); // 0x00000001820849B0-0x0000000182084D10
	}
}
