using System;
using System.Collections.Generic;

namespace KeysHandler.Models;

public class Platform
{
    public string Name { get; set; }

    public string Description { get; set; }

    public List<String> URLs { get; set; }

    public List<VerifyRecord> VerifyRecords { get; set; }
}

