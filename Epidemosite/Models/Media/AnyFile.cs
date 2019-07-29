using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Epidemosite.Models.Media
{
    [ContentType(DisplayName = "Any File", GUID = "0ed25a90-f5a4-4df1-89de-a12cd809192b", Description = "")]
    public class AnyFile : MediaData
    {
        
    }
}