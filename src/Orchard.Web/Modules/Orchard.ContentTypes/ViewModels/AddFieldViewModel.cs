﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.Metadata.Models;

namespace Orchard.ContentTypes.ViewModels
{
    public class AddFieldViewModel
    {
        public AddFieldViewModel()
        {
            Fields = new List<ContentFieldInfo>();
        }

        /// <summary>
        /// The technical name of the field
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The display name of the field
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The selected field type
        /// </summary>
        public string FieldTypeName { get; set; }

        /// <summary>
        /// The part to add the field to
        /// </summary>
        [BindNever]
        public ContentPartDefinition Part { get; set; }

        /// <summary>
        /// List of the available Field types
        /// </summary>
        [BindNever]
        public IEnumerable<ContentFieldInfo> Fields { get; set; }
    }
}