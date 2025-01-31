﻿using HotChocolate;
using Nikcio.UHeadless.UmbracoContent.Properties.Bases.Models;
using Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.Default.Commands;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Nikcio.UHeadless.UmbracoContent.Properties.EditorsValues.ContentPicker
{
    /// <summary>
    /// Represents a content picker value
    /// </summary>
    [GraphQLDescription("Represents a content picker value.")]
    public class ContentPickerGraphType : PropertyValueBaseGraphType
    {
        /// <summary>
        /// Gets the list of content
        /// </summary>
        [GraphQLDescription("Gets the list of content.")]
        public virtual List<ContentPickerItemGraphType> ContentList { get; set; } = new();

        /// <inheritdoc/>
        public ContentPickerGraphType(CreatePropertyValue createPropertyValue) : base(createPropertyValue)
        {
            var objectValue = createPropertyValue.Property.GetValue(createPropertyValue.Culture);
            if (objectValue is IPublishedContent content)
            {
                ContentList.Add(new ContentPickerItemGraphType(content));
            }
            else if (objectValue != null)
            {
                var contentList = (IEnumerable<IPublishedContent>)objectValue;
                if (contentList != null)
                {
                    foreach (var contentItem in contentList)
                    {
                        ContentList.Add(new ContentPickerItemGraphType(contentItem));
                    }
                }
            }
        }
    }
}
