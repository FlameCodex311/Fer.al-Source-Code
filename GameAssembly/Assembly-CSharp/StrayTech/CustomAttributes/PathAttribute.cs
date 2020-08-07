/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech.CustomAttributes
{
	public class PathAttribute : PropertyAttribute // TypeDefIndex: 14600
	{
		// Fields
		public readonly SelectionType PathType; // 0x18
		public readonly string FileExtension; // 0x20
		public readonly bool RelativeToAssetsFolder; // 0x28
	
		// Nested types
		public enum SelectionType // TypeDefIndex: 14601
		{
			Folder = 0,
			File = 1
		}
	
		// Constructors
		public PathAttribute(string fileExtension, bool relativeToAssetsFolder = false /* Metadata: 0x007BAD2B */); // 0x0000000180CB62A0-0x0000000180CB6320
		public PathAttribute(SelectionType pathType, bool relativeToAssetsFolder = false /* Metadata: 0x007BAD2C */); // 0x0000000180CB61D0-0x0000000180CB6240
		public PathAttribute(bool relativeToAssetsFolder = false /* Metadata: 0x007BAD2D */); // 0x0000000180CB6240-0x0000000180CB62A0
	}
}
