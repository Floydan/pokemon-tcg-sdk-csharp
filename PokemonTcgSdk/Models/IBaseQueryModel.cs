using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTcgSdk.Models
{
    public interface IBaseQueryModel
    {
        PagingInfo PagingInfo { get; set; }
    }
}
