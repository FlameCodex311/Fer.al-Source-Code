/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	[CustomObfuscation] // 0x00000001800BCF20-0x00000001800BCF70
	internal interface IHardwareControllerTemplateMap_Internal // TypeDefIndex: 6235
	{
		// Properties
		string name { get; }
		Guid typeGuid { get; }
	
		// Methods
		int GetElementIdentifierCount();
		IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);
		IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);
		IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);
		oDhSVhqolYnpfNXmoDZvnEklacS GetAxisTarget(Controller controller, int elementIdentifierId);
		oDhSVhqolYnpfNXmoDZvnEklacS GetButtonTarget(Controller controller, int elementIdentifierId);
	}
}
