﻿namespace AutoMapper.Attributes.V5.TestAssembly.MapsToTests
{
    public class DestinationData
    {
        public string Name { get; set; }
        [MapsFromProperty(typeof(SourceData), nameof(SourceData.NotNullableInt))]
        public int? NullableInt { get; set; }
        [MapsFromProperty(typeof(SourceData), nameof(SourceData.SourceNullableInt))]
        public int TargetDestinationNonNullableInt { get; set; }
    }
}