using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Epidemosite.Models.Pages
{
    [ContentType(DisplayName = "Bio Page", GUID = "4294d990-3092-4dd6-bc20-b81235d25911",
        Description = "Bio page for Acme employees", GroupName = "Main Content")]
    public class BioPage : StartPage
    {
        [UIHint("StringsList")]
        public virtual IList<string> Accomplishments { get; set; }
    }
}