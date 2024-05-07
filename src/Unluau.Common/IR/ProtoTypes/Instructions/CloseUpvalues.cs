﻿namespace Unluau.Common.IR.ProtoTypes.Instructions
{
    /// <summary>
    /// Represents a close upvalues instruction.
    /// </summary>
    public class CloseUpvalues(uint value) : InstructionABC(value)
    {
        /// <inheritdoc/>
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}