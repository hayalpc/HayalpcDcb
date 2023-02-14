using Hayalpc.Dcb.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hayalpc.Dcb.Common.Dtos
{
    public class BlobFileDto : Hayalpc.Library.Common.Dtos.BlobFileDto
    {
        public new BlobFileType Type { get; set; }
    }
}
