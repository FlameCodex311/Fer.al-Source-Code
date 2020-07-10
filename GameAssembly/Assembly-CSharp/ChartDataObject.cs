/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChartDataObject : MonoBehaviour // TypeDefIndex: 13323
{
	// Properties
	public virtual string ChartName { get; } // 0x00000001810260B0-0x00000001810260E0 
	public virtual bool RequireEncryption { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	public string DatabaseFilenameNoExtension { get; } // 0x00000001810260E0-0x0000000181026270 
	public string DatabaseFilename { get; } // 0x0000000181026270-0x00000001810262C0 
	public string DatabaseHashFilename { get; } // 0x00000001810262C0-0x0000000181026310 
	public virtual string DatabaseName { get; } // 0x0000000181026310-0x0000000181026340 
	public virtual bool Localized { get; } // 0x00000001803C28F0-0x00000001803C2900 
	public virtual bool PlatformSpecific { get; } // 0x00000001803C28F0-0x00000001803C2900 
	public virtual bool SortInEditor { get; } // 0x00000001803C28F0-0x00000001803C2900 

	// Constructors
	public ChartDataObject(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public virtual BaseDef GetDef(string inDefID, bool inShowErrors = false /* Metadata: 0x00783B32 */); // 0x000000018035FCC0-0x000000018035FCD0
	public virtual List<ValueTuple<string, string>> GetAllDefIDs(); // 0x000000018035FCC0-0x000000018035FCD0
}

