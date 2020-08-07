/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 9366
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x0077971B
		public const int elementId_rightPedal = 1; // Metadata: 0x0077971F
		public const int elementId_slide = 2; // Metadata: 0x00779723
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get; } // 0x000000018105CCA0-0x000000018105CCE0 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get; } // 0x000000018105CCE0-0x000000018105CD20 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get; } // 0x000000018105CD20-0x000000018105CD60 
	
		// Constructors
		public FlightPedalsTemplate(object payload); // 0x000000018105CDC0-0x000000018105CDD0
		static FlightPedalsTemplate(); // 0x000000018105CD60-0x000000018105CDC0
	}
}
