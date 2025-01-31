﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model.Primitives;
using Microsoft.Health.Fhir.Core.Features.Search.SearchValues;

namespace Microsoft.Health.Fhir.Core.Features.Search.Converters
{
    /// <summary>
    /// A converter used to convert from <see cref="Coding"/> to a list of <see cref="TokenSearchValue"/>.
    /// </summary>
    public class CodingToTokenSearchValueConverter : FhirTypedElementToSearchValueConverter<TokenSearchValue>
    {
        public CodingToTokenSearchValueConverter()
            : base("Coding")
        {
        }

        protected override IEnumerable<ISearchValue> Convert(ITypedElement value)
        {
            TokenSearchValue searchValue = value.ToTokenSearchValue();

            if (searchValue != null)
            {
                yield return searchValue;
            }
        }
    }
}
