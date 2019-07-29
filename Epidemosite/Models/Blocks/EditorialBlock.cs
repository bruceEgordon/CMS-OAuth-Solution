using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Epidemosite.Models.Blocks
{
    [ContentType(DisplayName = "Editorial", GUID = "c4abefcb-bc4a-4986-b265-2448ee0b6dbe",
        Description = "Use this for a rich editorial text that will be reused in multiple places.")]
    public class EditorialBlock : BlockData
    {
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page," +
            " using the XHTML-editor you can insert for example text, images and tables.")]
        public virtual XhtmlString MainBody { get; set; }
    }
}