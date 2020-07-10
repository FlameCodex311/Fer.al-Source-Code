/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired
{
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate // TypeDefIndex: 9200
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_leftPedal = 0; // Metadata: 0x00744A2D
		public const int elementId_rightPedal = 1; // Metadata: 0x00744A31
		public const int elementId_slide = 2; // Metadata: 0x00744A35
	
		// Properties
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal { get; } // 0x0000000181BBD660-0x0000000181BBD6A0 
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal { get; } // 0x0000000181BBD6A0-0x0000000181BBD6E0 
		IControllerTemplateAxis IFlightPedalsTemplate.slide { get; } // 0x0000000181BBD6E0-0x0000000181BBD720 
	
		// Constructors
		public FlightPedalsTemplate(object payload); // 0x0000000181BBD780-0x0000000181BBD790
		static FlightPedalsTemplate(); // 0x0000000181BBD720-0x0000000181BBD780
	}
}
