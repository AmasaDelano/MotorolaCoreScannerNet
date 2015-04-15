using System.Collections.Generic;
using CoreScanner;
using Motorola.Snapi.Constants;

namespace Motorola.Snapi.Attributes
{
    /// <summary>
    /// Provides properties for accessing and modifying SystemEvents attributes.
    /// These apply only to  SSI RS232 mode.
    /// </summary>
    public class SystemEvents : MotorolaAttributeSet
    {
        /// <summary>
        /// Initializes a SystemEvents object containing the current values of all System Event attributes for a given scanner.
        /// </summary>
        /// <param name="scannerId">ID number of the scanner to get/set data from.</param>
        /// <param name="scannerDriver">CCoreScanner instance</param>
        internal SystemEvents(int scannerId, CCoreScanner scannerDriver) : base(scannerId, scannerDriver){}

        /// <summary>
        /// Driver Attribute Name: DecodeEvent
        /// Description: When enabled, the scanner generates a message
        /// to the host whenever a bar code is successfully
        /// decoded. When disabled, no notification is sent
        /// Values: "On" (true), "Off" (false)
        /// </summary>
        public bool DecodeEventEnabled
        {
            get
            {
                return (bool)GetAttribute(SystemEventAttribute.DecodeEvent)
                                 .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = SystemEventAttribute.DecodeEvent, DataType = ValueConverters.TypeToDataType(typeof(bool)), Value = value });
            }
        }

        /// <summary>
        /// Driver Attribute Name: BootupEvent
        /// Description: When enabled, the scanner generates a message to the host
        /// whenever power is applied. When disabled, no notification is sent
        /// Values: "On" (true), "Off" (false)
        /// </summary>
        public bool BootupEventEnabled
        {
            get
            {
                return (bool)GetAttribute(SystemEventAttribute.BootupEvent)
                                 .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = SystemEventAttribute.BootupEvent, DataType = ValueConverters.TypeToDataType(typeof(bool)), Value = value });
            }
        }

        /// <summary>
        /// Driver Attribute Name: ParamEvent
        /// Description: When enabled, the scanner generates a message
        /// to the host when a parameter is changed.
        /// Values: "On" (true), "Off" (false)
        /// </summary>
        public bool ParamEventEnabled
        {
            get
            {
                return (bool)GetAttribute(SystemEventAttribute.ParamEvent)
                                 .Value;
            }
            set
            {
                SetAttribute(new ScannerAttribute { Id = SystemEventAttribute.ParamEvent, DataType = ValueConverters.TypeToDataType(typeof(bool)), Value = value });
            }
        }
    }
}