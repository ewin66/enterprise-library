﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================


namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Contains a collection of <see cref="TypeRegistrationProviderElement"/>.
    /// </summary>
    public class TypeRegistrationProviderElementCollection : NamedElementCollection<TypeRegistrationProviderElement>
    {
        /// <summary>
        /// Creates a new instance of <see cref="TypeRegistrationProviderElementCollection"/>.
        /// </summary>
        public TypeRegistrationProviderElementCollection()
        {
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.CachingTypeRegistrationProviderName, SectionName = BlockSectionNames.Caching });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.CryptographyTypeRegistrationProviderName, SectionName = BlockSectionNames.Cryptography });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.ExceptionHandlingTypeRegistrationProviderName, SectionName = BlockSectionNames.ExceptionHandling });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.InstrumentationTypeRegistrationProviderName, SectionName = BlockSectionNames.Instrumentation });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.LoggingTypeRegistrationProviderName, SectionName = BlockSectionNames.Logging });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.PolicyInjectionTypeRegistrationProviderName, SectionName = BlockSectionNames.PolicyInjection });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.SecurityTypeRegistrationProviderName, SectionName = BlockSectionNames.Security });
            //BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.DataAccessTypeRegistrationProviderName, ProviderTypeName = BlockSectionNames.DataRegistrationProviderLocatorType });
            BaseAdd(new TypeRegistrationProviderElement() { Name = TypeRegistrationProvidersConfigurationSection.ValidationTypeRegistrationProviderName, ProviderTypeName = BlockSectionNames.ValidationRegistrationProviderLocatorType });
        }
    }
}
