/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech.CustomAttributes
{
	public class PathAttribute : PropertyAttribute // TypeDefIndex: 13932
	{
		// Fields
		public readonly SelectionType PathType; // 0x18
		public readonly string FileExtension; // 0x20
		public readonly bool RelativeToAssetsFolder; // 0x28
	
		// Nested types
		public enum SelectionType // TypeDefIndex: 13933
		{
			Folder = 0,
			File = 1
		}
	
		// Constructors
		public PathAttribute(string fileExtension, bool relativeToAssetsFolder = false /* Metadata: 0x00784268 */); // 0x0000000181356C60-0x0000000181356CE0
		public PathAttribute(SelectionType pathType, bool relativeToAssetsFolder = false /* Metadata: 0x00784269 */); // 0x0000000181356B90-0x0000000181356C00
		public PathAttribute(bool relativeToAssetsFolder = false /* Metadata: 0x0078426A */); // 0x0000000181356C00-0x0000000181356C60
	}
}
