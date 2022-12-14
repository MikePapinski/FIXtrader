// <auto-generated>
//     Generated SBE (Simple Binary Encoding) message codec
// </auto-generated>

#pragma warning disable 1591 // disable warning on missing comments
using System;
using System.Text;
using Org.SbeTool.Sbe.Dll;

namespace MsgSchema
{
    public enum OrderExecutionType : byte
    {
        /// <summary>
        /// Execute instantly on the market price.
        /// </summary>
        MARKET = 1,
        /// <summary>
        /// Set the pending limit order
        /// </summary>
        LIMIT = 2,
        /// <summary>
        /// Sell the pending stop order
        /// </summary>
        STOP = 3,
        NULL_VALUE = 255
    }
}
