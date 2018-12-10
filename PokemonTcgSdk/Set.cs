using Newtonsoft.Json;
using PokemonTcgSdk.Models;
using System.Collections.Generic;

namespace PokemonTcgSdk
{
    public class Set : IBaseQueryModel
    {
        [JsonProperty("pagingInfo")]
        public PagingInfo PagingInfo { get; set; }

        [JsonProperty("sets")]
        public List<SetData> Cards { get; set; }

        [JsonProperty("set")]
        public SetData Card { get; set; }
    }
}