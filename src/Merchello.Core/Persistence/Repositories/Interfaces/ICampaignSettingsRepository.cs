﻿namespace Merchello.Core.Persistence.Repositories
{
    using System;

    using Merchello.Core.Models;

    using Umbraco.Core.Persistence.Repositories;

    /// <summary>
    /// Marker interface for the CampaignSettingsRepository.
    /// </summary>
    internal interface ICampaignSettingsRepository : IRepositoryQueryable<Guid, ICampaignSettings>
    {
    }
}