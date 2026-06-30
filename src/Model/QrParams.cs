
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Optional QR barcode generation parameters. Applies to QR, GS1QR, MicroQR, and RectMicroQR barcode types.
    /// </summary>
    public class QrParams : IToString
    {
        /// <summary>
        ///     QR barcode encode mode.
        /// </summary>
        public QREncodeMode? QrEncodeMode { get; set; }

        /// <summary>
        ///     QR barcode error correction level.
        /// </summary>
        public QRErrorLevel? QrErrorLevel { get; set; }

        /// <summary>
        ///     QR barcode version. Automatically selects the smallest version that fits the data.
        /// </summary>
        public QRVersion? QrVersion { get; set; }

        /// <summary>
        ///     ECI encoding for QR barcode data.
        /// </summary>
        public ECIEncodings? QrECIEncoding { get; set; }

        /// <summary>
        ///     MicroQR barcode version. Used when BarcodeType is MicroQR.
        /// </summary>
        public MicroQRVersion? MicroQRVersion { get; set; }

        /// <summary>
        ///     RectMicroQR barcode version. Used when BarcodeType is RectMicroQR.
        /// </summary>
        public RectMicroQRVersion? RectMicroQrVersion { get; set; }

        /// <summary>
        ///     QR barcode aspect ratio. Values: 0 to 1.
        /// </summary>
        public float? QrAspectRatio { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return _srcString ?? SerializationHelper.Serialize(this);
        }

        private string _srcString;
        /// <summary>
        ///   Set the string presentation of the object
        /// </summary>
        public void SetSrcString(string value)
        {
            _srcString = value;
        }
    }
}
