﻿using System;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Models;
using HotChocolate;

namespace Nikcio.UHeadless.UmbracoContent.ContentType.Models
{
    /// <summary>
    /// Represents a content type
    /// </summary>
    [GraphQLDescription("Represents a content type.")]
    public class ContentTypeGraphType
    {
        /// <summary>
        /// Gets the unique key for the content type
        /// </summary>
        [GraphQLDescription("Gets the unique key for the content type.")]
        public virtual Guid Key { get; set; }

        /// <summary>
        /// Gets the content type identifier
        /// </summary>
        [GraphQLDescription("Gets the content type identifier.")]
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets the content type alias
        /// </summary>
        [GraphQLDescription("Gets the content type alias.")]
        public virtual string? Alias { get; set; }

        /// <summary>
        /// Gets the content item type
        /// </summary>
        [GraphQLDescription("Gets the content item type.")]
        public virtual PublishedItemType ItemType { get; set; }

        /// <summary>
        /// Gets the aliases of the content types participating in the composition
        /// </summary>
        [GraphQLDescription("Gets the aliases of the content types participating in the composition.")]
        public virtual HashSet<string>? CompositionAliases { get; set; }

        /// <summary>
        /// Gets the content variations of the content type
        /// </summary>
        [GraphQLDescription("Gets the content variations of the content type.")]
        public virtual ContentVariation Variations { get; set; }

        /// <summary>
        /// Gets a value indicating whether this content type is for an element
        /// </summary>
        [GraphQLDescription("Gets a value indicating whether this content type is for an element.")]
        public virtual bool IsElement { get; set; }
    }
}
