
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Barcode generation parameters.
    /// </summary>
    public class GenerateParams : IToString
    {
        /// <summary>
        ///     Gets or sets BarcodeType
        /// </summary>
        public EncodeBarcodeType? BarcodeType { get; set; }

        /// <summary>
        ///     Gets or sets EncodeData
        /// </summary>
        public EncodeData EncodeData { get; set; }

        /// <summary>
        ///     Gets or sets BarcodeImageParams
        /// </summary>
        public BarcodeImageParams BarcodeImageParams { get; set; }

        /// <summary>
        ///     Gets or sets QrParams
        /// </summary>
        public QrParams QrParams { get; set; }

        /// <summary>
        ///     Gets or sets Code128Params
        /// </summary>
        public Code128Params Code128Params { get; set; }

        /// <summary>
        ///     Gets or sets Pdf417Params
        /// </summary>
        public Pdf417Params Pdf417Params { get; set; }

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
