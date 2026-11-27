
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     One barcode to generate in a batch.
    /// </summary>
    public class BatchGenerateItem : IToString
    {
        /// <summary>
        ///     Optional file name inside the archive. When omitted or blank, a sequential name is generated. Supplied safe names are preserved; the image format is independent of the file extension.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     Barcode generation parameters.
        /// </summary>
        public GenerateParams Generation { get; set; }

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
