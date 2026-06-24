
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Data to encode in a barcode.
    /// </summary>
    public class EncodeData : IToString
    {
        /// <summary>
        ///     Type of data to encode. Default value: StringData.
        /// </summary>
        public EncodeDataType? DataType { get; set; }

        /// <summary>
        ///     String that represents the data to encode.
        /// </summary>
        public string Data { get; set; }

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
