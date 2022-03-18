using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetFlow.Api.Dto.Episose
{
   public  class GetAllEpisodeDto
    {
        public int Id { get; set; }
        public int Nb_Episode { get; set; }
        public string Name { get; set; }
        public DateTime DateEpisode { get; set; }
        public string Resume { get; set; }
        public int SaisonNumber { get; set; }
        public int NbSaison { get; set; }

    }
}
