// Copyright (c) 2018-2020, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: see LICENSE for more details.

namespace Elskom.Generic.Libs
{
    /// <summary>
    /// Class that holds the contant values to zlib.
    /// </summary>
    internal static class ZlibConst
    {
        // compression levels

        /// <summary>
        /// No compression.
        /// </summary>
        internal const int ZNOCOMPRESSION = 0;

        /// <summary>
        /// best speed compression level.
        /// </summary>
        internal const int ZBESTSPEED = 1;

        /// <summary>
        /// the best compression level.
        /// </summary>
        internal const int ZBESTCOMPRESSION = 9;

        /// <summary>
        /// The default compression level.
        /// </summary>
        internal const int ZDEFAULTCOMPRESSION = -1;

        // compression strategy

        /// <summary>
        /// Filtered compression strategy.
        /// </summary>
        internal const int ZFILTERED = 1;

        /// <summary>
        /// huffman compression strategy.
        /// </summary>
        internal const int ZHUFFMANONLY = 2;

        /// <summary>
        /// The default compression strategy.
        /// </summary>
        internal const int ZDEFAULTSTRATEGY = 0;

        /// <summary>
        /// No flush.
        /// </summary>
        internal const int ZNOFLUSH = 0;

        /// <summary>
        /// Partial flush.
        /// </summary>
        internal const int ZPARTIALFLUSH = 1;

        /// <summary>
        /// Sync flush.
        /// </summary>
        internal const int ZSYNCFLUSH = 2;

        /// <summary>
        /// Full flush.
        /// </summary>
        internal const int ZFULLFLUSH = 3;

        /// <summary>
        /// Finish compression or decompression.
        /// </summary>
        internal const int ZFINISH = 4;

        /// <summary>
        /// All is ok.
        /// </summary>
        internal const int ZOK = 0;

        /// <summary>
        /// Stream ended early.
        /// </summary>
        internal const int ZSTREAMEND = 1;

        /// <summary>
        /// Need compression dictionary.
        /// </summary>
        internal const int ZNEEDDICT = 2;

        /// <summary>
        /// Some other error.
        /// </summary>
        internal const int ZERRNO = -1;

        /// <summary>
        /// Stream error.
        /// </summary>
        internal const int ZSTREAMERROR = -2;

        /// <summary>
        /// Data error.
        /// </summary>
        internal const int ZDATAERROR = -3;

        /// <summary>
        /// Memory error.
        /// </summary>
        internal const int ZMEMERROR = -4;

        /// <summary>
        /// Buffer error.
        /// </summary>
        internal const int ZBUFERROR = -5;

        /// <summary>
        /// Zlib version error.
        /// </summary>
        internal const int ZVERSIONERROR = -6;
    }
}