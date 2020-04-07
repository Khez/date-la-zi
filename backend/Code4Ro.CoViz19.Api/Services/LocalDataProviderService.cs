﻿using System;
using System.Threading.Tasks;
using Code4Ro.CoViz19.Models;
using Code4Ro.CoViz19.Models.ParsedPdfModels;
using Code4Ro.CoViz19.Services;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Code4Ro.CoViz19.Api.Services
{
    public class LocalDataProviderService : IDataProviderService
    {
        private readonly IFileService _fileService;
        private readonly ILogger<LocalDataProviderService> _logger;
        private ParsedDataModel _localData;

        public LocalDataProviderService(IFileService fileService, ILogger<LocalDataProviderService> logger)
        {
            _fileService = fileService;
            _logger = logger;
        }


        public async Task<ParsedDataModel> GetCurrentData() =>
            _localData = JsonConvert.DeserializeObject<ParsedDataModel>(await _fileService.GetRawData());

        public async Task<HistoricalPdfStats> GetCurrentPdfData()
        {
            try
            {
                _logger.LogInformation($"starting to read from _fileService of type {_fileService.GetType()}");
                await Task.FromResult(0);
                var rawData = await _fileService.GetRawData() ?? string.Empty;
                var result = JsonConvert.DeserializeObject<HistoricalPdfStats>(rawData);
                _logger.LogDebug($"done reading from _fileService");
                return result ?? new HistoricalPdfStats();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error deserializing object");
                return new HistoricalPdfStats();
            }
        }
    }

}
