// <auto-generated>
//     Generated SBE (Simple Binary Encoding) message codec
// </auto-generated>

#pragma warning disable 1591 // disable warning on missing comments
using System;
using System.Text;
using Org.SbeTool.Sbe.Dll;

namespace MsgSchema
{
    public enum OrderProcessingResult : byte
    {
        /// <summary>
        /// Order filled.
        /// </summary>
        FILLED = 1,
        /// <summary>
        /// Order rejected due to requote.
        /// </summary>
        REQUOTE = 2,
        /// <summary>
        /// Order rejected due to trade disabled on account.
        /// </summary>
        TRADE_DISABLED = 3,
        /// <summary>
        /// Timeout during order processing.
        /// </summary>
        TIMEOUT = 4,
        /// <summary>
        /// Order rejected due to wrong symbol.
        /// </summary>
        WRONG_SYMBOL = 5,
        /// <summary>
        /// Order rejected due to not enough money in the account.
        /// </summary>
        NOT_ENOUGH_MONEY = 6,
        /// <summary>
        /// Order rejected due to closed market.
        /// </summary>
        MARKET_IS_CLOSED = 7,
        /// <summary>
        /// Order modified.
        /// </summary>
        MODIFIED = 8,
        /// <summary>
        /// Order rejected.
        /// </summary>
        REJECTED = 9,
        NULL_VALUE = 255
    }
}
