
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Batch barcode generation request.
    /// </summary>
    public class BatchGenerateRequest : IToString
    {
        /// <summary>
        ///     Format of the returned archive. Default value: Zip.
        /// </summary>
        public BatchArchiveFormat? ArchiveFormat { get; set; }

        /// <summary>
        ///     Barcodes to generate. A batch must contain between one and three items.
        /// </summary>
        public List<BatchGenerateItem> Items { get; set; }

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
