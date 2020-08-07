/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChartDataObject : MonoBehaviour // TypeDefIndex: 10994
{
	// Properties
	public virtual string ChartName { get; } // 0x000000018049EA10-0x000000018049EA40 
	public virtual bool RequireEncryption { get; } // 0x0000000180380B60-0x0000000180380B70 
	public string DatabaseFilenameNoExtension { get; } // 0x000000018049EA40-0x000000018049EBD0 
	public string DatabaseFilename { get; } // 0x000000018049EBD0-0x000000018049EC20 
	public string DatabaseHashFilename { get; } // 0x000000018049EC20-0x000000018049EC70 
	public virtual string DatabaseName { get; } // 0x000000018049EC70-0x000000018049ECA0 
	public virtual bool Localized { get; } // 0x0000000180380950-0x0000000180380960 
	public virtual bool PlatformSpecific { get; } // 0x0000000180380950-0x0000000180380960 
	public virtual bool SortInEditor { get; } // 0x0000000180380950-0x0000000180380960 

	// Constructors
	public ChartDataObject(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public virtual BaseDef GetDef(string inDefID, bool inShowErrors = false /* Metadata: 0x0077C5FB */); // 0x000000018037DDC0-0x000000018037DDD0
	public virtual List<ValueTuple<string, string>> GetAllDefIDs(); // 0x000000018037DDC0-0x000000018037DDD0
}

