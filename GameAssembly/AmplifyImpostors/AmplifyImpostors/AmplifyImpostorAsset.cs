/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	[CreateAssetMenu] // 0x000000018016C8B0-0x000000018016C8F0
	public class AmplifyImpostorAsset : ScriptableObject // TypeDefIndex: 8919
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Material Material; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Mesh Mesh; // 0x20
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public int Version; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public ImpostorType ImpostorType; // 0x2C
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public bool LockedSizes; // 0x30
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public int SelectedSize; // 0x34
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector2 TexSize; // 0x38
		[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		public bool DecoupleAxisFrames; // 0x40
		[Range] // 0x000000018016EAD0-0x000000018016EB10
		[SerializeField] // 0x000000018016EAD0-0x000000018016EB10
		public int HorizontalFrames; // 0x44
		[Range] // 0x000000018016EC70-0x000000018016ECB0
		[SerializeField] // 0x000000018016EC70-0x000000018016ECB0
		public int VerticalFrames; // 0x48
		[Range] // 0x000000018016EE30-0x000000018016EE70
		[SerializeField] // 0x000000018016EE30-0x000000018016EE70
		public int PixelPadding; // 0x4C
		[Range] // 0x000000018016F390-0x000000018016F3D0
		[SerializeField] // 0x000000018016F390-0x000000018016F3D0
		public int MaxVertices; // 0x50
		[Range] // 0x00000001800F7150-0x00000001800F7190
		[SerializeField] // 0x00000001800F7150-0x00000001800F7190
		public float Tolerance; // 0x54
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		public float NormalScale; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public Vector2[] ShapePoints; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public AmplifyImpostorBakePreset Preset; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<TextureOutput> OverrideOutput; // 0x70
	
		// Constructors
		public AmplifyImpostorAsset(); // 0x00000001822ACF80-0x00000001822AD300
	}
}
