﻿
namespace Anycmd.Engine.Edi.Messages
{
    using InOuts;

    public class AddOrganizationActionCommand: AddEntityCommand<IOrganizationActionCreateIo>, IAnycmdCommand
    {
        public AddOrganizationActionCommand(IOrganizationActionCreateIo input)
            : base(input)
        {

        }
    }
}