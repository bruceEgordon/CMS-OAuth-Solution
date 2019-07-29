using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Epidemosite.Models.Media
{
    [ContentType(DisplayName = "Image File", GUID = "eda6b2ff-cd21-43da-9ce7-4ba2a8ffc91b", Description = "Use this to upload images")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

    }
}