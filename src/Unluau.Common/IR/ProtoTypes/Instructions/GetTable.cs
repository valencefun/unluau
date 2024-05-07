﻿namespace Unluau.Common.IR.ProtoTypes.Instructions
{
    /// <summary>
    /// Represents a get table instruction.
    /// </summary>
    public class GetTable(uint value) : InstructionABC(value)
    {
        /// <inheritdoc/>
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}